using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UniFontGenterator.Project;
using UniFontGenterator.Font;
using DrawingFont = System.Drawing.Font;

namespace UniFontGenterator
{
    public partial class MainForm : Form
    {
        private FontProject proj = null;
        private bool projEdited = false; //是否修改了项目，用来提示保存

        public MainForm()
        {
            InitializeComponent();

            //隐藏 TabControl 的选项卡头
            tabControlFontSettings.ItemSize = new Size(0, 1);
            tabControlFontSettings.Appearance = TabAppearance.FlatButtons;
            tabControlFontSettings.SizeMode = TabSizeMode.Fixed;


            CharacterPage page = new CharacterPage(new DrawingFont("Zpix", 15), 5);
            page.AddFromString("测试文本abcdefghijklmnopqrstuvwxyz"); //


            /*Character c = new Character("测", new DrawingFont("Zpix", 10f));
            c.Paint();
            pictureBoxTest.Image = c.GetImage();*/

            pictureBoxTest.Image = page.GetImage();
        }


        //菜单栏->退出
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            if(SavedCheck())
                this.Close();
        }

        private void MenuItemNewMC_Click(object sender, EventArgs e)
        {
            this.proj = new MinecraftFontProject();
        }

        private bool SavedCheck()
        {
            DialogResult result = MessageBox.Show("是否保存项目？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            return result == DialogResult.No;
        }


    }
}
