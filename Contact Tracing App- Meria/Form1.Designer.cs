namespace Contact_Tracing_App__Meria
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.titleHeader = new System.Windows.Forms.PictureBox();
            this.citizenBtn = new System.Windows.Forms.Button();
            this.merchantBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titleHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // titleHeader
            // 
            this.titleHeader.AccessibleName = "titleHeader";
            this.titleHeader.BackColor = System.Drawing.Color.Transparent;
            this.titleHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.titleHeader.Image = global::Contact_Tracing_App__Meria.Properties.Resources.tt;
            this.titleHeader.Location = new System.Drawing.Point(-70, -13);
            this.titleHeader.Name = "titleHeader";
            this.titleHeader.Size = new System.Drawing.Size(490, 227);
            this.titleHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleHeader.TabIndex = 0;
            this.titleHeader.TabStop = false;
            this.titleHeader.Click += new System.EventHandler(this.titleHeader_Click);
            // 
            // citizenBtn
            // 
            this.citizenBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.citizenBtn.BackColor = System.Drawing.Color.Transparent;
            this.citizenBtn.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.shiiish1;
            this.citizenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.citizenBtn.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.citizenBtn.FlatAppearance.BorderSize = 0;
            this.citizenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citizenBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.citizenBtn.Location = new System.Drawing.Point(130, 282);
            this.citizenBtn.Name = "citizenBtn";
            this.citizenBtn.Size = new System.Drawing.Size(380, 111);
            this.citizenBtn.TabIndex = 2;
            this.citizenBtn.UseVisualStyleBackColor = false;
            this.citizenBtn.Click += new System.EventHandler(this.citizenBtn_Click);
            // 
            // merchantBtn
            // 
            this.merchantBtn.BackColor = System.Drawing.Color.Transparent;
            this.merchantBtn.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.shish;
            this.merchantBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.merchantBtn.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.merchantBtn.FlatAppearance.BorderSize = 0;
            this.merchantBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.merchantBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.merchantBtn.Location = new System.Drawing.Point(130, 443);
            this.merchantBtn.Name = "merchantBtn";
            this.merchantBtn.Size = new System.Drawing.Size(380, 111);
            this.merchantBtn.TabIndex = 3;
            this.merchantBtn.UseVisualStyleBackColor = false;
            this.merchantBtn.Click += new System.EventHandler(this.merchantBtn_Click);
            // 
            // SignUp
            // 
            this.AccessibleDescription = "Sign Up Window";
            this.AccessibleName = "HomePage";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(643, 727);
            this.Controls.Add(this.merchantBtn);
            this.Controls.Add(this.citizenBtn);
            this.Controls.Add(this.titleHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.Text = "Sign Up!";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titleHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox titleHeader;
        private System.Windows.Forms.Button citizenBtn;
        private System.Windows.Forms.Button merchantBtn;
    }
}

