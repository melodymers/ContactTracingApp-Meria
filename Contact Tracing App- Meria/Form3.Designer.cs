namespace Contact_Tracing_App__Meria
{
    partial class adminDesk
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
            this.DisplayAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayAllBtn
            // 
            this.DisplayAllBtn.Location = new System.Drawing.Point(35, 142);
            this.DisplayAllBtn.Name = "DisplayAllBtn";
            this.DisplayAllBtn.Size = new System.Drawing.Size(298, 178);
            this.DisplayAllBtn.TabIndex = 0;
            this.DisplayAllBtn.UseVisualStyleBackColor = true;
            this.DisplayAllBtn.Click += new System.EventHandler(this.DisplayAllBtn_Click);
            // 
            // adminDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 625);
            this.Controls.Add(this.DisplayAllBtn);
            this.Name = "adminDesk";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.adminDesk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisplayAllBtn;
    }
}