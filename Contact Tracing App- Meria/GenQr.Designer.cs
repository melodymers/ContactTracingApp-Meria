namespace Contact_Tracing_App__Meria
{
    partial class GenQr
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
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.lblOnly = new System.Windows.Forms.Label();
            this.picGen = new System.Windows.Forms.PictureBox();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGen)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Image = global::Contact_Tracing_App__Meria.Properties.Resources.generate2;
            this.GenerateBtn.Location = new System.Drawing.Point(141, 554);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(257, 106);
            this.GenerateBtn.TabIndex = 0;
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // lblOnly
            // 
            this.lblOnly.AutoSize = true;
            this.lblOnly.BackColor = System.Drawing.Color.Transparent;
            this.lblOnly.Location = new System.Drawing.Point(24, 9);
            this.lblOnly.Name = "lblOnly";
            this.lblOnly.Size = new System.Drawing.Size(75, 20);
            this.lblOnly.TabIndex = 1;
            this.lblOnly.Text = "QR Code";
            this.lblOnly.Click += new System.EventHandler(this.lblOnly_Click);
            // 
            // picGen
            // 
            this.picGen.BackColor = System.Drawing.Color.Transparent;
            this.picGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picGen.Location = new System.Drawing.Point(28, 32);
            this.picGen.Name = "picGen";
            this.picGen.Size = new System.Drawing.Size(466, 388);
            this.picGen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGen.TabIndex = 3;
            this.picGen.TabStop = false;
            this.picGen.Click += new System.EventHandler(this.picGen_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(28, 426);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(466, 122);
            this.txtBox.TabIndex = 4;
            this.txtBox.Text = "";
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // GenQr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.BGGG;
            this.ClientSize = new System.Drawing.Size(542, 662);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.picGen);
            this.Controls.Add(this.lblOnly);
            this.Controls.Add(this.GenerateBtn);
            this.Name = "GenQr";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.picGen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Label lblOnly;
        private System.Windows.Forms.PictureBox picGen;
        private System.Windows.Forms.RichTextBox txtBox;
    }
}