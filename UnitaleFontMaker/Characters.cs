using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitaleFontMaker
{
    /// <summary>
    /// 多个字符
    /// </summary>
    public class Characters
    {
        /// <summary>
        /// 必须添加的字符
        /// </summary>
        public const string MUST_CHARS = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~ "; //注意最后面还有一个空格
        //已储存的字符
        private Dictionary<char, Character> chars = new Dictionary<char, Character>(200);

        public Characters()
        {
            this.AddChars(Characters.MUST_CHARS);
        }

        /// <summary>
        /// 添加单个字符
        /// </summary>
        /// <param name="c">待添加的字符</param>
        public void AddChar(Character c)
        {
            Character tmp = null;
            chars.TryGetValue(c.Char, out tmp);
            if(tmp == null)
                chars.Add(c.Char, c);
        }

        public void AddChar(char c)
        {

        }

        /// <summary>
        /// 添加多个字符
        /// </summary>
        /// <param name="c">待添加的字符</param>
        public void AddChars(Character[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                this.AddChar(c[i]);
            }
        }
        /// <summary>
        /// 添加字符串中的所有字符
        /// </summary>
        /// <param name="s">待添加的字符串</param>
        public void AddChars(string s)
        {
            //this.AddChars(s.ToCharArray());
        }

        /// <summary>
        /// 重新计算所有字符的大小和坐标
        /// </summary>
        public void Refresh()
        {

        }

    }
}
