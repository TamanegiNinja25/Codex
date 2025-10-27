namespace TPInteg_Inamura
{
    partial class Form1
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
            mrbtn = new RadioButton();
            frbtn = new RadioButton();
            label6 = new Label();
            daycbx = new ComboBox();
            monthcbx = new ComboBox();
            yearcbx = new ComboBox();
            label7 = new Label();
            cbxProgram = new ComboBox();
            registerbtn = new Button();
            lntxt = new TextBox();
            fntxt = new TextBox();
            mitxt = new TextBox();
            browsebtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(391, 41);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(53, 76);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(53, 124);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(53, 174);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 3;
            label4.Text = "Middle Initial:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(53, 218);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 4;
            label5.Text = "Gender:";
            // 
            // mrbtn
            // 
            mrbtn.AutoSize = true;
            mrbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            mrbtn.Location = new Point(172, 218);
            mrbtn.Name = "mrbtn";
            mrbtn.Size = new Size(77, 32);
            mrbtn.TabIndex = 5;
            mrbtn.TabStop = true;
            mrbtn.Text = "Male";
            mrbtn.UseVisualStyleBackColor = true;
            // 
            // frbtn
            // 
            frbtn.AutoSize = true;
            frbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            frbtn.Location = new Point(266, 218);
            frbtn.Name = "frbtn";
            frbtn.Size = new Size(98, 32);
            frbtn.TabIndex = 6;
            frbtn.TabStop = true;
            frbtn.Text = "Female";
            frbtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(53, 262);
            label6.Name = "label6";
            label6.Size = new Size(134, 28);
            label6.TabIndex = 7;
            label6.Text = "Date of Birth:";
            // 
            // daycbx
            // 
            daycbx.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            daycbx.FormattingEnabled = true;
            daycbx.Location = new Point(53, 305);
            daycbx.Name = "daycbx";
            daycbx.Size = new Size(99, 36);
            daycbx.TabIndex = 8;
            daycbx.Text = "- Day -";
            // 
            // monthcbx
            // 
            monthcbx.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            monthcbx.FormattingEnabled = true;
            monthcbx.Location = new Point(172, 305);
            monthcbx.Name = "monthcbx";
            monthcbx.Size = new Size(119, 36);
            monthcbx.TabIndex = 9;
            monthcbx.Text = "- Month -";
            // 
            // yearcbx
            // 
            yearcbx.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            yearcbx.FormattingEnabled = true;
            yearcbx.Location = new Point(308, 305);
            yearcbx.Name = "yearcbx";
            yearcbx.Size = new Size(109, 36);
            yearcbx.TabIndex = 10;
            yearcbx.Text = "-  Year -";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(134, 356);
            label7.Name = "label7";
            label7.Size = new Size(178, 28);
            label7.TabIndex = 11;
            label7.Text = "Program to Apply:";
            // 
            // cbxProgram
            // 
            cbxProgram.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbxProgram.FormattingEnabled = true;
            cbxProgram.Location = new Point(12, 397);
            cbxProgram.Name = "cbxProgram";
            cbxProgram.Size = new Size(428, 36);
            cbxProgram.TabIndex = 12;
            cbxProgram.Text = "- Select Program -";
            // 
            // registerbtn
            // 
            registerbtn.BackColor = Color.Crimson;
            registerbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            registerbtn.ForeColor = Color.White;
            registerbtn.Location = new Point(124, 449);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(202, 61);
            registerbtn.TabIndex = 13;
            registerbtn.Text = "Register Student";
            registerbtn.UseVisualStyleBackColor = false;
            registerbtn.Click += registerbtn_Click;
            // 
            // lntxt
            // 
            lntxt.Location = new Point(200, 77);
            lntxt.Name = "lntxt";
            lntxt.Size = new Size(217, 27);
            lntxt.TabIndex = 14;
            // 
            // fntxt
            // 
            fntxt.Location = new Point(200, 124);
            fntxt.Name = "fntxt";
            fntxt.Size = new Size(217, 27);
            fntxt.TabIndex = 15;
            // 
            // mitxt
            // 
            mitxt.Location = new Point(200, 174);
            mitxt.Name = "mitxt";
            mitxt.Size = new Size(217, 27);
            mitxt.TabIndex = 16;
            // 
            // browsebtn
            // 
            browsebtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            browsebtn.Location = new Point(583, 439);
            browsebtn.Name = "browsebtn";
            browsebtn.Size = new Size(212, 74);
            browsebtn.TabIndex = 18;
            browsebtn.Text = "Browse and Upload Photo";
            browsebtn.UseVisualStyleBackColor = true;
            browsebtn.Click += browsebtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(466, 20);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(465, 413);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 19;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(943, 522);
            Controls.Add(pictureBox);
            Controls.Add(browsebtn);
            Controls.Add(mitxt);
            Controls.Add(fntxt);
            Controls.Add(lntxt);
            Controls.Add(registerbtn);
            Controls.Add(cbxProgram);
            Controls.Add(label7);
            Controls.Add(yearcbx);
            Controls.Add(monthcbx);
            Controls.Add(daycbx);
            Controls.Add(label6);
            Controls.Add(frbtn);
            Controls.Add(mrbtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton mrbtn;
        private RadioButton frbtn;
        private Label label6;
        private ComboBox daycbx;
        private ComboBox monthcbx;
        private ComboBox yearcbx;
        private Label label7;
        private ComboBox cbxProgram;
        private Button registerbtn;
        private TextBox lntxt;
        private TextBox fntxt;
        private TextBox mitxt;
        private Button browsebtn;
        private OpenFileDialog openFileDialog1;
    }
}
