namespace PetShop
{
    partial class Scanner
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
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSource
            // 
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(157, 21);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(361, 21);
            this.cbSource.TabIndex = 0;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(37, 361);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(623, 20);
            this.txtBarcode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pilih Sumber";
            // 
            // pbBarcode
            // 
            this.pbBarcode.Location = new System.Drawing.Point(37, 48);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Size = new System.Drawing.Size(623, 307);
            this.pbBarcode.TabIndex = 1;
            this.pbBarcode.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(524, 21);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 393);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.pbBarcode);
            this.Controls.Add(this.cbSource);
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scanner_FormClosing);
            this.Load += new System.EventHandler(this.Scanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.PictureBox pbBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
    }
}