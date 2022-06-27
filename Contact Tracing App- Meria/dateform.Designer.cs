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
            this.recdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recdate
            // 
            this.recdate.AutoSize = true;
            this.recdate.Location = new System.Drawing.Point(129, 179);
            this.recdate.Name = "recdate";
            this.recdate.Size = new System.Drawing.Size(0, 20);
            this.recdate.TabIndex = 6;
            // 
            // dateform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.BGGG;
            this.ClientSize = new System.Drawing.Size(563, 690);
            this.Controls.Add(this.recdate);
            this.Name = "dateform";
            this.ShowIcon = false;
            this.Text = "dateform";
            this.Load += new System.EventHandler(this.dateform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recdate;
    }
}