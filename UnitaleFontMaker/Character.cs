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
			
	}
}
