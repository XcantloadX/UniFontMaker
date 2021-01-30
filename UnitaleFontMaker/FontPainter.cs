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
    /// 字体绘制类
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

        /// <summary>
        /// 将会用此字符的宽度来代替默认空格字符的宽度
        /// </summary>
        public char SpaceWidthChar = 'A';

        /// <summary>
        /// 默认字体
        /// </summary>
        public Font Font { get; set; }
        /// <summary>
        /// 如果此项不为空，则绘制英文字符时使用此字体
        /// </summary>
        public Font EnglishFont { get; set; }
        /// <summary>
        /// 默认字体的 Y 坐标 Offset TODO 1
        /// </summary>
        public int fontYOffset = 0;
        
        public bool drawDebugBorders = false;

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
			this.Font = font;
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
		
		/// <summary>
		/// 绘制
		/// </summary>
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
                //TODO ！注意一定要取整！（xml 文件里只能写整数坐标）
                int x = (int)chars[i].X;
                int y = (int)chars[i].Y;
                int width = (int)chars[i].Width;
                int height = (int)chars[i].Height;

                Font font = this.Font;
                if (!Character.isEnglishChar(chars[i])) //中文字体设置了 offset 的情况
                    y += (int)fontYOffset;
                
                gImage.DrawString(chars[i].Char.ToString(), GetFontByChar(chars[i].Char), brush, x, y, format);
                if (drawDebugBorders)
                    gImage.DrawRectangle(Pens.Red, x, y, width, height);
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
			
			int x = 5;
            int y = 0;
			
			for (int i = 0; i < chars.Length; i++) 
			{
				//转换前（左上原点）
				int width = (int)Math.Ceiling(GetCharWidth(Font, chars[i]));
				int height = (int)Math.Ceiling(GetCharHeight(Font, chars[i]));

                Character c = null;
                if(!Character.isEnglishChar(chars[i])) //非英文字体的 Offset
                    c = new Character(chars[i], x, y, width, height + fontYOffset);
                else
                    c = new Character(chars[i], x, y, width, height);
				characters[i] = c;
				
				
				x += width + 10;
				
				if(x + GetCharWidth(Font, chars[i]) + 10 > this.width)
				{
					x = 5;
					y += height + 10;
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
            if (c == ' ' && SpaceWidthChar != ' ') //使用自定义的空格宽度代替
                return GetCharWidth(font, SpaceWidthChar);
			return gImage.MeasureString(c.ToString(), GetFontByChar(c), width, format).Width;
		}
		
		private float GetCharHeight(Font font, char c)
		{
            return gImage.MeasureString(c.ToString(), GetFontByChar(c), width, format).Height;
		}

        /// <summary>
        /// 判断是使用英文字体还是默认字体
        /// </summary>
        /// <param name="c">待判断字符</param>
        /// <returns>应该使用的字体</returns>
        private Font GetFontByChar(char c)
        {
            if (EnglishFont != null && Character.isEnglishChar(c))
                return EnglishFont;
            else
                return Font;
        }
	}
}
