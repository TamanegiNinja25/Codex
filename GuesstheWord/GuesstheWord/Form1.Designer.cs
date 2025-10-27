namespace GuesstheWord
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
            panel2 = new Panel();
            WrongGuessList = new ListBox();
            label2 = new Label();
            panel3 = new Panel();
            guessbtn = new Button();
            guesstxt = new TextBox();
            panel4 = new Panel();
            wordtxt = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 76);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 6);
            label1.Name = "label1";
            label1.Size = new Size(626, 60);
            label1.TabIndex = 0;
            label1.Text = "CAN YOU GUESS THE NAME?";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(WrongGuessList);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(487, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(307, 401);
            panel2.TabIndex = 1;
            // 
            // WrongGuessList
            // 
            WrongGuessList.FormattingEnabled = true;
            WrongGuessList.Location = new Point(20, 53);
            WrongGuessList.Name = "WrongGuessList";
            WrongGuessList.Size = new Size(270, 324);
            WrongGuessList.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSeaGreen;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 9);
            label2.Name = "label2";
            label2.Size = new Size(270, 41);
            label2.TabIndex = 0;
            label2.Text = "WRONG GUESSES";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(guessbtn);
            panel3.Controls.Add(guesstxt);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(2, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(479, 401);
            panel3.TabIndex = 2;
            // 
            // guessbtn
            // 
            guessbtn.BackColor = Color.DarkSeaGreen;
            guessbtn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guessbtn.ForeColor = Color.White;
            guessbtn.Location = new Point(113, 258);
            guessbtn.Name = "guessbtn";
            guessbtn.Size = new Size(241, 119);
            guessbtn.TabIndex = 3;
            guessbtn.Text = "GUESS THE NAME!";
            guessbtn.UseVisualStyleBackColor = false;
            guessbtn.Click += guessbtn_Click;
            // 
            // guesstxt
            // 
            guesstxt.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guesstxt.Location = new Point(10, 181);
            guesstxt.Name = "guesstxt";
            guesstxt.Size = new Size(458, 61);
            guesstxt.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SeaGreen;
            panel4.Controls.Add(wordtxt);
            panel4.Location = new Point(10, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(458, 125);
            panel4.TabIndex = 1;
            // 
            // wordtxt
            // 
            wordtxt.AutoSize = true;
            wordtxt.BackColor = Color.SpringGreen;
            wordtxt.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wordtxt.ForeColor = Color.White;
            wordtxt.Location = new Point(81, 30);
            wordtxt.Name = "wordtxt";
            wordtxt.Size = new Size(176, 62);
            wordtxt.TabIndex = 0;
            wordtxt.Text = "WORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaGreen;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(47, 137);
            label3.Name = "label3";
            label3.Size = new Size(370, 31);
            label3.TabIndex = 4;
            label3.Text = "Hint: League of Legends Character";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 498);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ListBox WrongGuessList;
        private Label label2;
        private Panel panel3;
        private Button guessbtn;
        private TextBox guesstxt;
        private Panel panel4;
        private Label wordtxt;
        private Label label3;
    }
}
