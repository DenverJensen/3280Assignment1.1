namespace Assignment1._1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl_txt1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl_txt2 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl_txt3 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.lbl_results = new System.Windows.Forms.Label();
            this.lbl_btn1 = new System.Windows.Forms.Label();
            this.lbl_btn2 = new System.Windows.Forms.Label();
            this.lbl_btn3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(63, 87);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(169, 20);
            this.txt1.TabIndex = 0;
            // 
            // lbl_txt1
            // 
            this.lbl_txt1.AutoSize = true;
            this.lbl_txt1.Location = new System.Drawing.Point(63, 68);
            this.lbl_txt1.Name = "lbl_txt1";
            this.lbl_txt1.Size = new System.Drawing.Size(58, 13);
            this.lbl_txt1.TabIndex = 1;
            this.lbl_txt1.Text = "Text Box 1";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(338, 83);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(140, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Question Message Box";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(63, 194);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(169, 20);
            this.txt2.TabIndex = 3;
            // 
            // lbl_txt2
            // 
            this.lbl_txt2.AutoSize = true;
            this.lbl_txt2.Location = new System.Drawing.Point(66, 175);
            this.lbl_txt2.Name = "lbl_txt2";
            this.lbl_txt2.Size = new System.Drawing.Size(58, 13);
            this.lbl_txt2.TabIndex = 4;
            this.lbl_txt2.Text = "Text Box 2";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(338, 190);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(140, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Error Message Box";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(63, 321);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(169, 20);
            this.txt3.TabIndex = 6;
            // 
            // lbl_txt3
            // 
            this.lbl_txt3.AutoSize = true;
            this.lbl_txt3.Location = new System.Drawing.Point(63, 302);
            this.lbl_txt3.Name = "lbl_txt3";
            this.lbl_txt3.Size = new System.Drawing.Size(58, 13);
            this.lbl_txt3.TabIndex = 7;
            this.lbl_txt3.Text = "Text Box 3";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(338, 317);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(140, 23);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "Warning Message Box";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lbl_results
            // 
            this.lbl_results.AutoSize = true;
            this.lbl_results.Location = new System.Drawing.Point(66, 400);
            this.lbl_results.Name = "lbl_results";
            this.lbl_results.Size = new System.Drawing.Size(144, 13);
            this.lbl_results.TabIndex = 10;
            this.lbl_results.Text = "Message Box Button results: ";
            // 
            // lbl_btn1
            // 
            this.lbl_btn1.AutoSize = true;
            this.lbl_btn1.Location = new System.Drawing.Point(335, 109);
            this.lbl_btn1.Name = "lbl_btn1";
            this.lbl_btn1.Size = new System.Drawing.Size(355, 13);
            this.lbl_btn1.TabIndex = 11;
            this.lbl_btn1.Text = "This button will add the contents of Text Box 1 to a question message box";
            // 
            // lbl_btn2
            // 
            this.lbl_btn2.AutoSize = true;
            this.lbl_btn2.Location = new System.Drawing.Point(338, 220);
            this.lbl_btn2.Name = "lbl_btn2";
            this.lbl_btn2.Size = new System.Drawing.Size(342, 13);
            this.lbl_btn2.TabIndex = 12;
            this.lbl_btn2.Text = "This button will add the contents of Text Box 2 to an error message box";
            // 
            // lbl_btn3
            // 
            this.lbl_btn3.AutoSize = true;
            this.lbl_btn3.Location = new System.Drawing.Point(341, 347);
            this.lbl_btn3.Name = "lbl_btn3";
            this.lbl_btn3.Size = new System.Drawing.Size(352, 13);
            this.lbl_btn3.TabIndex = 13;
            this.lbl_btn3.Text = "This button will add the contents of Text Box 3 to a warning message box";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_btn3);
            this.Controls.Add(this.lbl_btn2);
            this.Controls.Add(this.lbl_btn1);
            this.Controls.Add(this.lbl_results);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.lbl_txt3);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lbl_txt2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl_txt1);
            this.Controls.Add(this.txt1);
            this.Name = "frmMain";
            this.Text = "Assignment 1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl_txt1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl_txt2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl_txt3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lbl_results;
        private System.Windows.Forms.Label lbl_btn1;
        private System.Windows.Forms.Label lbl_btn2;
        private System.Windows.Forms.Label lbl_btn3;
    }
}

