using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1._1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string caption = "Hello, I am a message";
            string message = "";
            if (txt1.Text.Length == 0)
            {
                message = "you did not enter anything in Text Box 1";
            }
            else
            {
                message = txt1.Text;
            }
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icons = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, caption, buttons, icons);
            lbl_results.Text += result;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string caption = "Hello, I am a message";
            string message = "";
            if (txt2.Text.Length == 0)
            {
                message = "you did not enter anything in Text Box 2";
            }
            else
            {
                message = txt2.Text;
            }
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icons = MessageBoxIcon.Error;
            DialogResult result = MessageBox.Show(message, caption, buttons, icons);
            lbl_results.Text += result;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string caption = "Hello, I am a message";
            string message = "";
            if (txt3.Text.Length == 0)
            {
                message = "you did not enter anything in Text Box 3";
            }
            else
            {
                message = txt3.Text;
            }
            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            MessageBoxIcon icons = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, caption, buttons, icons);
            lbl_results.Text += result;
        }

    }
}
