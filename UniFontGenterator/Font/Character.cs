//#define SHOW_DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using DrawingFont = System.Drawing.Font;


namespace UniFontGenterator.Font
{
    /// <summary>
    /// 单个字符
    /// </summary>
    public class Character : IDisposable
    {
        private Bitmap image;
        private Brush brush = Brushes.Black;
        private Graphics g;
        private DrawingFont font;

        public int Width { get; private set; }
        public int Height { get; private set; }

        private string character;

        public Character(string character, DrawingFont font)
        {
            //字符串长度检测
            if (character.Length != 1)
                throw new ArgumentException("字符长度不正确", "character");

            this.character = character;
            this.font = font;

            //临时获取 Bitmap 以便于测量字符串
            image = new Bitmap(1, 1); 
            g = Graphics.FromImage(image);

            //获取这个字符的长度、宽度
            SizeF size = g.MeasureString(character, font, 100);
            this.Width = (int)Math.Round(size.Width, 0);
            this.Height = (int)Math.Round(size.Height, 0);

            //重新创建
            image = new Bitmap(Width, Height);
            g = Graphics.FromImage(image);

            //抗锯齿
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit; //经测试 AntiAliasGridFit 比 AntiAlias 效果要好
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
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
        /// 绘制出该字符
        /// </summary>
        public void Paint()
        {
            
            g.DrawString(character, font, brush, 0, 0);

            //裁剪多余空白
            CropToSize(FindActualSize());

#if SHOW_DEBUG
            g.DrawRectangle(Pens.Red, 0, 0, Width - 1, Height - 1);
#endif
        }

        /// <summary>
        /// 将 BitMap 裁剪到指定大小
        /// </summary>
        /// <param name="rect">原图像的要裁剪的部分</param>
        private void CropToSize(Rectangle rect)
        {
            Bitmap oldImage = image;
            Graphics oldGraphics = g;

            //新图像
            image = new Bitmap(rect.Width, rect.Height);
            g = Graphics.FromImage(image);

            //TODO: 裁剪字符可选只裁剪左右空白

            //将旧图像裁剪到新图像上
            g.DrawImage(oldImage, 0, 0, rect, GraphicsUnit.Pixel);

            //更改宽高
            Width = rect.Width;
            Height = rect.Height;

            //释放资源
            oldImage.Dispose();
            oldGraphics.Dispose();
        }

        /// <summary>
        /// 获得该字符的实际位置（不包括空白）
        /// </summary>
        /// <returns>该字符的实际位置</returns>
        private Rectangle FindActualSize()
        {
            int x, y;

            int left = -1;
            int right = -1;
            int top = -1;
            int bottom = -1;

            int alphaSum = 0;


            //TODO: 优化裁剪字符的算法

            //找出字符的左边界和右边界
            x = 0;
            y = 0;
            alphaSum = 0;
            while(x >= 0 && x < image.Width)
            {
                //alphaSum 清零
                alphaSum = 0;

                //算出该列所有像素点 Alpha 值的和
                for (y = 0; y < image.Height; y++)
                    alphaSum += image.GetPixel(x, y).A;

                //扫描左边界模式，扫描方向：左->右
                if(left < 0 && right < 0)
                {
                    if (alphaSum != 0) //该列有不透明像素
                    {
                        left = (x == 0 ? 0 : x - 1);
                        x = image.Width - 1; //将 x 重置到最右边，进入扫描右边界模式
                        continue;
                    }
                    x++;
                }

                //扫描右边界模式，扫描方向：左<-右
                if(left >= 0 && right < 0)
                {
                    if (alphaSum != 0) //该列有不透明像素
                        right = x + 1;
                    x--;
                }

                //左右边界都检测到了，跳出循环
                if (left >= 0 && right >= 0)
                    break;
            }


            //找出字符的上边界和下边界
            x = 0;
            y = 0;
            alphaSum = 0;
            while(y >= 0 && y < image.Height)
            {
                //alphaSum 清零
                alphaSum = 0;

                //算出该行所有像素点 Alpha 值的和
                for (x = 0; x < image.Width; x++)
                    alphaSum += image.GetPixel(x, y).A;

                //扫描上边界模式，扫描方向：上->下
                if(top < 0 && bottom < 0)
                {
                    if (alphaSum != 0) //该列有不透明像素
                    {
                        top = (y == 0 ? 0 : y - 1);
                        y = image.Height - 1; //将 y 重置到最下边，进入扫描下边界模式
                        continue;
                    }

                    y++;
                }

                //扫描下边界模式，扫描方向：上<-下
                if(top >= 0 && bottom < 0)
                {
                    if (alphaSum != 0) //该列有不透明像素
                        bottom = y + 1;
                    y--;
                }

                //上下边界都检测到了，跳出循环
                if (top >= 0 && bottom >= 0)
                    break;
            }


            //检查边界
            if (left < 0 || right < 0 || top < 0 || bottom < 0)
                throw new Exception("字符边界检测失败");


            //Debug 用，画出边框
#if SHOW_DEBUG
            g.DrawLine(Pens.Blue, left, 0, left, image.Height);
            g.DrawLine(Pens.Red, right, 0, right, image.Height);

            g.DrawLine(Pens.Green, 0, top, image.Width, top);
            g.DrawLine(Pens.Pink, 0, bottom, image.Width, bottom);
#endif

            return new Rectangle(left, top, right - left, bottom - top);
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
