namespace CashierApplication
{
    partial class CashierApplication
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
            totaltxt = new Label();
            label7 = new Label();
            label8 = new Label();
            changetxt = new Label();
            itemtxt = new TextBox();
            pricetxt = new TextBox();
            paymenttxt = new TextBox();
            discounttxt = new TextBox();
            quantitxt = new TextBox();
            computebtn = new Button();
            submitbtn = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(67, 31);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(326, 40);
            label2.Name = "label2";
            label2.Size = new Size(153, 31);
            label2.TabIndex = 1;
            label2.Text = "Discount (%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(71, 31);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(326, 130);
            label4.Name = "label4";
            label4.Size = new Size(109, 31);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(128, 251);
            label5.Name = "label5";
            label5.Size = new Size(160, 31);
            label5.TabIndex = 4;
            label5.Text = "Total Amount:";
            // 
            // totaltxt
            // 
            totaltxt.AutoSize = true;
            totaltxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            totaltxt.Location = new Point(294, 251);
            totaltxt.Name = "totaltxt";
            totaltxt.Size = new Size(113, 31);
            totaltxt.TabIndex = 5;
            totaltxt.Text = "(Amount)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label7.Location = new Point(12, 319);
            label7.Name = "label7";
            label7.Size = new Size(207, 31);
            label7.TabIndex = 6;
            label7.Text = "Payment Received:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label8.Location = new Point(119, 395);
            label8.Name = "label8";
            label8.Size = new Size(98, 31);
            label8.TabIndex = 7;
            label8.Text = "Change:";
            // 
            // changetxt
            // 
            changetxt.AutoSize = true;
            changetxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            changetxt.Location = new Point(216, 395);
            changetxt.Name = "changetxt";
            changetxt.Size = new Size(108, 31);
            changetxt.TabIndex = 8;
            changetxt.Text = "(Change)";
            // 
            // itemtxt
            // 
            itemtxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            itemtxt.Location = new Point(12, 74);
            itemtxt.Name = "itemtxt";
            itemtxt.Size = new Size(309, 38);
            itemtxt.TabIndex = 9;
            // 
            // pricetxt
            // 
            pricetxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            pricetxt.Location = new Point(78, 123);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(139, 38);
            pricetxt.TabIndex = 10;
            // 
            // paymenttxt
            // 
            paymenttxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            paymenttxt.Location = new Point(216, 312);
            paymenttxt.Name = "paymenttxt";
            paymenttxt.Size = new Size(132, 38);
            paymenttxt.TabIndex = 11;
            // 
            // discounttxt
            // 
            discounttxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            discounttxt.Location = new Point(475, 33);
            discounttxt.Name = "discounttxt";
            discounttxt.Size = new Size(63, 38);
            discounttxt.TabIndex = 12;
            // 
            // quantitxt
            // 
            quantitxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            quantitxt.Location = new Point(431, 123);
            quantitxt.Name = "quantitxt";
            quantitxt.Size = new Size(107, 38);
            quantitxt.TabIndex = 13;
            // 
            // computebtn
            // 
            computebtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            computebtn.Location = new Point(12, 177);
            computebtn.Name = "computebtn";
            computebtn.Size = new Size(526, 46);
            computebtn.TabIndex = 14;
            computebtn.Text = "Compute Total Price";
            computebtn.UseVisualStyleBackColor = true;
            computebtn.Click += computebtn_Click_1;
            // 
            // submitbtn
            // 
            submitbtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            submitbtn.Location = new Point(362, 309);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(176, 72);
            submitbtn.TabIndex = 15;
            submitbtn.Text = "Submit Payment";
            submitbtn.UseVisualStyleBackColor = true;
            submitbtn.Click += submitbtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(557, 28);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(46, 24);
            toolStripMenuItem1.Text = "File";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click_1;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit Application";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // CashierApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 434);
            Controls.Add(submitbtn);
            Controls.Add(computebtn);
            Controls.Add(quantitxt);
            Controls.Add(discounttxt);
            Controls.Add(paymenttxt);
            Controls.Add(pricetxt);
            Controls.Add(itemtxt);
            Controls.Add(changetxt);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(totaltxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CashierApplication";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label totaltxt;
        private Label label7;
        private Label label8;
        private Label changetxt;
        private TextBox itemtxt;
        private TextBox pricetxt;
        private TextBox paymenttxt;
        private TextBox discounttxt;
        private TextBox quantitxt;
        private Button computebtn;
        private Button submitbtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
