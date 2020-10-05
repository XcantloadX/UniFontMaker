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
		//private string chars;
        private List<char> characters = new List<char>(300);
        private Color fontColor = Color.White;
        private const string ENGLISH_CHARS = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~ ";
        public string ModPath
		{
			get { return txtboxModPath.Text; }
		}
        
        
        public MainForm()
		{
			InitializeComponent();
			Font font = new Font("宋体", 14);
			Brush brush = Brushes.White;
			painter = new FontPainter(font, 400, 400);
            picboxColor.BackColor = fontColor;

            AddNewChars(ENGLISH_CHARS);
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
                ShowError("Please enter a font name!");
                return false;
            }

            //检查字符是否为空
            if(characters.Count <= 0)
            {
                ShowError("You have not added a character yet!");
                return false;
            }

            //检查字体中是否含有英文字符
            /*Regex regex = new Regex(@"[^\u4e00-\u9fa5]");
            if(!regex.IsMatch(chars))
            {
                ShowError("No English characters found, please add to the font!");
                return false;
            }*/

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

            //检查大小
            try
            {
                width = int.Parse(txtboxX.Text);
                height = int.Parse(txtboxY.Text);
            }
            catch
            {
                ShowError("Invalid size.");
            }

            return true;
        }
		
		private void Button2Click(object sender, EventArgs e)
		{
			FontDialog dialog = new FontDialog();
            dialog.Font = painter.font; //设置为上一次的字体，方便修改
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
			
			//painter.Text = chars;
            painter.Characters = characters.ToArray();
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
                AddNewChars(File.ReadAllText(dialog.FileName));
			}
            dialog.Dispose();

            
		}

        //清除字符
        private void btnClear_Click(object sender, EventArgs e)
        {
            characters.Clear();
            AddNewChars(ENGLISH_CHARS);
        }

        //增加英文字符
        private void btnAddEnChar_Click(object sender, EventArgs e)
        {
            AddNewChars(ENGLISH_CHARS);
            labCharNum.Text = "Character Num: " + characters.Count;
        }

        public void AddNewChars(string s)
        {            
            for (int i = 0; i < s.Length; i++)
            {
                if (!characters.Contains(s[i]))
                    characters.Add(s[i]);
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
			DirectoryInfo[] dirs = root.GetDirectories();
			
			//扫描所有Lua文件
			FileInfo[] files = GetAllFiles(path);
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
		
		/// <summary>
		/// 获取指定文件夹中的所有文件
		/// </summary>
		/// <param name="path">指定文件夹</param>
		private FileInfo[] GetAllFiles(string path)
		{
			DirectoryInfo root = new DirectoryInfo(path);
			FileInfo[] files = root.GetFiles();
			
			return files;
		}


    }
}
