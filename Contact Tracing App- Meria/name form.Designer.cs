namespace Contact_Tracing_App__Meria
{
    partial class name_form
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
            this.nameformtxtbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // nameformtxtbox
            // 
            this.nameformtxtbox.BackColor = System.Drawing.SystemColors.Info;
            this.nameformtxtbox.Location = new System.Drawing.Point(43, 40);
            this.nameformtxtbox.Name = "nameformtxtbox";
            this.nameformtxtbox.Size = new System.Drawing.Size(511, 599);
            this.nameformtxtbox.TabIndex = 13;
            this.nameformtxtbox.Text = "";
            // 
            // name_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.BGGG;
            this.ClientSize = new System.Drawing.Size(596, 679);
            this.Controls.Add(this.nameformtxtbox);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "name_form";
            this.ShowIcon = false;
            this.Text = "name_form";
            this.Load += new System.EventHandler(this.name_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox nameformtxtbox;
    }
}