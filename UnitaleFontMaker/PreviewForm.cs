/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2019/6/1 星期六
 * Time: 17:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UnitaleFontMaker
{
	/// <summary>
	/// Description of PreviewForm.
	/// </summary>
	public partial class PreviewForm : Form
	{
		private FontPainter painter;
		
		public PreviewForm(FontPainter painter)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.painter = painter;
			//painter.DisplayGraphics = pictureBox1.CreateGraphics();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PreviewFormLoad(object sender, EventArgs e)
		{
			Image image = painter.GetImage();
			this.Width = image.Width;
			this.Height = image.Height;
			
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Size = new Size(this.Width, this.Height);
			pictureBox1.Image = Image.FromHbitmap(painter.GetImage().GetHbitmap());
		}
		
		void PictureBox1Paint(object sender, PaintEventArgs e)
		{
			//painter.Paint();
		}
	}
}
