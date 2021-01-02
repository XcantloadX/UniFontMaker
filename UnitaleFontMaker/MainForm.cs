using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace UnitaleFontMaker
{

	public partial class MainForm : Form
	{
		private FontPainter painter;
		private int width;
		private int height;
        private List<char> characters = new List<char>(300);
        private Color fontColor = Color.White;
        
        
        public MainForm()
		{
            InitializeComponent();
            Font font = new Font("宋体", 14);
			Brush brush = Brushes.White;
			painter = new FontPainter(font, 400, 400);

            picboxColor.BackColor = fontColor;

            AddChars(Character.ENGLISH_CHARS);
		}
		
		//保存为文件
		private void BtnSaveFileClick(object sender, EventArgs e)
		{
            if (!SaveCheck())
                return;

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Choose a folder to save.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.SelectedPath;

                painter.Size = new Size(width, height);
                painter.Characters = characters.ToArray();
                painter.Save(Path.Combine(path, comboxType.Text + ".png"));

                Character[] chars = painter.GetCharacters();
                chars = painter.PositionConvert(chars);//坐标转换
                FontXml xml = new FontXml();
                xml.Voice = "uifont";
                xml.LineSpacing = txtboxLineSpacing.Text;
                xml.Characters = chars;
                xml.Save(Path.Combine(path, comboxType.Text + ".xml"));
            }
		}

        /// <summary>
        /// 保存文件之前的检查工作
        /// </summary>
        /// <returns>是否通过检查</returns>
        private bool SaveCheck()
        {
            //检查字体名称
            if (string.IsNullOrWhiteSpace(comboxType.Text))
            {
                Utils.ShowError("A font name is needed.");
                return false;
            }

            //检查字符是否为空
            if(characters.Count <= 0)
            {
                Utils.ShowError("Try add some characters.");
                return false;
            }

            //检查行距
            if(string.IsNullOrWhiteSpace(txtboxLineSpacing.Text))
            {
                Utils.ShowError("Line spacing is needed.");
                return false;
            }

            try
            {
                int.Parse(txtboxLineSpacing.Text);
            }
            catch
            {
                Utils.ShowError("Invalid line spacing.");
                return false;
            }

            //检查大小
            try
            {
                width = int.Parse(txtboxX.Text);
                height = int.Parse(txtboxY.Text);
            }
            catch
            {
                Utils.ShowError("Invalid size.");
            }

            return true;
        }

        private bool ApplySettings()
        {
            try
            {
                painter.Size = new Size(int.Parse(txtboxX.Text), int.Parse(txtboxY.Text));
                painter.TextColor = fontColor;
                painter.fontYOffset = float.Parse(textBoxFontYOffset.Text);
                painter.drawDebugBorders = checkBoxDrawBorder.Checked;
            }
            catch (FormatException)
            {
                Utils.ShowError("Invail value! Please check if all the numbers you entered is correct.");
            }


            return true; //TODO 继续完善
        }

        private void btnChangeNomalFont_Click(object sender, EventArgs e)
		{
			FontDialog dialog = new FontDialog();
            dialog.Font = painter.Font; //设置为上一次的字体，方便修改
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK && dialog.Font != null)
                {
                    painter.Font = dialog.Font;
                    lblNormalFontInfo.Text = string.Format("{0} {1}", dialog.Font.Name, dialog.Font.Size);
                    lblNormalFontPreview.Font = dialog.Font;
                }
                
            }
            catch (ArgumentException ex)
            {
                if(ex.Message.Contains("TrueType"))
                    Utils.ShowError("TrueType font is not supported! Try google how to convert .otf to .ttf .");
            }
            dialog.Dispose();
        }

        private void btnChangeEnglishFont_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.Font = painter.EnglishFont; //设置为上一次的字体，方便修改
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK && dialog.Font != null)
                {
                    painter.EnglishFont = dialog.Font;
                    lblEnglishFontInfo.Text = string.Format("{0} {1}", dialog.Font.Name, dialog.Font.Size);
                    lblEnglishFontPreview.Font = dialog.Font;
                }

            }
            catch (ArgumentException ex)
            {
                if (ex.Message.Contains("TrueType"))
                    Utils.ShowError("TrueType font is not supported! Try google how to convert .otf to .ttf .");
            }
            dialog.Dispose();
        }
		
		void BtnPreviewClick(object sender, EventArgs e)
		{
            ApplySettings();

			try 
			{
				width = int.Parse(txtboxX.Text);
				height = int.Parse(txtboxY.Text);
			} 
			catch
			{
				Utils.ShowError("Invalid size.");
                return;
			}
			
            painter.Characters = characters.ToArray();
			painter.Size = new Size(width, height);
            painter.fontYOffset = float.Parse(textBoxFontYOffset.Text);
			painter.Paint();
			
			PreviewForm previewForm = new PreviewForm(painter);
			previewForm.Show();
		}

        //--------------字符选择部分----------------
        //选择文件
        void btnAddChar_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Text file(*.txt)|*.txt";
			dialog.Title = "Open a text file:";
			if(dialog.ShowDialog() == DialogResult.OK)
			{
                AddChars(File.ReadAllText(dialog.FileName));
			}
            dialog.Dispose();
		}

        //清除字符
        private void btnClear_Click(object sender, EventArgs e)
        {
            characters.Clear();
            AddChars(Character.ENGLISH_CHARS);
        }

        //增加英文字符
        private void btnAddEnChar_Click(object sender, EventArgs e)
        {
            AddChars(Character.ENGLISH_CHARS);
            labCharNum.Text = "Character Num: " + characters.Count;
        }

        public void AddChars(string s)
        {            
            for (int i = 0; i < s.Length; i++)
            {
                if (!characters.Contains(s[i]))
                    characters.Add(s[i]);
            }

            labCharNum.Text = "Character: " + characters.Count; //更新显示
        }

        public void AddChars(char[] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (!characters.Contains(chars[i]))
                    characters.Add(chars[i]);
            }

            labCharNum.Text = "Character: " + characters.Count; //更新显示
        }

        //--------------字体颜色设置部分---------------
        //选择颜色
        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                fontColor = dialog.Color;
                painter.TextColor = fontColor;
                picboxColor.BackColor = fontColor;
            }
            dialog.Dispose();
        }

    }
}
