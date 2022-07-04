namespace Contact_Tracing_App__Meria
{
    partial class scanQr
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
            this.components = new System.ComponentModel.Container();
            this.labelQR = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.CBBox = new System.Windows.Forms.ComboBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.readBtn = new System.Windows.Forms.Button();
            this.genTmr = new System.Windows.Forms.Timer(this.components);
            this.stopBtn = new System.Windows.Forms.Button();
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
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // CBBox
            // 
            this.CBBox.FormattingEnabled = true;
            this.CBBox.Location = new System.Drawing.Point(110, 25);
            this.CBBox.Name = "CBBox";
            this.CBBox.Size = new System.Drawing.Size(415, 28);
            this.CBBox.TabIndex = 2;
            this.CBBox.SelectedIndexChanged += new System.EventHandler(this.CBBox_SelectedIndexChanged);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(423, 514);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(102, 42);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(26, 513);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(391, 214);
            this.txtBox.TabIndex = 4;
            this.txtBox.Text = "";
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(423, 562);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(102, 43);
            this.readBtn.TabIndex = 5;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // genTmr
            // 
            this.genTmr.Tick += new System.EventHandler(this.IndTmr);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(423, 611);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(102, 43);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // generateQr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.BGGG;
            this.ClientSize = new System.Drawing.Size(553, 739);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.CBBox);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.labelQR);
            this.Name = "generateQr";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.generateQr_FormClosing);
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
        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Timer genTmr;
        private System.Windows.Forms.Button stopBtn;
    }
}