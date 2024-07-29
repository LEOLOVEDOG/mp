namespace MYPROJECT66
{
    partial class Form3
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
            this.picbox_sl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_sl)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_sl
            // 
            this.picbox_sl.BackColor = System.Drawing.Color.Transparent;
            this.picbox_sl.Image = global::MYPROJECT66.Properties.Resources.截圖_2024_07_26_下午4_05_38;
            this.picbox_sl.Location = new System.Drawing.Point(1233, 552);
            this.picbox_sl.Name = "picbox_sl";
            this.picbox_sl.Size = new System.Drawing.Size(475, 500);
            this.picbox_sl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_sl.TabIndex = 2;
            this.picbox_sl.TabStop = false;
            this.picbox_sl.Click += new System.EventHandler(this.picbox_sl_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MYPROJECT66.Properties.Resources.Store;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1680, 1050);
            this.Controls.Add(this.picbox_sl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form3";
            this.Text = "mdi parent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_sl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_sl;
    }
}