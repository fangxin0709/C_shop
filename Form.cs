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
            int[] score = new int[5];
            string[] name = new string[] { "丁丁", "拉拉", "迪西", "小波", "努努" };
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                while (sum == 0)
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox($"{name[i]}老師給分", "輸入");
                    int re;
                    if (int.TryParse(input, out re))
                    {
                        if (re < 0 || re > 100)
                        {
                            MessageBox.Show("數值不合理!");
                        }
                        else
                        {
                            score[i] = re;
                            sum++;

                        }
                    }
                    else
                    {
                        MessageBox.Show("請輸入整數!");
                    }
                }
                sum = 0;
            }
            int j = 0;
            foreach (string t in name)
            {
                label1.Text += $"{t}老師給分:{score[j]}\n";
                j++;
            }
            label1.Text += "==============\n";
            int avg;
            int all = 0;
            for (int z = 0; z < score.Length; z++)
            {
                all += score[z];
            }
            avg = all / score.Length;
            label1.Text += $"平均分數：{avg}";

        }
    }
}
