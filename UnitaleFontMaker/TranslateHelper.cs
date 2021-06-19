using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnitaleFontMaker
{
    public class TranslateHelper
    {
        public delegate void GetProgress(float progress);
        public static char[] GetAllCharactersFile(string filePath)
        {
            string contents = File.ReadAllText(filePath);
            HashSet<char> chars = new HashSet<char>();
            for (int i = 0; i < contents.Length; i++)
            {
                chars.Add(contents[i]);
            }

            return chars.ToArray();
        }

        /// <summary>
        /// 搜索文件夹下的所有 *.lua 并找出所有字符
        /// </summary>
        /// <param name="dirPath">目录</param>
        /// <param name="callback">回调。用于显示进度</param>
        /// <returns></returns>
        public static char[] GetAllCharactersDir(string dirPath)
        {
            HashSet<char> chars = new HashSet<char>();
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            DirectoryInfo[] ds = dir.GetDirectories();
            foreach (DirectoryInfo d in ds) //一层足矣
            {
                chars.UnionWith(GetCharsFromDir(d));
            }

            FileInfo[] files = dir.GetFiles("*.lua");
            foreach (FileInfo f in files)
            {
                Console.WriteLine(f.FullName);
                FileStream fs = f.OpenRead();
                byte[] buff = new byte[fs.Length];
                fs.Read(buff, 0, (int)fs.Length); //TODO 潜在的溢出问题
                fs.Close();
                string contents = System.Text.Encoding.UTF8.GetString(buff);

                for (int i = 0; i < contents.Length; i++)
                {
                    chars.Add(contents[i]);
                    Console.WriteLine(contents[i] == '\n');
                }
            }

            //这两个会造成显示错误
            chars.Remove('\n');
            chars.Remove('\r');
            return chars.ToArray();
        }

        private static HashSet<char> GetCharsFromDir(DirectoryInfo dir)
        {
            FileInfo[] files = dir.GetFiles("*.lua");
            HashSet<char> chars = new HashSet<char>();

            foreach (FileInfo f in files)
            {
                FileStream fs = f.OpenRead();
                byte[] buff = new byte[fs.Length];
                fs.Read(buff, 0, (int)fs.Length); //TODO 潜在的溢出问题
                fs.Close();
                string contents = System.Text.Encoding.UTF8.GetString(buff);


                for (int i = 0; i < contents.Length; i++)
                {
                    chars.Add(contents[i]);
                }
            }
            return chars;
        }
    }
}
