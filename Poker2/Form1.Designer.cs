namespace Poker2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.Pic3 = new System.Windows.Forms.PictureBox();
            this.Pic4 = new System.Windows.Forms.PictureBox();
            this.Pic5 = new System.Windows.Forms.PictureBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.Pic6 = new System.Windows.Forms.PictureBox();
            this.TmrRun = new System.Windows.Forms.Timer(this.components);
            this.ImgPoker = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic6)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic1
            // 
            this.Pic1.Location = new System.Drawing.Point(21, 99);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(71, 96);
            this.Pic1.TabIndex = 0;
            this.Pic1.TabStop = false;
            // 
            // Pic2
            // 
            this.Pic2.Location = new System.Drawing.Point(98, 99);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(71, 96);
            this.Pic2.TabIndex = 0;
            this.Pic2.TabStop = false;
            // 
            // Pic3
            // 
            this.Pic3.Location = new System.Drawing.Point(175, 99);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(71, 96);
            this.Pic3.TabIndex = 1;
            this.Pic3.TabStop = false;
            // 
            // Pic4
            // 
            this.Pic4.Location = new System.Drawing.Point(286, 99);
            this.Pic4.Name = "Pic4";
            this.Pic4.Size = new System.Drawing.Size(71, 96);
            this.Pic4.TabIndex = 2;
            this.Pic4.TabStop = false;
            // 
            // Pic5
            // 
            this.Pic5.Location = new System.Drawing.Point(363, 99);
            this.Pic5.Name = "Pic5";
            this.Pic5.Size = new System.Drawing.Size(71, 96);
            this.Pic5.TabIndex = 3;
            this.Pic5.TabStop = false;
            // 
            // LblMsg
            // 
            this.LblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMsg.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMsg.Location = new System.Drawing.Point(21, 198);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(239, 39);
            this.LblMsg.TabIndex = 4;
            this.LblMsg.Text = "按<開始>";
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(350, 202);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(64, 23);
            this.BtnOpen.TabIndex = 5;
            this.BtnOpen.Text = "停止";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(280, 202);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(64, 23);
            this.BtnStart.TabIndex = 6;
            this.BtnStart.Text = "開始";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Pic6
            // 
            this.Pic6.Location = new System.Drawing.Point(440, 99);
            this.Pic6.Name = "Pic6";
            this.Pic6.Size = new System.Drawing.Size(71, 96);
            this.Pic6.TabIndex = 7;
            this.Pic6.TabStop = false;
            // 
            // TmrRun
            // 
            this.TmrRun.Tick += new System.EventHandler(this.TmrRun_Tick);
            // 
            // ImgPoker
            // 
            this.ImgPoker.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgPoker.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgPoker.ImageStream")));
            this.ImgPoker.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgPoker.Images.SetKeyName(0, "poker1.jpg");
            this.ImgPoker.Images.SetKeyName(1, "poker2.jpg");
            this.ImgPoker.Images.SetKeyName(2, "poker3.jpg");
            this.ImgPoker.Images.SetKeyName(3, "poker4.jpg");
            this.ImgPoker.Images.SetKeyName(4, "poker5.jpg");
            this.ImgPoker.Images.SetKeyName(5, "poker6.jpg");
            this.ImgPoker.Images.SetKeyName(6, "poker7.jpg");
            this.ImgPoker.Images.SetKeyName(7, "poker8.jpg");
            this.ImgPoker.Images.SetKeyName(8, "poker9.jpg");
            this.ImgPoker.Images.SetKeyName(9, "poker10.jpg");
            this.ImgPoker.Images.SetKeyName(10, "poker11.jpg");
            this.ImgPoker.Images.SetKeyName(11, "poker12.jpg");
            this.ImgPoker.Images.SetKeyName(12, "poker13.jpg");
            this.ImgPoker.Images.SetKeyName(13, "pokerbk.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "電腦";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "你";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 343);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pic6);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.Pic5);
            this.Controls.Add(this.Pic4);
            this.Controls.Add(this.Pic3);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.Pic1);
            this.Name = "Form1";
            this.Text = "21點遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Pic1;
        private PictureBox Pic2;
        private PictureBox Pic3;
        private PictureBox Pic4;
        private PictureBox Pic5;
        private Label LblMsg;
        private Button BtnOpen;
        private Button BtnStart;
        private PictureBox Pic6;
        private System.Windows.Forms.Timer TmrRun;
        private ImageList ImgPoker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}