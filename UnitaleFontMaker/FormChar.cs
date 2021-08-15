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
    public partial class FormChar : Form
    {
        private char[] chars;
        public FormChar(char[] chars)
        {
            InitializeComponent();
            this.chars = chars;
        }

        private void CharForm_Load(object sender, EventArgs e)
        {
            foreach (char c in chars)
            {
                listBox1.Items.Add(c);
            }
            
        }
    }
}
