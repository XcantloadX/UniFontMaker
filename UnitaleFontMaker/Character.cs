using System;
using System.Drawing;

namespace UnitaleFontMaker
{
    /// <summary>
    /// 单个字符
    /// </summary>
	public class Character
	{
		private char _char;
		private RectangleF rect;
        public static char[] ENGLISH_CHARS = { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'r', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '/', '*', '-', '+', ',', '.', '?', '!', '\'', '"', ':', ';', '/', '\\', '<', '>', '(', ')', '[', ']', '(', ')', '-', '_', '=', '~', '@', '#', '$', '%', '^', '&', '*', '(', ')', ' ' }; //别忘了空格字符！

		public char Char
		{
			get { return _char; }
		}
		
		public float X
		{
			get { return rect.X; }
			set { rect.X = value; }
		}
		
		public float Y
		{
			get { return rect.Y; }
			set { rect.Y = value; }
		}
		
		public float Width
		{
			get { return rect.Width; }
			set { rect.Width = value; }
		}
		
		public float Height
		{
			get { return rect.Height; }
			set { rect.Height = value; }
		}

        public RectangleF RectF { get { return this.rect; } }
		
		public Character(char character, RectangleF rect)
		{
			this._char = character;
			this.rect = rect;
		}
		
		public Character(char character, float x, float y, float width, float height)
			: this(character, new RectangleF(x, y, width, height))
		{
			
		}

        /// <summary>
        /// 检查传入的字符是否是英文字符
        /// </summary>
        /// <param name="c">要检查的字符</param>
        /// <returns>结果</returns>
        public static bool isEnglishChar(char c)
        {
            return Array.IndexOf(ENGLISH_CHARS, c) >= 0;
        }

        /// <summary>
        /// 检查传入的字符是否是英文字符
        /// </summary>
        /// <param name="c">要检查的字符</param>
        /// <returns>结果</returns>
        public static bool isEnglishChar(Character c)
        {
            return Array.IndexOf(ENGLISH_CHARS, c.Char) >= 0;
        }
			
	}
}
