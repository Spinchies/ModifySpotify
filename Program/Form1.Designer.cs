namespace Program
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.hopeButton1 = new ReaLTaiizor.Controls.HopeButton();
            this.hopeButton2 = new ReaLTaiizor.Controls.HopeButton();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hopeForm1
            // 
            this.hopeForm1.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeForm1.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeForm1.ControlBoxColorN = System.Drawing.Color.White;
            this.hopeForm1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hopeForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hopeForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeForm1.Image = null;
            this.hopeForm1.Location = new System.Drawing.Point(0, 0);
            this.hopeForm1.Name = "hopeForm1";
            this.hopeForm1.Size = new System.Drawing.Size(418, 40);
            this.hopeForm1.TabIndex = 0;
            this.hopeForm1.Text = "ModifySpotify";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // hopeButton1
            // 
            this.hopeButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hopeButton1.BorderColor = System.Drawing.Color.Purple;
            this.hopeButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButton1.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButton1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButton1.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButton1.Location = new System.Drawing.Point(124, 248);
            this.hopeButton1.Name = "hopeButton1";
            this.hopeButton1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hopeButton1.Size = new System.Drawing.Size(175, 46);
            this.hopeButton1.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButton1.TabIndex = 1;
            this.hopeButton1.Text = "Install Patched Spotify";
            this.hopeButton1.TextColor = System.Drawing.Color.White;
            this.hopeButton1.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButton1.Click += new System.EventHandler(this.hopeButton1_Click);
            // 
            // hopeButton2
            // 
            this.hopeButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hopeButton2.BorderColor = System.Drawing.Color.Purple;
            this.hopeButton2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButton2.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButton2.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButton2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButton2.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButton2.Location = new System.Drawing.Point(124, 300);
            this.hopeButton2.Name = "hopeButton2";
            this.hopeButton2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hopeButton2.Size = new System.Drawing.Size(175, 46);
            this.hopeButton2.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButton2.TabIndex = 2;
            this.hopeButton2.Text = "Install Spicetify";
            this.hopeButton2.TextColor = System.Drawing.Color.White;
            this.hopeButton2.Visible = false;
            this.hopeButton2.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButton2.Click += new System.EventHandler(this.hopeButton2_Click);
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox1.Image")));
            this.hopePictureBox1.Location = new System.Drawing.Point(-168, 12);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(598, 492);
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 3;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hopePictureBox1.Click += new System.EventHandler(this.hopePictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(418, 489);
            this.Controls.Add(this.hopeForm1);
            this.Controls.Add(this.hopeButton2);
            this.Controls.Add(this.hopeButton1);
            this.Controls.Add(this.hopePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopeButton hopeButton1;
        private ReaLTaiizor.Controls.HopeButton hopeButton2;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
    }
}

