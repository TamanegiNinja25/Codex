namespace ThreadingApplication
{
    partial class frmTrackThread
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            runbtn = new Button();
            statustxt = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // runbtn
            // 
            runbtn.BackColor = Color.Maroon;
            runbtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            runbtn.ForeColor = Color.Transparent;
            runbtn.Location = new Point(114, 178);
            runbtn.Name = "runbtn";
            runbtn.Size = new Size(406, 123);
            runbtn.TabIndex = 0;
            runbtn.Text = "RUN";
            runbtn.UseVisualStyleBackColor = false;
            runbtn.Click += button1_Click;
            // 
            // statustxt
            // 
            statustxt.AutoSize = true;
            statustxt.BackColor = Color.White;
            statustxt.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statustxt.Location = new Point(96, 75);
            statustxt.Name = "statustxt";
            statustxt.Size = new Size(321, 50);
            statustxt.TabIndex = 1;
            statustxt.Text = "-THREAD START-";
            statustxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmTrackThread
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(646, 363);
            Controls.Add(statustxt);
            Controls.Add(runbtn);
            Name = "frmTrackThread";
            Text = "frmTrackThread";
            Load += frmTrackThread_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Button runbtn;
        private Label statustxt;
    }
}
