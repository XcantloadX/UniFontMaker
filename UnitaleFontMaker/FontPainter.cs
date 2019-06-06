using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D; 
using System.Drawing.Imaging; 
using System.Text;
using System.Diagnostics;

namespace UnitaleFontMaker
{

	public class FontPainter
	{
		private Graphics gImage;
		private Bitmap image;
		private SolidBrush brush;
		private SolidBrush backBrush;
		private int width;
		private int height;
		private string str;
		private StringFormat format;
		
		public Font font;
		
		public Color TextColor
		{
			get { return brush.Color; }
			set { brush.Color = value; }
		}

			
		public string Text
		{
			get { return str; }
			set { str = value; }
		}
		
		public Size Size
		{
			get { return new Size(width, height); }
			set 
			{
				Size s = ((Size)value);
				width = s.Width;
				height = s.Height;
				
				image = new Bitmap(width, height);
				gImage = Graphics.FromImage(image);
				gImage.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			}
		}
		
		public FontPainter(Font font, int width, int height)
		{
			this.font = font;
			brush = new SolidBrush(Color.White);
			backBrush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
			
			this.width = width;
			this.height = height;
			
			image = new Bitmap(width, height);
			gImage = Graphics.FromImage(image);
			gImage.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			
			format = StringFormat.GenericTypographic;
			format.FormatFlags = format.FormatFlags | StringFormatFlags.MeasureTrailingSpaces;
		}
		
		
		public void Paint()
		{
			//gImage.FillRectangle(backBrush, 0, 0, this.width, this.height);
			gImage.Clear(Color.FromArgb(0, 0, 0, 0));
			
			Character[] chars = GetCharacters();
			if(chars == null)
				return;
			
			for (int i = 0; i < chars.Length; i++) 
			{
				int x = (int)chars[i].X;
				int y = (int)chars[i].Y;
				int width = (int)chars[i].Width;
				int height = (int)chars[i].Height;
				
				gImage.DrawString(chars[i].Char.ToString(), font, brush, x, y, format);
			}
		}
		
		public void Save(string path)
		{
			Paint();
			image.Save(path);
			
		}
		
		public Bitmap GetImage()
		{
			return image;
		}
		
		public Character[] GetCharacters()
		{
			if(string.IsNullOrEmpty(Text))
				return null;
			
			char[] chars = Text.ToCharArray();
			Character[] characters = new Character[chars.Length];
			
			float x = 0;
			float y = 0;
			
			for (int i = 0; i < chars.Length; i++) 
			{
				//转换前（左上原点）
				float width = GetCharWidth(font, chars[i]);
				float height = GetCharHeight(font, chars[i]);
				
				Character c = new Character(chars[i], x, y, width, height);
				characters[i] = c;
				
				
				x += width + 3;
				
				if(x + GetCharWidth(font, chars[i]) + 3 > this.width)
				{
					x = 0;
					y += height;
				}
			}
			
			return characters;
		}
		
		public Character[] PositionConvert(Character[] chars)
		{
			for (int i = 0; i < chars.Length; i++) 
			{
				chars[i].Y = this.height - chars[i].Y - chars[i].Height;
			}
			return chars;
		}
		
		private float GetCharWidth(Font font, char c)
		{
			return gImage.MeasureString(c.ToString(), font, width, format).Width;
		}
		
		private float GetCharHeight(Font font, char c)
		{
			return gImage.MeasureString(c.ToString(), font, width, format).Height;
		}
		
	}
}
