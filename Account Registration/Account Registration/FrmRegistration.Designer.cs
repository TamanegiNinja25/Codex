namespace Account_Registration
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            studnotxt = new TextBox();
            lnametxt = new TextBox();
            fnametxt = new TextBox();
            contactnotxt = new TextBox();
            mnametxt = new TextBox();
            agetxt = new TextBox();
            progbox = new ComboBox();
            textBox1 = new TextBox();
            nextbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(107, 24);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label2.Location = new Point(294, 19);
            label2.Name = "label2";
            label2.Size = new Size(81, 24);
            label2.TabIndex = 1;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label3.Location = new Point(25, 94);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label4.Location = new Point(294, 94);
            label4.Name = "label4";
            label4.Size = new Size(98, 24);
            label4.TabIndex = 3;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label5.Location = new Point(546, 94);
            label5.Name = "label5";
            label5.Size = new Size(115, 24);
            label5.TabIndex = 4;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label6.Location = new Point(25, 187);
            label6.Name = "label6";
            label6.Size = new Size(45, 24);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label7.Location = new Point(294, 187);
            label7.Name = "label7";
            label7.Size = new Size(107, 24);
            label7.TabIndex = 6;
            label7.Text = "Contact No.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label8.Location = new Point(25, 274);
            label8.Name = "label8";
            label8.Size = new Size(79, 24);
            label8.TabIndex = 7;
            label8.Text = "Address:";
            // 
            // studnotxt
            // 
            studnotxt.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            studnotxt.Location = new Point(25, 46);
            studnotxt.Name = "studnotxt";
            studnotxt.Size = new Size(237, 30);
            studnotxt.TabIndex = 8;
            studnotxt.TextChanged += this.studnotxt_TextChanged;
            // 
            // lnametxt
            // 
            lnametxt.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            lnametxt.Location = new Point(25, 137);
            lnametxt.Name = "lnametxt";
            lnametxt.Size = new Size(237, 30);
            lnametxt.TabIndex = 9;
            // 
            // fnametxt
            // 
            fnametxt.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            fnametxt.Location = new Point(294, 137);
            fnametxt.Name = "fnametxt";
            fnametxt.Size = new Size(237, 30);
            fnametxt.TabIndex = 10;
            // 
            // contactnotxt
            // 
            contactnotxt.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            contactnotxt.Location = new Point(294, 230);
            contactnotxt.Name = "contactnotxt";
            contactnotxt.Size = new Size(237, 30);
            contactnotxt.TabIndex = 11;
            // 
            // mnametxt
            // 
            mnametxt.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            mnametxt.Location = new Point(546, 137);
            mnametxt.Name = "mnametxt";
            mnametxt.Size = new Size(237, 30);
            mnametxt.TabIndex = 12;
            // 
            // agetxt
            // 
            agetxt.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            agetxt.Location = new Point(25, 230);
            agetxt.Name = "agetxt";
            agetxt.Size = new Size(237, 30);
            agetxt.TabIndex = 13;
            // 
            // progbox
            // 
            progbox.FormattingEnabled = true;
            progbox.Location = new Point(294, 49);
            progbox.Name = "progbox";
            progbox.Size = new Size(367, 28);
            progbox.TabIndex = 14;
            progbox.SelectedIndexChanged += this.progbox_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 310);
            textBox1.MaximumSize = new Size(758, 100);
            textBox1.MinimumSize = new Size(50, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(758, 100);
            textBox1.TabIndex = 15;
            // 
            // nextbtn
            // 
            nextbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextbtn.Location = new Point(294, 429);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(164, 29);
            nextbtn.TabIndex = 16;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += this.nextbtn_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(nextbtn);
            Controls.Add(textBox1);
            Controls.Add(progbox);
            Controls.Add(agetxt);
            Controls.Add(mnametxt);
            Controls.Add(contactnotxt);
            Controls.Add(fnametxt);
            Controls.Add(lnametxt);
            Controls.Add(studnotxt);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox studnotxt;
        private TextBox lnametxt;
        private TextBox fnametxt;
        private TextBox contactnotxt;
        private TextBox mnametxt;
        private TextBox agetxt;
        private ComboBox progbox;
        private TextBox textBox1;
        private Button nextbtn;
    }
}
