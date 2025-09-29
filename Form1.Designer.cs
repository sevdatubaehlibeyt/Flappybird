namespace Flappybird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.bulut = new System.Windows.Forms.PictureBox();
            this.bulut1 = new System.Windows.Forms.PictureBox();
            this.bulut2 = new System.Windows.Forms.PictureBox();
            this.bulut3 = new System.Windows.Forms.PictureBox();
            this.bulut8 = new System.Windows.Forms.PictureBox();
            this.bulut4 = new System.Windows.Forms.PictureBox();
            this.bulut7 = new System.Windows.Forms.PictureBox();
            this.bulut5 = new System.Windows.Forms.PictureBox();
            this.bulut10 = new System.Windows.Forms.PictureBox();
            this.bulut11 = new System.Windows.Forms.PictureBox();
            this.bulut9 = new System.Windows.Forms.PictureBox();
            this.bulut6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut6)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(153, 120);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(88, 62);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.flappyBird_Click);
            // 
            // BoruUst
            // 
            this.BoruUst.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst.Image")));
            this.BoruUst.Location = new System.Drawing.Point(606, -71);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(100, 211);
            this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst.TabIndex = 0;
            this.BoruUst.TabStop = false;
            // 
            // BoruAlt
            // 
            this.BoruAlt.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt.Image")));
            this.BoruAlt.Location = new System.Drawing.Point(606, 384);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(100, 141);
            this.BoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt.TabIndex = 0;
            this.BoruAlt.TabStop = false;
            this.BoruAlt.Click += new System.EventHandler(this.BoruAlt_Click);
            // 
            // Zemin
            // 
            this.Zemin.Image = ((System.Drawing.Image)(resources.GetObject("Zemin.Image")));
            this.Zemin.Location = new System.Drawing.Point(0, 522);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(800, 77);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 0;
            this.Zemin.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(3, 561);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(137, 38);
            this.scoreText.TabIndex = 2;
            this.scoreText.Text = "Score:0";
            this.scoreText.Click += new System.EventHandler(this.scoreText_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // bulut
            // 
            this.bulut.Image = ((System.Drawing.Image)(resources.GetObject("bulut.Image")));
            this.bulut.Location = new System.Drawing.Point(390, 316);
            this.bulut.Name = "bulut";
            this.bulut.Size = new System.Drawing.Size(147, 72);
            this.bulut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulut.TabIndex = 3;
            this.bulut.TabStop = false;
            // 
            // bulut1
            // 
            this.bulut1.Image = ((System.Drawing.Image)(resources.GetObject("bulut1.Image")));
            this.bulut1.Location = new System.Drawing.Point(350, -5);
            this.bulut1.Name = "bulut1";
            this.bulut1.Size = new System.Drawing.Size(114, 75);
            this.bulut1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulut1.TabIndex = 4;
            this.bulut1.TabStop = false;
            // 
            // bulut2
            // 
            this.bulut2.Image = ((System.Drawing.Image)(resources.GetObject("bulut2.Image")));
            this.bulut2.Location = new System.Drawing.Point(606, 232);
            this.bulut2.Name = "bulut2";
            this.bulut2.Size = new System.Drawing.Size(150, 63);
            this.bulut2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulut2.TabIndex = 4;
            this.bulut2.TabStop = false;
            // 
            // bulut3
            // 
            this.bulut3.Image = ((System.Drawing.Image)(resources.GetObject("bulut3.Image")));
            this.bulut3.Location = new System.Drawing.Point(606, 79);
            this.bulut3.Name = "bulut3";
            this.bulut3.Size = new System.Drawing.Size(160, 61);
            this.bulut3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulut3.TabIndex = 4;
            this.bulut3.TabStop = false;
            this.bulut3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bulut8
            // 
            this.bulut8.Image = ((System.Drawing.Image)(resources.GetObject("bulut8.Image")));
            this.bulut8.Location = new System.Drawing.Point(1038, -19);
            this.bulut8.Name = "bulut8";
            this.bulut8.Size = new System.Drawing.Size(160, 61);
            this.bulut8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulut8.TabIndex = 4;
            this.bulut8.TabStop = false;
            this.bulut8.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bulut4
            // 
            this.bulut4.Image = ((System.Drawing.Image)(resources.GetObject("bulut4.Image")));
            this.bulut4.Location = new System.Drawing.Point(-10, 0);
            this.bulut4.Name = "bulut4";
            this.bulut4.Size = new System.Drawing.Size(150, 63);
            this.bulut4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulut4.TabIndex = 4;
            this.bulut4.TabStop = false;
            // 
            // bulut7
            // 
            this.bulut7.Image = ((System.Drawing.Image)(resources.GetObject("bulut7.Image")));
            this.bulut7.Location = new System.Drawing.Point(50, 158);
            this.bulut7.Name = "bulut7";
            this.bulut7.Size = new System.Drawing.Size(114, 75);
            this.bulut7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulut7.TabIndex = 4;
            this.bulut7.TabStop = false;
            // 
            // bulut5
            // 
            this.bulut5.Image = ((System.Drawing.Image)(resources.GetObject("bulut5.Image")));
            this.bulut5.Location = new System.Drawing.Point(332, 158);
            this.bulut5.Name = "bulut5";
            this.bulut5.Size = new System.Drawing.Size(150, 63);
            this.bulut5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulut5.TabIndex = 4;
            this.bulut5.TabStop = false;
            // 
            // bulut10
            // 
            this.bulut10.Image = ((System.Drawing.Image)(resources.GetObject("bulut10.Image")));
            this.bulut10.Location = new System.Drawing.Point(856, 427);
            this.bulut10.Name = "bulut10";
            this.bulut10.Size = new System.Drawing.Size(160, 61);
            this.bulut10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulut10.TabIndex = 4;
            this.bulut10.TabStop = false;
            this.bulut10.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bulut11
            // 
            this.bulut11.Image = ((System.Drawing.Image)(resources.GetObject("bulut11.Image")));
            this.bulut11.Location = new System.Drawing.Point(846, 91);
            this.bulut11.Name = "bulut11";
            this.bulut11.Size = new System.Drawing.Size(150, 63);
            this.bulut11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulut11.TabIndex = 4;
            this.bulut11.TabStop = false;
            // 
            // bulut9
            // 
            this.bulut9.Image = ((System.Drawing.Image)(resources.GetObject("bulut9.Image")));
            this.bulut9.Location = new System.Drawing.Point(1038, 232);
            this.bulut9.Name = "bulut9";
            this.bulut9.Size = new System.Drawing.Size(114, 75);
            this.bulut9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulut9.TabIndex = 4;
            this.bulut9.TabStop = false;
            // 
            // bulut6
            // 
            this.bulut6.Image = ((System.Drawing.Image)(resources.GetObject("bulut6.Image")));
            this.bulut6.Location = new System.Drawing.Point(153, 12);
            this.bulut6.Name = "bulut6";
            this.bulut6.Size = new System.Drawing.Size(165, 72);
            this.bulut6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulut6.TabIndex = 3;
            this.bulut6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(801, 596);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.BoruUst);
            this.Controls.Add(this.bulut8);
            this.Controls.Add(this.bulut10);
            this.Controls.Add(this.bulut3);
            this.Controls.Add(this.bulut11);
            this.Controls.Add(this.bulut4);
            this.Controls.Add(this.bulut5);
            this.Controls.Add(this.bulut2);
            this.Controls.Add(this.bulut7);
            this.Controls.Add(this.bulut9);
            this.Controls.Add(this.bulut1);
            this.Controls.Add(this.bulut6);
            this.Controls.Add(this.bulut);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.BoruAlt);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulut6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox BoruUst;
        private System.Windows.Forms.PictureBox BoruAlt;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox bulut;
        private System.Windows.Forms.PictureBox bulut1;
        private System.Windows.Forms.PictureBox bulut2;
        private System.Windows.Forms.PictureBox bulut3;
        private System.Windows.Forms.PictureBox bulut8;
        private System.Windows.Forms.PictureBox bulut4;
        private System.Windows.Forms.PictureBox bulut7;
        private System.Windows.Forms.PictureBox bulut5;
        private System.Windows.Forms.PictureBox bulut10;
        private System.Windows.Forms.PictureBox bulut11;
        private System.Windows.Forms.PictureBox bulut9;
        private System.Windows.Forms.PictureBox bulut6;
    }
}

