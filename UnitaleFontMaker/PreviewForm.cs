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

            //设置图片
			this.painter = painter;
			image = painter.GetImage();
			imageSize = new Size(image.Width, image.Height);
            pictureBox1.Image = Image.FromHbitmap(painter.GetImage().GetHbitmap());

            //调整图片框大小
            pictureBox1.Size = pictureBox1.Image.Size;

            //设置滚动条
            hScrollBar1.Maximum = pictureBox1.Image.Width - panel1.Width;
            vScrollBar1.Maximum = pictureBox1.Image.Height - panel1.Height;
		}
		
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point(-hScrollBar1.Value, pictureBox1.Location.Y);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, -vScrollBar1.Value);
        }

		
	}
}
