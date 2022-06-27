namespace Contact_Tracing_App__Meria
{
    partial class FillOutForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personalDisply = new System.Windows.Forms.PictureBox();
            this.firstColumn = new System.Windows.Forms.PictureBox();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.AddTxtBx = new System.Windows.Forms.TextBox();
            this.bdayTxtBx = new System.Windows.Forms.TextBox();
            this.AgeTxtBx = new System.Windows.Forms.TextBox();
            this.genderTxtBx = new System.Windows.Forms.TextBox();
            this.nextColumn = new System.Windows.Forms.PictureBox();
            this.tempTxtBx = new System.Windows.Forms.TextBox();
            this.outTxtBx = new System.Windows.Forms.TextBox();
            this.inTxtBx = new System.Windows.Forms.TextBox();
            this.vaxTxtBx = new System.Windows.Forms.TextBox();
            this.bstrTxtBx = new System.Windows.Forms.TextBox();
            this.admnBtn = new System.Windows.Forms.Button();
            this.passBtn = new System.Windows.Forms.TextBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDisply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.AccessibleDescription = "submit button";
            this.GenerateBtn.BackColor = System.Drawing.Color.Transparent;
            this.GenerateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GenerateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateBtn.Image = global::Contact_Tracing_App__Meria.Properties.Resources.generate3;
            this.GenerateBtn.Location = new System.Drawing.Point(175, 625);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(218, 77);
            this.GenerateBtn.TabIndex = 0;
            this.GenerateBtn.UseVisualStyleBackColor = false;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "for title only";
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Contact_Tracing_App__Meria.Properties.Resources.tt;
            this.pictureBox1.InitialImage = global::Contact_Tracing_App__Meria.Properties.Resources.tt;
            this.pictureBox1.Location = new System.Drawing.Point(64, -39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // personalDisply
            // 
            this.personalDisply.AccessibleDescription = "display only";
            this.personalDisply.BackColor = System.Drawing.Color.Transparent;
            this.personalDisply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.personalDisply.Image = global::Contact_Tracing_App__Meria.Properties.Resources.depress1;
            this.personalDisply.Location = new System.Drawing.Point(211, 87);
            this.personalDisply.Name = "personalDisply";
            this.personalDisply.Size = new System.Drawing.Size(170, 175);
            this.personalDisply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personalDisply.TabIndex = 2;
            this.personalDisply.TabStop = false;
            // 
            // firstColumn
            // 
            this.firstColumn.BackColor = System.Drawing.Color.Transparent;
            this.firstColumn.Image = global::Contact_Tracing_App__Meria.Properties.Resources.bbb1;
            this.firstColumn.Location = new System.Drawing.Point(-5, 258);
            this.firstColumn.Name = "firstColumn";
            this.firstColumn.Size = new System.Drawing.Size(300, 361);
            this.firstColumn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstColumn.TabIndex = 3;
            this.firstColumn.TabStop = false;
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxtBx.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBx.ForeColor = System.Drawing.Color.Black;
            this.nameTxtBx.Location = new System.Drawing.Point(124, 284);
            this.nameTxtBx.Multiline = true;
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(159, 33);
            this.nameTxtBx.TabIndex = 4;
            this.nameTxtBx.TextChanged += new System.EventHandler(this.nameTxtBx_TextChanged);
            // 
            // AddTxtBx
            // 
            this.AddTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddTxtBx.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTxtBx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddTxtBx.Location = new System.Drawing.Point(114, 502);
            this.AddTxtBx.Multiline = true;
            this.AddTxtBx.Name = "AddTxtBx";
            this.AddTxtBx.Size = new System.Drawing.Size(169, 33);
            this.AddTxtBx.TabIndex = 7;
            this.AddTxtBx.TextChanged += new System.EventHandler(this.AddTxtBx_TextChanged);
            // 
            // bdayTxtBx
            // 
            this.bdayTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bdayTxtBx.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdayTxtBx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bdayTxtBx.Location = new System.Drawing.Point(141, 574);
            this.bdayTxtBx.Multiline = true;
            this.bdayTxtBx.Name = "bdayTxtBx";
            this.bdayTxtBx.Size = new System.Drawing.Size(142, 33);
            this.bdayTxtBx.TabIndex = 8;
            this.bdayTxtBx.TextChanged += new System.EventHandler(this.bdayTxtBx_TextChanged);
            // 
            // AgeTxtBx
            // 
            this.AgeTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeTxtBx.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTxtBx.ForeColor = System.Drawing.Color.Black;
            this.AgeTxtBx.Location = new System.Drawing.Point(77, 356);
            this.AgeTxtBx.Multiline = true;
            this.AgeTxtBx.Name = "AgeTxtBx";
            this.AgeTxtBx.Size = new System.Drawing.Size(206, 33);
            this.AgeTxtBx.TabIndex = 10;
            this.AgeTxtBx.TextChanged += new System.EventHandler(this.AgeTxtBx_TextChanged);
            // 
            // genderTxtBx
            // 
            this.genderTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genderTxtBx.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTxtBx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genderTxtBx.Location = new System.Drawing.Point(124, 425);
            this.genderTxtBx.Multiline = true;
            this.genderTxtBx.Name = "genderTxtBx";
            this.genderTxtBx.Size = new System.Drawing.Size(159, 33);
            this.genderTxtBx.TabIndex = 11;
            this.genderTxtBx.TextChanged += new System.EventHandler(this.genderTxtBx_TextChanged);
            // 
            // nextColumn
            // 
            this.nextColumn.BackColor = System.Drawing.Color.Transparent;
            this.nextColumn.Image = global::Contact_Tracing_App__Meria.Properties.Resources.part_21;
            this.nextColumn.Location = new System.Drawing.Point(301, 258);
            this.nextColumn.Name = "nextColumn";
            this.nextColumn.Size = new System.Drawing.Size(300, 361);
            this.nextColumn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nextColumn.TabIndex = 12;
            this.nextColumn.TabStop = false;
            // 
            // tempTxtBx
            // 
            this.tempTxtBx.BackColor = System.Drawing.Color.White;
            this.tempTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempTxtBx.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTxtBx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tempTxtBx.Location = new System.Drawing.Point(470, 274);
            this.tempTxtBx.Multiline = true;
            this.tempTxtBx.Name = "tempTxtBx";
            this.tempTxtBx.Size = new System.Drawing.Size(117, 34);
            this.tempTxtBx.TabIndex = 13;
            this.tempTxtBx.TextChanged += new System.EventHandler(this.tempTxtBx_TextChanged);
            // 
            // outTxtBx
            // 
            this.outTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outTxtBx.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outTxtBx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outTxtBx.Location = new System.Drawing.Point(427, 425);
            this.outTxtBx.Multiline = true;
            this.outTxtBx.Name = "outTxtBx";
            this.outTxtBx.Size = new System.Drawing.Size(160, 33);
            this.outTxtBx.TabIndex = 13;
            this.outTxtBx.TextChanged += new System.EventHandler(this.outTxtBx_TextChanged);
            // 
            // inTxtBx
            // 
            this.inTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inTxtBx.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inTxtBx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inTxtBx.Location = new System.Drawing.Point(416, 353);
            this.inTxtBx.Multiline = true;
            this.inTxtBx.Name = "inTxtBx";
            this.inTxtBx.Size = new System.Drawing.Size(171, 36);
            this.inTxtBx.TabIndex = 14;
            this.inTxtBx.TextChanged += new System.EventHandler(this.inTxtBx_TextChanged);
            // 
            // vaxTxtBx
            // 
            this.vaxTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vaxTxtBx.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaxTxtBx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vaxTxtBx.Location = new System.Drawing.Point(488, 494);
            this.vaxTxtBx.Multiline = true;
            this.vaxTxtBx.Name = "vaxTxtBx";
            this.vaxTxtBx.Size = new System.Drawing.Size(99, 41);
            this.vaxTxtBx.TabIndex = 15;
            this.vaxTxtBx.TextChanged += new System.EventHandler(this.vaxTxtBx_TextChanged);
            // 
            // bstrTxtBx
            // 
            this.bstrTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bstrTxtBx.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bstrTxtBx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bstrTxtBx.Location = new System.Drawing.Point(503, 574);
            this.bstrTxtBx.Multiline = true;
            this.bstrTxtBx.Name = "bstrTxtBx";
            this.bstrTxtBx.Size = new System.Drawing.Size(84, 33);
            this.bstrTxtBx.TabIndex = 16;
            this.bstrTxtBx.TextChanged += new System.EventHandler(this.bstrTxtBx_TextChanged);
            // 
            // admnBtn
            // 
            this.admnBtn.Location = new System.Drawing.Point(355, 230);
            this.admnBtn.Name = "admnBtn";
            this.admnBtn.Size = new System.Drawing.Size(126, 32);
            this.admnBtn.TabIndex = 18;
            this.admnBtn.Text = "ADMIN";
            this.admnBtn.UseVisualStyleBackColor = true;
            this.admnBtn.Click += new System.EventHandler(this.admnBtn_Click_1);
            // 
            // passBtn
            // 
            this.passBtn.Location = new System.Drawing.Point(470, 230);
            this.passBtn.Multiline = true;
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(117, 32);
            this.passBtn.TabIndex = 19;
            this.passBtn.TextChanged += new System.EventHandler(this.passBtn_TextChanged);
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(12, 231);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(200, 26);
            this.datePick.TabIndex = 20;
            this.datePick.ValueChanged += new System.EventHandler(this.datePick_ValueChanged);
            // 
            // FillOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Contact_Tracing_App__Meria.Properties.Resources.bgg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(599, 764);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.passBtn);
            this.Controls.Add(this.admnBtn);
            this.Controls.Add(this.personalDisply);
            this.Controls.Add(this.bstrTxtBx);
            this.Controls.Add(this.vaxTxtBx);
            this.Controls.Add(this.inTxtBx);
            this.Controls.Add(this.outTxtBx);
            this.Controls.Add(this.tempTxtBx);
            this.Controls.Add(this.nextColumn);
            this.Controls.Add(this.genderTxtBx);
            this.Controls.Add(this.AgeTxtBx);
            this.Controls.Add(this.bdayTxtBx);
            this.Controls.Add(this.AddTxtBx);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.firstColumn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FillOutForm";
            this.ShowIcon = false;
            this.Text = "Fill Out Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalDisply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox personalDisply;
        private System.Windows.Forms.PictureBox firstColumn;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.TextBox AddTxtBx;
        private System.Windows.Forms.TextBox bdayTxtBx;
        private System.Windows.Forms.TextBox AgeTxtBx;
        private System.Windows.Forms.TextBox genderTxtBx;
        private System.Windows.Forms.PictureBox nextColumn;
        private System.Windows.Forms.TextBox tempTxtBx;
        private System.Windows.Forms.TextBox outTxtBx;
        private System.Windows.Forms.TextBox inTxtBx;
        private System.Windows.Forms.TextBox vaxTxtBx;
        private System.Windows.Forms.TextBox bstrTxtBx;
        private System.Windows.Forms.Button admnBtn;
        private System.Windows.Forms.TextBox passBtn;
        private System.Windows.Forms.DateTimePicker datePick;
    }
}