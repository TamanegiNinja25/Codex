namespace GuessingGame
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
            label2 = new Label();
            randomtxt = new Label();
            guesstxt = new TextBox();
            label3 = new Label();
            WrongGuessList = new ListBox();
            guessbtn = new Button();
            randomize = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 78);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 14);
            label2.Name = "label2";
            label2.Size = new Size(663, 50);
            label2.TabIndex = 2;
            label2.Text = "WELCOME TO THE GUESSING GAME!";
            // 
            // randomtxt
            // 
            randomtxt.AutoSize = true;
            randomtxt.BackColor = Color.DarkSeaGreen;
            randomtxt.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            randomtxt.Location = new Point(120, 122);
            randomtxt.Name = "randomtxt";
            randomtxt.Size = new Size(217, 81);
            randomtxt.TabIndex = 2;
            randomtxt.Text = "Words";
            // 
            // guesstxt
            // 
            guesstxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guesstxt.Location = new Point(120, 293);
            guesstxt.Name = "guesstxt";
            guesstxt.Size = new Size(298, 47);
            guesstxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSeaGreen;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(555, 107);
            label3.Name = "label3";
            label3.Size = new Size(233, 41);
            label3.TabIndex = 4;
            label3.Text = "Wrong Guesses";
            // 
            // WrongGuessList
            // 
            WrongGuessList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WrongGuessList.FormattingEnabled = true;
            WrongGuessList.ItemHeight = 31;
            WrongGuessList.Location = new Point(555, 165);
            WrongGuessList.Name = "WrongGuessList";
            WrongGuessList.Size = new Size(233, 314);
            WrongGuessList.TabIndex = 5;
            // 
            // guessbtn
            // 
            guessbtn.BackColor = Color.SeaGreen;
            guessbtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guessbtn.ForeColor = Color.White;
            guessbtn.Location = new Point(140, 358);
            guessbtn.Name = "guessbtn";
            guessbtn.Size = new Size(257, 121);
            guessbtn.TabIndex = 6;
            guessbtn.Text = "Guess The Word!";
            guessbtn.UseVisualStyleBackColor = false;
            guessbtn.Click += guessbtn_Click;
            // 
            // randomize
            // 
            randomize.BackColor = Color.SeaGreen;
            randomize.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            randomize.ForeColor = Color.White;
            randomize.Location = new Point(179, 219);
            randomize.Name = "randomize";
            randomize.Size = new Size(188, 49);
            randomize.TabIndex = 7;
            randomize.Text = "Randomize";
            randomize.UseVisualStyleBackColor = false;
            randomize.Click += randomize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 507);
            Controls.Add(randomize);
            Controls.Add(guessbtn);
            Controls.Add(WrongGuessList);
            Controls.Add(label3);
            Controls.Add(guesstxt);
            Controls.Add(randomtxt);
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
        private Label label2;
        private Label randomtxt;
        private TextBox guesstxt;
        private Label label3;
        private ListBox WrongGuessList;
        private Button guessbtn;
        private Button randomize;
    }
}
