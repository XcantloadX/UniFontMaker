using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace UnitaleFontMaker
{
	/// <summary>
	/// 主界面
	/// </summary>
	public partial class MainForm : Form
	{
		private FontPainter painter;
		private int width;
		private int height;
		private string chars;
        private Color fontColor = Color.White;
        private List<string> characters = new List<string>();
        public string ModPath
		{
			get { return txtboxModPath.Text; }
		}
        
        
        public MainForm()
		{
			InitializeComponent();
			Font font = new Font("微软雅黑", 14);
			Brush brush = Brushes.White;
			painter = new FontPainter(font, 400, 400);
            picboxColor.BackColor = fontColor;

            //自动添加必须添加的字符
            chars += Characters.MUST_CHARS;
            labCharNum.Text = "Character: " + chars.Length;
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
			Utils.CopyDir(defaultFontPath, modFontPath);
			
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
                Utils.ShowError("Please enter a font name!");
                return false;
            }

            //检查字符是否为空
            if(string.IsNullOrEmpty(chars))
            {
                Utils.ShowError("You have not added a character yet!");
                return false;
            }

            //检查字体中是否含有英文字符
            Regex regex = new Regex(@"[^\u4e00-\u9fa5]");
            if(!regex.IsMatch(chars))
            {
                Utils.ShowError("No English characters found!");
                return false;
            }

            //检查行距
            if(string.IsNullOrWhiteSpace(txtboxLineSpacing.Text))
            {
                Utils.ShowError("Line spacing is empty.");
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
			catch
			{
				Utils.ShowError("Invalid size.");
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
				/*if(!Directory.Exists(Path.Combine(path, "Lua")))
				{
					Utils.ShowError("Invalid mod directory(Must have a \"Lua\" directory).");
					return;
				}	*/
				txtboxModPath.Text = dialog.SelectedPath;
			}
            dialog.Dispose();
		}
		
		//自动模式的帮助
		void BtnAutoModeHtlpClick(object sender, EventArgs e)
		{
			MessageBox.Show("If you enable this option, the text in all Lua files will be automatically scanned and added to the font.", "Auto Mode Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		//自动扫描
		void BtnScanClick(object sender, EventArgs e)
		{
			List<string> luaFiles = new List<string>();
			GetAllDirectory(ModPath, luaFiles);
			
			for (int i = 0; i < luaFiles.Count; i++) 
			{
				string[] strs = GetAllStrings(File.ReadAllText(luaFiles[i]));
			}
		}
		
		/// <summary>
		/// 获取Lua文件中的所有字符串
		/// </summary>
		/// <param name="lua">Lua文件的内容</param>
		/// <returns>获取到的字符串</returns>
		private string[] GetAllStrings(string lua)
		{
			int length = lua.Length;
			int index = 0;
			
			//TODO: 完成提取字符串的方法
			
			while(index <= length)
			{
				int start = lua.IndexOf('"', index);
				int end = lua.IndexOf('"', start + 1);
				string str = lua.Substring(start + 1, end - start - 1);
				//MessageBox.Show(str);
				index = end + 1;
			}
			
			return null;
		}
		
		/// <summary>
		/// 递归获取指定文件夹和子文件夹中的所有Lua文件
		/// </summary>
		/// <param name="path">指定路径</param>
		/// <param name="luaFiles">返回寻找到的Lua文件</param>
		private void GetAllDirectory(string path, List<string> luaFiles)
		{
			DirectoryInfo root = new DirectoryInfo(path);
            if (!root.Exists)
            {
                Utils.ShowError("Lua directory not found!");
                return;
            }
			DirectoryInfo[] dirs = root.GetDirectories();
			
			//扫描所有Lua文件
			FileInfo[] files = Utils.GetAllFiles(path);
			for (int i = 0; i < files.Length; i++) 
			{
				if(files[i].Extension == ".lua")
					luaFiles.Add(files[i].FullName);
			}
			
			//递归所有子文件夹
			for (int i = 0; i < dirs.Length; i++) 
			{
				GetAllDirectory(dirs[i].FullName, luaFiles);
			}
			
		}

        private void MainForm_Load(object sender, EventArgs e)
        {
        }


    }
}
