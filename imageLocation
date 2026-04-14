namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = new Bitmap("9161.jpg");
            pictureBox2.Image = new Bitmap("9162.jpg");
            pictureBox3.Image = new Bitmap("9163.jpg");
            pictureBox4.Image = new Bitmap("9164.jpg");
            pictureBox5.Image = pictureBox1.Image;
        }

        private void s()
        {
            for(int h = 0; h <= 320; h++)
            {
                pictureBox5.Size = new Size(h, 240);
                pictureBox5.Location = new Point(448-h, 176);
                DateTime now = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - now).TotalSeconds < 0.01);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox3.Image;
            s();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox1.Image;
            s();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox2.Image;
            s();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox4.Image;
            s();
        }
    }
}
