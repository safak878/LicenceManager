namespace LicenceManager.LicenceCreator
{
    partial class TxtUserName
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
            this.TxtUsernamee = new DevExpress.XtraEditors.TextEdit();
            this.TxtCompany = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsernamee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompany.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsernamee
            // 
            this.TxtUsernamee.Location = new System.Drawing.Point(81, 12);
            this.TxtUsernamee.Name = "TxtUsernamee";
            this.TxtUsernamee.Size = new System.Drawing.Size(231, 20);
            this.TxtUsernamee.TabIndex = 0;
            // 
            // TxtCompany
            // 
            this.TxtCompany.Location = new System.Drawing.Point(81, 38);
            this.TxtCompany.Name = "TxtCompany";
            this.TxtCompany.Size = new System.Drawing.Size(231, 20);
            this.TxtCompany.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cari",
            "Stok",
            "Fatura",
            "İrsaliye",
            "Kasa"});
            this.checkedListBox1.Location = new System.Drawing.Point(11, 64);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(301, 109);
            this.checkedListBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Lisans Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCompany);
            this.Controls.Add(this.TxtUsernamee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TxtUserName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsernamee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompany.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtUsernamee;
        private DevExpress.XtraEditors.TextEdit TxtCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
    }
}

