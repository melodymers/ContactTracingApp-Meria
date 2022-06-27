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
            this.forAllDisplayBox = new System.Windows.Forms.RichTextBox();
            this.SetDatePickr = new System.Windows.Forms.DateTimePicker();
            this.DatePickrBtn = new System.Windows.Forms.Button();
            this.recdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayAllBtn
            // 
            this.DisplayAllBtn.Location = new System.Drawing.Point(12, 12);
            this.DisplayAllBtn.Name = "DisplayAllBtn";
            this.DisplayAllBtn.Size = new System.Drawing.Size(542, 88);
            this.DisplayAllBtn.TabIndex = 0;
            this.DisplayAllBtn.UseVisualStyleBackColor = true;
            this.DisplayAllBtn.Click += new System.EventHandler(this.DisplayAllBtn_Click);
            // 
            // forAllDisplayBox
            // 
            this.forAllDisplayBox.Location = new System.Drawing.Point(12, 116);
            this.forAllDisplayBox.Name = "forAllDisplayBox";
            this.forAllDisplayBox.Size = new System.Drawing.Size(542, 310);
            this.forAllDisplayBox.TabIndex = 1;
            this.forAllDisplayBox.Text = "";
            // 
            // SetDatePickr
            // 
            this.SetDatePickr.Location = new System.Drawing.Point(11, 509);
            this.SetDatePickr.Name = "SetDatePickr";
            this.SetDatePickr.Size = new System.Drawing.Size(268, 26);
            this.SetDatePickr.TabIndex = 2;
            // 
            // DatePickrBtn
            // 
            this.DatePickrBtn.Location = new System.Drawing.Point(12, 448);
            this.DatePickrBtn.Name = "DatePickrBtn";
            this.DatePickrBtn.Size = new System.Drawing.Size(267, 55);
            this.DatePickrBtn.TabIndex = 4;
            this.DatePickrBtn.UseVisualStyleBackColor = true;
            this.DatePickrBtn.Click += new System.EventHandler(this.DatePickrBtn_Click);
            // 
            // recdate
            // 
            this.recdate.AutoSize = true;
            this.recdate.Location = new System.Drawing.Point(106, 538);
            this.recdate.Name = "recdate";
            this.recdate.Size = new System.Drawing.Size(59, 20);
            this.recdate.TabIndex = 5;
            this.recdate.Text = "dateee";
            this.recdate.Click += new System.EventHandler(this.recdate_Click);
            // 
            // adminDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.BGGG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(566, 708);
            this.Controls.Add(this.recdate);
            this.Controls.Add(this.DatePickrBtn);
            this.Controls.Add(this.SetDatePickr);
            this.Controls.Add(this.forAllDisplayBox);
            this.Controls.Add(this.DisplayAllBtn);
            this.Name = "adminDesk";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.adminDesk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplayAllBtn;
        private System.Windows.Forms.RichTextBox forAllDisplayBox;
        private System.Windows.Forms.DateTimePicker SetDatePickr;
        private System.Windows.Forms.Button DatePickrBtn;
        private System.Windows.Forms.Label recdate;
    }
}