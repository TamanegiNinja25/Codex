namespace RegistrationTextForm
{
    partial class frmLab1
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
            inputtxt = new TextBox();
            createbtn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // inputtxt
            // 
            inputtxt.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            inputtxt.Location = new Point(32, 22);
            inputtxt.MaximumSize = new Size(342, 100);
            inputtxt.MinimumSize = new Size(342, 100);
            inputtxt.Multiline = true;
            inputtxt.Name = "inputtxt";
            inputtxt.Size = new Size(342, 100);
            inputtxt.TabIndex = 0;
            // 
            // createbtn
            // 
            createbtn.BackColor = Color.LimeGreen;
            createbtn.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            createbtn.Location = new Point(44, 173);
            createbtn.Name = "createbtn";
            createbtn.Size = new Size(320, 62);
            createbtn.TabIndex = 1;
            createbtn.Text = "CREATE";
            createbtn.UseVisualStyleBackColor = false;
            createbtn.Click += createbtn_Click;
            // 
            // frmLab1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(411, 272);
            Controls.Add(createbtn);
            Controls.Add(inputtxt);
            Name = "frmLab1";
            Text = "FrmLab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputtxt;
        private Button createbtn;
        private SaveFileDialog saveFileDialog1;
    }
}
