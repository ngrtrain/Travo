﻿namespace travo
{
    partial class FormP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttlogout = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.cbnegara = new System.Windows.Forms.ComboBox();
            this.cbdaerah = new System.Windows.Forms.ComboBox();
            this.pbback = new System.Windows.Forms.PictureBox();
            this.panelpaket = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 694);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttlogout
            // 
            this.buttlogout.BackColor = System.Drawing.Color.DarkCyan;
            this.buttlogout.ForeColor = System.Drawing.SystemColors.Window;
            this.buttlogout.Location = new System.Drawing.Point(1024, 18);
            this.buttlogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttlogout.Name = "buttlogout";
            this.buttlogout.Size = new System.Drawing.Size(158, 49);
            this.buttlogout.TabIndex = 3;
            this.buttlogout.Text = "Log Out";
            this.buttlogout.UseVisualStyleBackColor = false;
            this.buttlogout.Click += new System.EventHandler(this.buttlogout_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.BackColor = System.Drawing.Color.DarkCyan;
            this.tbsearch.ForeColor = System.Drawing.SystemColors.Window;
            this.tbsearch.Location = new System.Drawing.Point(248, 29);
            this.tbsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(310, 26);
            this.tbsearch.TabIndex = 8;
            this.tbsearch.TextChanged += new System.EventHandler(this.tbsearch_TextChanged);
            // 
            // cbnegara
            // 
            this.cbnegara.BackColor = System.Drawing.Color.DarkCyan;
            this.cbnegara.ForeColor = System.Drawing.SystemColors.Window;
            this.cbnegara.FormattingEnabled = true;
            this.cbnegara.Items.AddRange(new object[] {
            "Indonesia",
            "Thailand",
            "Jepang"});
            this.cbnegara.Location = new System.Drawing.Point(718, 311);
            this.cbnegara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbnegara.Name = "cbnegara";
            this.cbnegara.Size = new System.Drawing.Size(229, 28);
            this.cbnegara.TabIndex = 9;
            this.cbnegara.Text = "Negara";
            this.cbnegara.SelectedValueChanged += new System.EventHandler(this.cbnegara_SelectedValueChanged);
            // 
            // cbdaerah
            // 
            this.cbdaerah.BackColor = System.Drawing.Color.DarkCyan;
            this.cbdaerah.ForeColor = System.Drawing.SystemColors.Window;
            this.cbdaerah.FormattingEnabled = true;
            this.cbdaerah.Items.AddRange(new object[] {
            "Bali",
            "Yogyakarta",
            "Labuan Bajo",
            "Tokyo",
            "Kyoto",
            "Osaka",
            "Bangkok",
            "Hua Hin",
            "Phuket"});
            this.cbdaerah.Location = new System.Drawing.Point(958, 311);
            this.cbdaerah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbdaerah.Name = "cbdaerah";
            this.cbdaerah.Size = new System.Drawing.Size(229, 28);
            this.cbdaerah.TabIndex = 10;
            this.cbdaerah.Text = "Daerah";
            this.cbdaerah.SelectedValueChanged += new System.EventHandler(this.cbdaerah_SelectedValueChanged);
            // 
            // pbback
            // 
            this.pbback.Image = ((System.Drawing.Image)(resources.GetObject("pbback.Image")));
            this.pbback.Location = new System.Drawing.Point(964, 18);
            this.pbback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbback.Name = "pbback";
            this.pbback.Size = new System.Drawing.Size(51, 48);
            this.pbback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbback.TabIndex = 11;
            this.pbback.TabStop = false;
            this.pbback.Click += new System.EventHandler(this.pbback_Click);
            // 
            // panelpaket
            // 
            this.panelpaket.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelpaket.Location = new System.Drawing.Point(12, 358);
            this.panelpaket.Name = "panelpaket";
            this.panelpaket.Size = new System.Drawing.Size(1163, 315);
            this.panelpaket.TabIndex = 12;
            // 
            // FormP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 695);
            this.Controls.Add(this.panelpaket);
            this.Controls.Add(this.pbback);
            this.Controls.Add(this.cbdaerah);
            this.Controls.Add(this.cbnegara);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.buttlogout);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormP";
            this.Text = "Pelayaran";
            this.Load += new System.EventHandler(this.FormP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttlogout;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.ComboBox cbnegara;
        private System.Windows.Forms.ComboBox cbdaerah;
        private System.Windows.Forms.PictureBox pbback;
        private System.Windows.Forms.FlowLayoutPanel panelpaket;
    }
}