namespace ModifySpotify
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            airForm1 = new ReaLTaiizor.Forms.AirForm();
            pictureBox1 = new PictureBox();
            foreverButton2 = new ReaLTaiizor.Controls.ForeverButton();
            foreverButton1 = new ReaLTaiizor.Controls.ForeverButton();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            airForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // airForm1
            // 
            airForm1.BackColor = Color.FromArgb(64, 64, 64);
            airForm1.BorderStyle = FormBorderStyle.None;
            airForm1.Controls.Add(pictureBox1);
            airForm1.Controls.Add(foreverButton2);
            airForm1.Controls.Add(foreverButton1);
            airForm1.Controls.Add(hopePictureBox1);
            airForm1.Controls.Add(airSeparator1);
            airForm1.Customization = "AAAA/1paWv9ycnL/";
            airForm1.Dock = DockStyle.Fill;
            airForm1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            airForm1.Image = null;
            airForm1.Location = new Point(0, 0);
            airForm1.MinimumSize = new Size(112, 35);
            airForm1.Movable = true;
            airForm1.Name = "airForm1";
            airForm1.NoRounding = false;
            airForm1.Sizable = false;
            airForm1.Size = new Size(406, 406);
            airForm1.SmartBounds = true;
            airForm1.StartPosition = FormStartPosition.CenterScreen;
            airForm1.TabIndex = 0;
            airForm1.TransparencyKey = Color.Fuchsia;
            airForm1.Transparent = false;
            airForm1.Click += airForm1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 46);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // foreverButton2
            // 
            foreverButton2.BackColor = Color.Transparent;
            foreverButton2.BaseColor = Color.Cyan;
            foreverButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            foreverButton2.Location = new Point(151, 328);
            foreverButton2.Name = "foreverButton2";
            foreverButton2.Rounded = false;
            foreverButton2.Size = new Size(120, 40);
            foreverButton2.TabIndex = 3;
            foreverButton2.Text = "Install Spicetify";
            foreverButton2.TextColor = Color.Black;
            foreverButton2.Click += foreverButton2_Click;
            // 
            // foreverButton1
            // 
            foreverButton1.BackColor = Color.Transparent;
            foreverButton1.BaseColor = Color.Lime;
            foreverButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            foreverButton1.Location = new Point(151, 272);
            foreverButton1.Name = "foreverButton1";
            foreverButton1.Rounded = false;
            foreverButton1.Size = new Size(120, 40);
            foreverButton1.TabIndex = 2;
            foreverButton1.Text = "Install SpotX";
            foreverButton1.TextColor = Color.Black;
            foreverButton1.Click += foreverButton1_Click;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.Location = new Point(116, 106);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(170, 160);
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 1;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopePictureBox1.Click += hopePictureBox1_Click;
            // 
            // airSeparator1
            // 
            airSeparator1.BackColor = Color.Cyan;
            airSeparator1.Customization = "";
            airSeparator1.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            airSeparator1.Image = null;
            airSeparator1.Location = new Point(0, 33);
            airSeparator1.Name = "airSeparator1";
            airSeparator1.NoRounding = false;
            airSeparator1.Size = new Size(429, 1);
            airSeparator1.TabIndex = 0;
            airSeparator1.Text = "airSeparator1";
            airSeparator1.Transparent = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 406);
            Controls.Add(airForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1050);
            MinimumSize = new Size(261, 65);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dungeonForm1";
            TransparencyKey = Color.Fuchsia;
            airForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.ForeverButton foreverButton2;
        private ReaLTaiizor.Controls.ForeverButton foreverButton1;
        private PictureBox pictureBox1;
    }
}
