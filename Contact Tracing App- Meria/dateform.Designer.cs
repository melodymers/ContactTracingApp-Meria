namespace Contact_Tracing_App__Meria
{
    partial class dateform
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
            this.recDateLbl = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // recDateLbl
            // 
            this.recDateLbl.BackColor = System.Drawing.SystemColors.Info;
            this.recDateLbl.Location = new System.Drawing.Point(23, 39);
            this.recDateLbl.Name = "recDateLbl";
            this.recDateLbl.Size = new System.Drawing.Size(511, 599);
            this.recDateLbl.TabIndex = 12;
            this.recDateLbl.Text = "";
            this.recDateLbl.TextChanged += new System.EventHandler(this.recDateLbl_TextChanged);
            // 
            // dateform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.BGGG;
            this.ClientSize = new System.Drawing.Size(563, 690);
            this.Controls.Add(this.recDateLbl);
            this.Name = "dateform";
            this.ShowIcon = false;
            this.Text = "dateform";
            this.Load += new System.EventHandler(this.dateform_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox recDateLbl;
    }
}