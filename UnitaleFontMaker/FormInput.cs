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
    public partial class FormInput : Form
    {
        public bool done;
        public string text;

        public FormInput(string title, string description)
        {
            InitializeComponent();

            Text = title;
            label1.Text = description;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            done = true;
            text = textBox1.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            done = true;
            text = null;
        }

        
    }

    public class InputDialog
    {
        public static string Show(string title, string description)
        {
            FormInput form = new FormInput(title, description);
            while (!form.done) { };
            return form.text;
        }
    }
}
