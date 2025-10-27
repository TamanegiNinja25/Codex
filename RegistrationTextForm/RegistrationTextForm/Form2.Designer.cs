namespace RegistrationTextForm
{
    partial class frmFileName
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
            okaybtn = new Button();
            label1 = new Label();
            filenametxt = new TextBox();
            SuspendLayout();
            // 
            // okaybtn
            // 
            okaybtn.BackColor = Color.SpringGreen;
            okaybtn.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            okaybtn.Location = new Point(122, 152);
            okaybtn.Name = "okaybtn";
            okaybtn.Size = new Size(240, 77);
            okaybtn.TabIndex = 0;
            okaybtn.Text = "OKAY";
            okaybtn.UseVisualStyleBackColor = false;
            okaybtn.Click += okaybtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(272, 46);
            label1.TabIndex = 1;
            label1.Text = "Enter File Name:";
            // 
            // filenametxt
            // 
            filenametxt.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            filenametxt.Location = new Point(23, 71);
            filenametxt.Name = "filenametxt";
            filenametxt.Size = new Size(445, 51);
            filenametxt.TabIndex = 2;
            // 
            // frmFileName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(487, 263);
            Controls.Add(filenametxt);
            Controls.Add(label1);
            Controls.Add(okaybtn);
            Name = "frmFileName";
            Text = "frmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okaybtn;
        private Label label1;
        private TextBox filenametxt;
    }
}