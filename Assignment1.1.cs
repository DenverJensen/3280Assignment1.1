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
    /// <summary>
    ///  Main form to display 
    /// </summary>
    public partial class frmMain : Form
    {
        /// <summary>
        /// initialize main form constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button event handler for button1. Button will validate if anything is typed in txt1
        /// If there is text in textbox txt1, it will display the text as a question MessageBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            string caption = "Hello, I am a message";
            string message = "";

            ///validate
            if (txt1.Text.Length == 0)
            {
                message = "you did not enter anything in Text Box 1";
            }
            else
            {
                message = txt1.Text;
            }

            ///display messagebox
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icons = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, caption, buttons, icons);
            lbl_results.Text += result;
        }

        /// <summary>
        /// Button event handler for button2. Button will validate if anything is typed in txt2
        /// If there is text in textbox txt2, it will display the text as an error MessageBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            string caption = "Hello, I am a message";
            string message = "";

            ///validate
            if (txt2.Text.Length == 0)
            {
                message = "you did not enter anything in Text Box 2";
            }
            else
            {
                message = txt2.Text;
            }

            ///display messagebox
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icons = MessageBoxIcon.Error;
            DialogResult result = MessageBox.Show(message, caption, buttons, icons);
            lbl_results.Text += result;
        }

        /// <summary>
        /// Button event handler for button3. Button will validate if anything is typed in txt3
        /// If there is text in textbox txt3, it will display the text as a warning MessageBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            string caption = "Hello, I am a message";
            string message = "";

            /// validate
            if (txt3.Text.Length == 0)
            {
                message = "you did not enter anything in Text Box 3";
            }
            else
            {
                message = txt3.Text;
            }

            //display message
            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            MessageBoxIcon icons = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, caption, buttons, icons);
            lbl_results.Text += result;
        }

    }
}
