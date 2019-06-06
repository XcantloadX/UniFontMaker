using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace UnitaleFontMaker
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private FontPainter painter;
		private int width;
		private int height;
		private string chars;
        private Color fontColor = Color.White;
        private const string enChars = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~ ";

        public MainForm()
		{
			InitializeComponent();
			Font font = new Font("微软雅黑", 14);
			Brush brush = Brushes.White;
			painter = new FontPainter(font, 400, 400);
            picboxColor.BackColor = fontColor;
		}
		
        /// <summary>
        /// 显示一个带错误图标的信息框
        /// </summary>
        /// <param name="str">要显示的信息</param>
		private void ShowError(string str)
		{
			MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		private void CopyDir( string srcPath, string aimPath )
		{
			try {
				/* 检查目标目录是否以目录分割字符结束如果不是则添加 */
				if ( aimPath[aimPath.Length - 1] != System.IO.Path.DirectorySeparatorChar )
				{
					aimPath += System.IO.Path.DirectorySeparatorChar;
				}
				/* 判断目标目录是否存在如果不存在则新建 */
				if ( !System.IO.Directory.Exists( aimPath ) )
				{
					System.IO.Directory.CreateDirectory( aimPath );
				}
				/*
				* 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
				* 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
				* string[] fileList = Directory.GetFiles（srcPath）；
				*/
				string[] fileList = System.IO.Directory.GetFileSystemEntries( srcPath );
				/* 遍历所有的文件和目录 */
				foreach ( string file in fileList )
				{
					/* 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件 */
					if ( System.IO.Directory.Exists( file ) )
					{
						CopyDir( file, aimPath + System.IO.Path.GetFileName( file ) );
					}
					/* 否则直接Copy文件 */
					else {
						System.IO.File.Copy( file, aimPath + System.IO.Path.GetFileName( file ), true );
					}
				}
			} catch ( Exception e ) {
				throw;
			}
		}
		
        //自动保存
		private void BtnAutoSaveClick(object sender, EventArgs e)
		{
            if (!SaveCheck())
                return;

            string modPath = txtboxModPath.Text;
			string unitalePath = new DirectoryInfo(modPath).Parent.Parent.FullName;
			string defaultFontPath = Path.Combine(unitalePath, "Default\\Sprites\\UI\\Fonts");
			string modFontPath = Path.Combine(modPath, "Sprites\\UI\\Fonts");
			
			//备份原文件
			if(Directory.Exists(modFontPath))
				Directory.Move(modFontPath, Path.Combine(new DirectoryInfo(modFontPath).Parent.FullName, "Fonts_backup"));
			
			//复制默认字体文件
			CopyDir(defaultFontPath, modFontPath);
			
			//删除要替换的字体文件
			File.Delete(Path.Combine(modFontPath, "uidialog.png"));
			File.Delete(Path.Combine(modFontPath, "uidialog.xml"));
			
			//保存图片
			painter.Save(Path.Combine(modFontPath, "uidialog.png"));
			
			//保存XML
			Character[] chars = painter.GetCharacters();
			chars = painter.PositionConvert(chars);//坐标转换
			FontXml xml = new FontXml();
			xml.Voice = "uifont";
			xml.LineSpacing = ((int)chars[0].Height).ToString();
			xml.Characters = chars;
			xml.Save(Path.Combine(modFontPath, "uidialog.xml"));
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

                painter.Text = this.chars;
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
                ShowError("Please enter a font name!");
                return false;
            }

            //检查字符是否为空
            if(string.IsNullOrEmpty(chars))
            {
                ShowError("You have not added a character yet!");
                return false;
            }

            //检查字体中是否含有英文字符
            Regex regex = new Regex(@"[^\u4e00-\u9fa5]");
            if(!regex.IsMatch(chars))
            {
                ShowError("No English characters found, please add to the font!");
                return false;
            }

            //检查行距
            if(string.IsNullOrWhiteSpace(txtboxLineSpacing.Text))
            {
                ShowError("Line spacing is empty.");
                return false;
            }

            try
            {
                int.Parse(txtboxLineSpacing.Text);
            }
            catch (Exception e)
            {
                ShowError("Invalid line spacing.");
                return false;
            }

            return true;
        }
		
		private void Button2Click(object sender, EventArgs e)
		{
			FontDialog dialog = new FontDialog();
			dialog.ShowDialog();
			if(dialog.Font != null)
				painter.font = dialog.Font;
            dialog.Dispose();
		}
		
		void BtnPreviewClick(object sender, EventArgs e)
		{
			try 
			{
				width = int.Parse(txtboxX.Text);
				height = int.Parse(txtboxY.Text);
			} 
			catch (Exception ex) 
			{
				ShowError("Invalid size.");
			}
			
			painter.Text = chars;
			painter.Size = new Size(width, height);
			painter.Paint();
			
			PreviewForm previewForm = new PreviewForm(painter);
			previewForm.Show();
		}

        //--------------字符选择部分----------------
        //选择文件
        void BtnAddFileClick(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Text file(*.txt)|*.txt";
			dialog.Title = "Open a file";
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				chars += File.ReadAllText(dialog.FileName);
				labCharNum.Text = "Character: " + chars.Length;
			}
            dialog.Dispose();
		}

        //清除字符
        private void btnClear_Click(object sender, EventArgs e)
        {
            chars = "";
            labCharNum.Text = "No characters, please add from text file.";
        }

        //增加英文字符
        private void btnAddEnChar_Click(object sender, EventArgs e)
        {
            chars += enChars;
            labCharNum.Text = "Character: " + chars.Length;
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

        //-----------------Mod设置部分------------

        //选择Mod路径按钮
        void BtnOpenModClick(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.Description = "Choose your Unitale mod.";
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				string path = dialog.SelectedPath;
				if(!Directory.Exists(Path.Combine(path, "Lua")))
				{
					ShowError("Invalid mod directory(Must have a \"Lua\" directory).");
					return;
				}	
				txtboxModPath.Text = dialog.SelectedPath;
			}
            dialog.Dispose();
		}

        //自动模式选择框
        void ChkboxAutoModeCheckedChanged(object sender, EventArgs e)
		{
            bool enabled = true;
            if (chkboxAutoMode.Checked)
                enabled = false;
			else
                enabled = true;

            btnAddChar.Enabled = enabled;
            btnClear.Enabled = enabled;
            btnAddEnChar.Enabled = enabled;
		}
		
		//自动模式的帮助
		void BtnAutoModeHtlpClick(object sender, EventArgs e)
		{
			MessageBox.Show("If you enable this option, the text in all Lua files will be automatically scanned and added to the font.", "Auto Mode Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


    }
}
