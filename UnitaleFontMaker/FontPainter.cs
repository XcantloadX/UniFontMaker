using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D; 
using System.Drawing.Imaging; 
using System.Text;
using System.Diagnostics;

namespace UnitaleFontMaker
{

    /// <summary>
    /// 字体绘制
    /// </summary>
	public class FontPainter
	{
		private Graphics gImage;
		private Bitmap image;
		private SolidBrush brush;
		private SolidBrush backBrush;
		private int width;
		private int height;
		private string str;
        private char[] characters;
		private StringFormat format;
		
		public Font font;
		
        /// <summary>
        /// 字体的颜色
        /// </summary>
		public Color TextColor
		{
			get { return brush.Color; }
			set { brush.Color = value; }
		}

        /// <summary>
        /// 待绘制的文本
        /// </summary>
		public string Text
		{
			get { return str; }
			set { str = value; }
		}

        public char[] Characters
        {
            get { return characters; }
            set { characters = value; }
        }
		
		public Size Size
		{
			get { return new Size(width, height); }
			set 
			{
				Size s = value;
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
			gImage.Clear(Color.FromArgb(0, 0, 0, 0)); //使用透明颜色清除背景
			
            //获取所有字符
			Character[] chars = GetCharacters();
			if(chars == null)
				return;
			
            //遍历绘制字符
			for (int i = 0; i < chars.Length; i++) 
			{
                gImage.DrawString(chars[i].Char.ToString(), font, brush, chars[i].X, chars[i].Y);
			}

		}
		
        /// <summary>
        /// 保存图片到指定路径
        /// </summary>
        /// <param name="path">图片路径</param>
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
            if (Characters == null || Characters.Length <= 0)
				return null;
			
            char[] chars = Characters;
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
