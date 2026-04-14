namespace A0318_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("up_64.png");
            pictureBox2.Image = new Bitmap("left_64.png");
            pictureBox3.Image = new Bitmap("right_64.png");
            pictureBox4.Image = new Bitmap("down_64.png");
            pictureBox5.Image = new Bitmap("big_64.png");
            pictureBox6.Image = new Bitmap("small_64.png");
            pictureUFO.Image = new Bitmap("飛碟.gif");
            pictureUFO.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        //up
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureUFO.Location = new Point(pictureUFO.Location.X, pictureUFO.Location.Y-10);
            if(pictureUFO.Location.Y <= -pictureUFO.Height)
            {
                pictureUFO.Location = new Point(pictureUFO.Location.X,this.ClientSize.Height);
            }
        }

        //down
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureUFO.Location = new Point(pictureUFO.Location.X, pictureUFO.Location.Y + 10);
            if (pictureUFO.Location.Y >= this.ClientSize.Height)
            {
                pictureUFO.Location = new Point(pictureUFO.Location.X, -pictureUFO.Height);
            }
        }

        //left
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureUFO.Location = new Point(pictureUFO.Location.X-10, pictureUFO.Location.Y);
            if (pictureUFO.Location.X <= -pictureUFO.Width)
            {
                pictureUFO.Location = new Point(this.ClientSize.Width, pictureUFO.Location.Y);
            }
        }

        //right
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureUFO.Location = new Point(pictureUFO.Location.X+10, pictureUFO.Location.Y);
            if (pictureUFO.Location.X >= this.ClientSize.Width)
            {
                pictureUFO.Location = new Point(-pictureUFO.Width,pictureUFO.Location.Y);
            }
        }

        //big
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureUFO.Size.Width < 200)
            {
                pictureUFO.Size = new Size(pictureUFO.Size.Width+10, pictureUFO.Size.Height + 10);
                pictureUFO.Location = new Point(pictureUFO.Location.X - 5, pictureUFO.Location.Y - 5);
            }
        }

        //small
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureUFO.Size.Height > 10)
            {
                pictureUFO.Size = new Size(pictureUFO.Size.Width - 10, pictureUFO.Size.Height - 10);
                pictureUFO.Location = new Point(pictureUFO.Location.X + 5, pictureUFO.Location.Y + 5);
            }
        }
    }
}
