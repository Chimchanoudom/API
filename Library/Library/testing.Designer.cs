namespace Library
{
    partial class testing
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
            this.usercontrol_testing1 = new Library.BorrowBook();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usercontrol_testing1
            // 
            this.usercontrol_testing1.Dock = System.Windows.Forms.DockStyle.Top;
            this.usercontrol_testing1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usercontrol_testing1.Location = new System.Drawing.Point(0, 0);
            this.usercontrol_testing1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usercontrol_testing1.Name = "usercontrol_testing1";
            this.usercontrol_testing1.Size = new System.Drawing.Size(473, 175);
            this.usercontrol_testing1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usercontrol_testing1);
            this.Name = "testing";
            this.Text = "testing";
            this.Load += new System.EventHandler(this.testing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BorrowBook usercontrol_testing1;
        private System.Windows.Forms.Button button1;
    }
}