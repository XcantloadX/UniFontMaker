using System;
using System.Drawing;
using System.Windows.Forms;

namespace UnitaleFontMaker
{
	/// <summary>
	/// 字体图像预览窗口
	/// </summary>
	public partial class PreviewForm : Form
	{
		private FontPainter painter;
		private Size imageSize;
		private Image image;
		
		public PreviewForm(FontPainter painter)
		{
			InitializeComponent();

			this.painter = painter;
			image = painter.GetImage();
			imageSize = new Size(image.Width, image.Height);
		}
		
		void PreviewFormLoad(object sender, EventArgs e)
		{
			Resize(imageSize.Width, imageSize.Height);
		}
		
		void PictureBox1Paint(object sender, PaintEventArgs e)
		{
			//painter.Paint();
		}
		
		private void Resize(int width, int height)
		{
			this.Width = width;
			this.Height = height;
			
			pictureBox1.Location = new Point(0, 0 + menuStrip1.Size.Height);
			pictureBox1.Size = new Size(this.Width, this.Height);
			pictureBox1.Image = Image.FromHbitmap(painter.GetImage().GetHbitmap());
		}
		
		//TODO: 修复预览缩放功能
		//TODO: 增加字体绘制效果预览功能
		void ToolStripComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			string str = toolStripComboBox1.Text;
			str = str.Replace("%", "");
            try
            {
                int scale = int.Parse(str) / 100;
                int width = (int)(imageSize.Width * scale);
                int height = (int)(imageSize.Height * scale);
                Resize(width, height);
            }
            catch { throw; }

		}
		
	}
}
