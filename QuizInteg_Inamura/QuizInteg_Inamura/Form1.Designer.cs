namespace QuizInteg_Inamura
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
            panel1 = new Panel();
            label1 = new Label();
            lblnamebtn = new Button();
            displaybtn = new Button();
            Name_Collection = new ListBox();
            twodtxt = new Label();
            msgtxt = new TextBox();
            msgbtn = new Button();
            resulttxt = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(560, 41);
            label1.TabIndex = 0;
            label1.Text = "String Information Descriptive Display";
            // 
            // lblnamebtn
            // 
            lblnamebtn.BackColor = Color.Aquamarine;
            lblnamebtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblnamebtn.ForeColor = SystemColors.ControlText;
            lblnamebtn.Location = new Point(12, 84);
            lblnamebtn.Name = "lblnamebtn";
            lblnamebtn.Size = new Size(168, 84);
            lblnamebtn.TabIndex = 1;
            lblnamebtn.Text = "Display The Names";
            lblnamebtn.UseVisualStyleBackColor = false;
            lblnamebtn.Click += lblnamebtn_Click;
            // 
            // displaybtn
            // 
            displaybtn.BackColor = Color.Aquamarine;
            displaybtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            displaybtn.Location = new Point(295, 84);
            displaybtn.Name = "displaybtn";
            displaybtn.Size = new Size(168, 84);
            displaybtn.TabIndex = 2;
            displaybtn.Text = "Display 2D Array";
            displaybtn.UseVisualStyleBackColor = false;
            displaybtn.Click += displaybtn_Click;
            // 
            // Name_Collection
            // 
            Name_Collection.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Name_Collection.FormattingEnabled = true;
            Name_Collection.ItemHeight = 28;
            Name_Collection.Location = new Point(12, 183);
            Name_Collection.Name = "Name_Collection";
            Name_Collection.Size = new Size(270, 144);
            Name_Collection.TabIndex = 3;
            // 
            // twodtxt
            // 
            twodtxt.AutoSize = true;
            twodtxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            twodtxt.Location = new Point(295, 183);
            twodtxt.Name = "twodtxt";
            twodtxt.Size = new Size(266, 28);
            twodtxt.TabIndex = 4;
            twodtxt.Text = "2 Dimensional Array Display";
            // 
            // msgtxt
            // 
            msgtxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            msgtxt.Location = new Point(10, 352);
            msgtxt.Name = "msgtxt";
            msgtxt.Size = new Size(551, 34);
            msgtxt.TabIndex = 5;
            // 
            // msgbtn
            // 
            msgbtn.BackColor = Color.Aquamarine;
            msgbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            msgbtn.Location = new Point(12, 409);
            msgbtn.Name = "msgbtn";
            msgbtn.Size = new Size(168, 81);
            msgbtn.TabIndex = 6;
            msgbtn.Text = "Show Message";
            msgbtn.UseVisualStyleBackColor = false;
            msgbtn.Click += msgbtn_Click;
            // 
            // resulttxt
            // 
            resulttxt.AutoSize = true;
            resulttxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            resulttxt.Location = new Point(201, 409);
            resulttxt.Name = "resulttxt";
            resulttxt.Size = new Size(138, 28);
            resulttxt.TabIndex = 7;
            resulttxt.Text = "Display Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(624, 511);
            Controls.Add(resulttxt);
            Controls.Add(msgbtn);
            Controls.Add(msgtxt);
            Controls.Add(twodtxt);
            Controls.Add(Name_Collection);
            Controls.Add(displaybtn);
            Controls.Add(lblnamebtn);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button lblnamebtn;
        private Button displaybtn;
        private ListBox Name_Collection;
        private Label twodtxt;
        private TextBox msgtxt;
        private Button msgbtn;
        private Label resulttxt;
    }
}
