namespace Contact_Tracing_App__Meria
{
    partial class generateQr
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
            this.labelQR = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.CBBox = new System.Windows.Forms.ComboBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.readBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQR
            // 
            this.labelQR.AutoSize = true;
            this.labelQR.BackColor = System.Drawing.Color.Transparent;
            this.labelQR.Location = new System.Drawing.Point(22, 33);
            this.labelQR.Name = "labelQR";
            this.labelQR.Size = new System.Drawing.Size(82, 20);
            this.labelQR.TabIndex = 0;
            this.labelQR.Text = "CAMERA:";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(26, 74);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(499, 433);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // CBBox
            // 
            this.CBBox.FormattingEnabled = true;
            this.CBBox.Location = new System.Drawing.Point(110, 25);
            this.CBBox.Name = "CBBox";
            this.CBBox.Size = new System.Drawing.Size(415, 28);
            this.CBBox.TabIndex = 2;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(423, 514);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(102, 24);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 513);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(391, 214);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(423, 544);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(102, 25);
            this.readBtn.TabIndex = 5;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            // 
            // generateQr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.BGGG;
            this.ClientSize = new System.Drawing.Size(553, 739);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.CBBox);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.labelQR);
            this.Name = "generateQr";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.generateQr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQR;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ComboBox CBBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button readBtn;
    }
}