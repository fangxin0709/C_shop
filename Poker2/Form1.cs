namespace Poker2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] arrPic = new PictureBox[6]; // arrPic為圖片方塊陣列大小為5
        Random rnd = new Random();  //rnd為亂數物件
        int total = 0;  // total整數變數用來存放樸克牌的總點數
        int total2 = 0;
        int point = 0;	// 亂數產生的點數
        int[] point1 = new int[20];
        private void Form1_Load(object sender, EventArgs e)
        {   // 將pic1~pic5控制項指定為陣列元素
            arrPic[0] = Pic1; arrPic[1] = Pic2; arrPic[2] = Pic3;
            arrPic[3] = Pic4; arrPic[4] = Pic5; arrPic[5] = Pic6;
            TmrRun.Interval = 50; 
            //BtnStart_Click(sender, e);  //執行BtnStart_Click事件
        }
        private void TmrRun_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 3; i <6; i++)       // pic3~pic5顯示背景圖
            {
                point1[i] = rnd.Next(1, 14);  // 產生0~12變數
                arrPic[i].Image = Image.FromFile($"Poker{point1[i]}.jpg");
            }
            
        }
        // 按 <重新> 鈕
        private void BtnStart_Click(object sender, EventArgs e)
        {
            TmrRun.Start();
            total2 = 0;
            total = 0;    // 設樸克牌的總點數為0
            for (int i = 0; i <= 2; i++)         // pic1~pic2顯示亂數樸克牌圖
            {
                point = rnd.Next(1, 14);    // 產生1~13變數
                arrPic[i].Image = Image.FromFile($"Poker{point}.jpg");
                total += (point < 10 ? point : 10); // 若>10改為10點，再加入total 
            }
        }
        // 按 <發牌> 鈕時
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            TmrRun.Stop();
            for (int j = 3; j < 6; j++)
            {
                total2 += (point1[j] < 10 ? point1[j] : 10);
            }
            if (total2 < total)
            {
                LblMsg.Text = $"你輸了哈哈";
            }
            else if(total == total2)
            {
                LblMsg.Text = "平手";
            }
            else
            {

                LblMsg.Text = $"你贏了哈哈";
            }
            label1.Text = $"{total}";
            label2.Text = $"{total2}";
        }
    }
}