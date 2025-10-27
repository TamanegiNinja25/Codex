namespace Inventory
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            prodtxt = new TextBox();
            quantitxt = new TextBox();
            sellpricetxt = new TextBox();
            categcbx = new ComboBox();
            manufacturingdate = new DateTimePicker();
            expirationdate = new DateTimePicker();
            descriptiontxt = new RichTextBox();
            addbtn = new Button();
            prodgrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)prodgrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(338, 60);
            label1.TabIndex = 0;
            label1.Text = "ADD PRODUCT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Yellow;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(123, 38);
            label2.TabIndex = 1;
            label2.Text = "Product:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Yellow;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(140, 38);
            label3.TabIndex = 2;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(12, 230);
            label4.Name = "label4";
            label4.Size = new Size(152, 38);
            label4.TabIndex = 3;
            label4.Text = "Mfg. Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Yellow;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(12, 289);
            label5.Name = "label5";
            label5.Size = new Size(145, 38);
            label5.TabIndex = 4;
            label5.Text = "Exp. Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Yellow;
            label6.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label6.ForeColor = Color.ForestGreen;
            label6.Location = new Point(12, 353);
            label6.Name = "label6";
            label6.Size = new Size(133, 38);
            label6.TabIndex = 5;
            label6.Text = "Quantity:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Yellow;
            label7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(12, 419);
            label7.Name = "label7";
            label7.Size = new Size(137, 38);
            label7.TabIndex = 6;
            label7.Text = "Sell Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Yellow;
            label8.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(634, 113);
            label8.Name = "label8";
            label8.Size = new Size(168, 38);
            label8.TabIndex = 7;
            label8.Text = "Description:";
            // 
            // prodtxt
            // 
            prodtxt.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            prodtxt.Location = new Point(188, 110);
            prodtxt.Name = "prodtxt";
            prodtxt.Size = new Size(422, 43);
            prodtxt.TabIndex = 8;
            // 
            // quantitxt
            // 
            quantitxt.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            quantitxt.Location = new Point(188, 350);
            quantitxt.Name = "quantitxt";
            quantitxt.Size = new Size(422, 43);
            quantitxt.TabIndex = 9;
            // 
            // sellpricetxt
            // 
            sellpricetxt.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            sellpricetxt.Location = new Point(188, 416);
            sellpricetxt.Name = "sellpricetxt";
            sellpricetxt.Size = new Size(422, 43);
            sellpricetxt.TabIndex = 10;
            // 
            // categcbx
            // 
            categcbx.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categcbx.FormattingEnabled = true;
            categcbx.Location = new Point(188, 172);
            categcbx.Name = "categcbx";
            categcbx.Size = new Size(422, 45);
            categcbx.TabIndex = 11;
            // 
            // manufacturingdate
            // 
            manufacturingdate.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            manufacturingdate.Location = new Point(188, 230);
            manufacturingdate.Name = "manufacturingdate";
            manufacturingdate.Size = new Size(422, 43);
            manufacturingdate.TabIndex = 12;
            // 
            // expirationdate
            // 
            expirationdate.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            expirationdate.Location = new Point(188, 291);
            expirationdate.Name = "expirationdate";
            expirationdate.Size = new Size(422, 43);
            expirationdate.TabIndex = 13;
            // 
            // descriptiontxt
            // 
            descriptiontxt.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptiontxt.Location = new Point(634, 172);
            descriptiontxt.Name = "descriptiontxt";
            descriptiontxt.Size = new Size(459, 285);
            descriptiontxt.TabIndex = 14;
            descriptiontxt.Text = "";
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.Yellow;
            addbtn.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbtn.ForeColor = Color.ForestGreen;
            addbtn.Location = new Point(865, 474);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(228, 50);
            addbtn.TabIndex = 15;
            addbtn.Text = "ADD PRODUCT";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // prodgrid
            // 
            prodgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prodgrid.Location = new Point(12, 540);
            prodgrid.Name = "prodgrid";
            prodgrid.RowHeadersWidth = 51;
            prodgrid.Size = new Size(1081, 247);
            prodgrid.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(1105, 799);
            Controls.Add(prodgrid);
            Controls.Add(addbtn);
            Controls.Add(descriptiontxt);
            Controls.Add(expirationdate);
            Controls.Add(manufacturingdate);
            Controls.Add(categcbx);
            Controls.Add(sellpricetxt);
            Controls.Add(quantitxt);
            Controls.Add(prodtxt);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Inventory";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)prodgrid).EndInit();
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
        private TextBox prodtxt;
        private TextBox quantitxt;
        private TextBox sellpricetxt;
        private ComboBox categcbx;
        private DateTimePicker manufacturingdate;
        private DateTimePicker expirationdate;
        private RichTextBox descriptiontxt;
        private Button addbtn;
        private DataGridView prodgrid;
    }
}
