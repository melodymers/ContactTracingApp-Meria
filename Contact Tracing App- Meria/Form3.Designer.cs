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
            this.recDateLbl = new System.Windows.Forms.Label();
            this.filterByNamebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayAllBtn
            // 
            this.DisplayAllBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DisplayAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.DisplayAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DisplayAllBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DisplayAllBtn.Image = global::Contact_Tracing_App__Meria.Properties.Resources.DISPLAY_ALLl3;
            this.DisplayAllBtn.Location = new System.Drawing.Point(12, 27);
            this.DisplayAllBtn.Name = "DisplayAllBtn";
            this.DisplayAllBtn.Size = new System.Drawing.Size(542, 83);
            this.DisplayAllBtn.TabIndex = 0;
            this.DisplayAllBtn.UseVisualStyleBackColor = false;
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
            this.SetDatePickr.ValueChanged += new System.EventHandler(this.SetDatePickr_ValueChanged);
            // 
            // DatePickrBtn
            // 
            this.DatePickrBtn.BackColor = System.Drawing.Color.Transparent;
            this.DatePickrBtn.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.dateee;
            this.DatePickrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DatePickrBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DatePickrBtn.Location = new System.Drawing.Point(12, 448);
            this.DatePickrBtn.Name = "DatePickrBtn";
            this.DatePickrBtn.Size = new System.Drawing.Size(267, 55);
            this.DatePickrBtn.TabIndex = 4;
            this.DatePickrBtn.UseVisualStyleBackColor = false;
            this.DatePickrBtn.Click += new System.EventHandler(this.DatePickrBtn_Click);
            // 
            // recDateLbl
            // 
            this.recDateLbl.AutoSize = true;
            this.recDateLbl.BackColor = System.Drawing.Color.Transparent;
            this.recDateLbl.Location = new System.Drawing.Point(121, 538);
            this.recDateLbl.Name = "recDateLbl";
            this.recDateLbl.Size = new System.Drawing.Size(52, 20);
            this.recDateLbl.TabIndex = 12;
            this.recDateLbl.Text = "DATE";
            this.recDateLbl.Click += new System.EventHandler(this.recDateLbl_Click_1);
            // 
            // filterByNamebtn
            // 
            this.filterByNamebtn.BackColor = System.Drawing.Color.Transparent;
            this.filterByNamebtn.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.by_namee;
            this.filterByNamebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filterByNamebtn.ForeColor = System.Drawing.Color.Transparent;
            this.filterByNamebtn.Location = new System.Drawing.Point(287, 448);
            this.filterByNamebtn.Name = "filterByNamebtn";
            this.filterByNamebtn.Size = new System.Drawing.Size(267, 55);
            this.filterByNamebtn.TabIndex = 13;
            this.filterByNamebtn.UseVisualStyleBackColor = false;
            // 
            // adminDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.BGGG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(564, 708);
            this.Controls.Add(this.filterByNamebtn);
            this.Controls.Add(this.DisplayAllBtn);
            this.Controls.Add(this.recDateLbl);
            this.Controls.Add(this.DatePickrBtn);
            this.Controls.Add(this.SetDatePickr);
            this.Controls.Add(this.forAllDisplayBox);
            this.Name = "adminDesk";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.adminDesk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox forAllDisplayBox;
        private System.Windows.Forms.DateTimePicker SetDatePickr;
        private System.Windows.Forms.Button DatePickrBtn;
        private System.Windows.Forms.Label recDateLbl;
        private System.Windows.Forms.Button DisplayAllBtn;
        private System.Windows.Forms.Button filterByNamebtn;
    }
}