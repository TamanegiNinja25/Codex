
namespace CashierApplication
{
    partial class frmLoginAccount
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
            label1 = new Label();
            label2 = new Label();
            usertxt = new TextBox();
            passtxt = new TextBox();
            loginbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(152, 38);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label2.Location = new Point(26, 130);
            label2.Name = "label2";
            label2.Size = new Size(143, 38);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // usertxt
            // 
            usertxt.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            usertxt.Location = new Point(26, 65);
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(285, 43);
            usertxt.TabIndex = 2;
            // 
            // passtxt
            // 
            passtxt.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            passtxt.Location = new Point(26, 171);
            passtxt.Name = "passtxt";
            passtxt.Size = new Size(285, 43);
            passtxt.TabIndex = 3;
            passtxt.UseSystemPasswordChar = true;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.DodgerBlue;
            loginbtn.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            loginbtn.ForeColor = SystemColors.ButtonFace;
            loginbtn.Location = new Point(26, 237);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(285, 59);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 328);
            Controls.Add(loginbtn);
            Controls.Add(passtxt);
            Controls.Add(usertxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLoginAccount";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        private void logintxt_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usertxt;
        private TextBox passtxt;
        private Button loginbtn;
    }
}