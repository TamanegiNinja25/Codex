namespace CashierApplication.V2
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
            amounttxt = new Label();
            label6 = new Label();
            label7 = new Label();
            changetxt = new Label();
            label9 = new Label();
            itemtxt = new TextBox();
            discounttxt = new TextBox();
            pricetxt = new TextBox();
            quantitxt = new TextBox();
            paymenttxt = new TextBox();
            computebtn = new Button();
            submitbtn = new Button();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(67, 31);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(347, 64);
            label2.Name = "label2";
            label2.Size = new Size(153, 31);
            label2.TabIndex = 1;
            label2.Text = "Discount (%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(71, 31);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(347, 150);
            label4.Name = "label4";
            label4.Size = new Size(109, 31);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            // 
            // amounttxt
            // 
            amounttxt.AutoSize = true;
            amounttxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            amounttxt.Location = new Point(178, 277);
            amounttxt.Name = "amounttxt";
            amounttxt.Size = new Size(242, 31);
            amounttxt.TabIndex = 4;
            amounttxt.Text = "<Total Amount Here>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label6.Location = new Point(12, 277);
            label6.Name = "label6";
            label6.Size = new Size(160, 31);
            label6.TabIndex = 5;
            label6.Text = "Total Amount:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label7.Location = new Point(12, 333);
            label7.Name = "label7";
            label7.Size = new Size(207, 31);
            label7.TabIndex = 6;
            label7.Text = "Payment Received:";
            // 
            // changetxt
            // 
            changetxt.AutoSize = true;
            changetxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            changetxt.Location = new Point(225, 384);
            changetxt.Name = "changetxt";
            changetxt.Size = new Size(180, 31);
            changetxt.TabIndex = 7;
            changetxt.Text = "<Change Here>";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label9.Location = new Point(121, 384);
            label9.Name = "label9";
            label9.Size = new Size(98, 31);
            label9.TabIndex = 8;
            label9.Text = "Change:";
            // 
            // itemtxt
            // 
            itemtxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            itemtxt.Location = new Point(12, 98);
            itemtxt.Name = "itemtxt";
            itemtxt.Size = new Size(329, 38);
            itemtxt.TabIndex = 12;
            // 
            // discounttxt
            // 
            discounttxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            discounttxt.Location = new Point(386, 98);
            discounttxt.Name = "discounttxt";
            discounttxt.Size = new Size(59, 38);
            discounttxt.TabIndex = 13;
            // 
            // pricetxt
            // 
            pricetxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            pricetxt.Location = new Point(89, 150);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(252, 38);
            pricetxt.TabIndex = 14;
            // 
            // quantitxt
            // 
            quantitxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            quantitxt.Location = new Point(449, 150);
            quantitxt.Name = "quantitxt";
            quantitxt.Size = new Size(51, 38);
            quantitxt.TabIndex = 15;
            // 
            // paymenttxt
            // 
            paymenttxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            paymenttxt.Location = new Point(225, 326);
            paymenttxt.Name = "paymenttxt";
            paymenttxt.Size = new Size(151, 38);
            paymenttxt.TabIndex = 16;
            // 
            // computebtn
            // 
            computebtn.BackColor = Color.DeepSkyBlue;
            computebtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            computebtn.Location = new Point(12, 204);
            computebtn.Name = "computebtn";
            computebtn.Size = new Size(488, 48);
            computebtn.TabIndex = 18;
            computebtn.Text = "Compute Price";
            computebtn.UseVisualStyleBackColor = false;
            computebtn.Click += computebtn_Click;
            // 
            // submitbtn
            // 
            submitbtn.BackColor = Color.Aqua;
            submitbtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            submitbtn.Location = new Point(386, 325);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(114, 39);
            submitbtn.TabIndex = 19;
            submitbtn.Text = "Submit";
            submitbtn.UseVisualStyleBackColor = false;
            submitbtn.Click += submitbtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(451, 101);
            label10.Name = "label10";
            label10.Size = new Size(49, 31);
            label10.TabIndex = 20;
            label10.Text = "(%)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 426);
            Controls.Add(label10);
            Controls.Add(submitbtn);
            Controls.Add(computebtn);
            Controls.Add(paymenttxt);
            Controls.Add(quantitxt);
            Controls.Add(pricetxt);
            Controls.Add(discounttxt);
            Controls.Add(itemtxt);
            Controls.Add(label9);
            Controls.Add(changetxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(amounttxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label amounttxt;
        private Label label6;
        private Label label7;
        private Label changetxt;
        private Label label9;
        private TextBox itemtxt;
        private TextBox discounttxt;
        private TextBox pricetxt;
        private TextBox quantitxt;
        private TextBox paymenttxt;
        private Button computebtn;
        private Button submitbtn;
        private Label label10;
    }
}
