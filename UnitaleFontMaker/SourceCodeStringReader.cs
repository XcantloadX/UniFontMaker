using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitaleFontMaker
{
    /// <summary>
    /// 读取 Lua 源文件中所有的字符串
    /// </summary>
    public class SourceCodeStringReader
    {
        //代码片段
        private string code;

        public SourceCodeStringReader(string code)
        {
            this.code = code;
        }

        public string[] Get()
        {
            List<string> str = new List<string>();



            return str.ToArray();
        }
    }
}
