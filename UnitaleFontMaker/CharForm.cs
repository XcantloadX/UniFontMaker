using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnitaleFontMaker
{
    public partial class CharForm : Form
    {
        public CharForm(char[] chars)
        {
            InitializeComponent();
            StringBuilder sb = new StringBuilder(chars.Length * 2);
            for(int i = 0; i < chars.Length; i++)
                sb.AppendLine(chars[i].ToString());
            textBox1.Text = sb.ToString();
        }

        private void CharForm_Load(object sender, EventArgs e)
        {

        }
    }
}
