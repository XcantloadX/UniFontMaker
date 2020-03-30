using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DrawingFont = System.Drawing.Font;

namespace UniFontGenterator.Font
{
    /// <summary>
    /// 一大片字符
    /// </summary>
    public class CharacterPage : IDisposable
    {
        private Dictionary<string, Character> chars = new Dictionary<string, Character>();

        private Bitmap image;
        private Graphics g;
        private DrawingFont font;

        public int CharSpacing { get; set; }
        public int LineSpacing { get; set; }
        public int MaxCharNumPerLine { get; set; }


        public CharacterPage(DrawingFont font, int maxCharPerLine)
        {
            this.font = font;
            this.CharSpacing = 5;
            this.LineSpacing = 5;
            this.MaxCharNumPerLine = maxCharPerLine;
        }

        /// <summary>
        /// 添加字符
        /// </summary>
        /// <param name="character">字符</param>
        public void Add(string character)
        {
            //字符串长度检测
            if (character.Length != 1)
                throw new ArgumentException("字符长度不正确", "character");

            chars.Add(character, new Character(character, font));
        }

        /// <summary>
        /// 从字符串添加字符
        /// </summary>
        /// <param name="str">包含要添加的字符的字符串</param>
        public void AddFromString(string str)
        {
            for (int i = 0; i < str.Length; i++)
                Add(str[i].ToString());
        }

        /// <summary>
        /// 将所有字符绘制到一张图片上
        /// </summary>
        public void Paint()
        {
            image = new Bitmap(700, 200);
            g = Graphics.FromImage(image);

            int x = 0;
            int y = 0;
            int charNum = 0;
            int maxCharHeight = -1;

            Dictionary<string, Character>.ValueCollection c = this.chars.Values;
            Character[] chars = new Character[c.Count];
            c.CopyTo(chars, 0);

            for (int i = 0; i < chars.Length; i++)
            {
                g.DrawImage(chars[i].GetImage(), x, y);

                maxCharHeight = (chars[i].Height > maxCharHeight ? chars[i].Height : maxCharHeight);
                x += chars[i].Width + CharSpacing;
                charNum++;

                if (charNum > MaxCharNumPerLine)
                {
                    y += maxCharHeight + LineSpacing;
                    charNum = 0;
                    x = 0;
                }

            }
        }

        /// <summary>
        /// 获取 Image 对象
        /// </summary>
        /// <param name="repaint">是否重绘</param>
        /// <returns>Image 对象</returns>
        public Image GetImage(bool repaint = true)
        {
            if (repaint)
                Paint();

            return image;
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            image.Dispose();
            g.Dispose();
            font.Dispose();
        }
    }
}
