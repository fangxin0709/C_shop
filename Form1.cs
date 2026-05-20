using System.IO;

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
            string[] data = Reader("08.txt").Split("\r");
            MessageBox.Show($"題目共有 {data[0]} 題");

            double[] ans = new double[int.Parse(data[0])];
            for(int n = 0; n < int.Parse(data[0]); n++)
            {
                ans[n] = Calculate(data[n+1]);
                MessageBox.Show($"第 {n + 1} 題 答案是 {ans[n]}");

            }
            FileInfo finfo = new FileInfo("out.txt");
            StreamWriter sw = finfo.CreateText();

            foreach(double a in ans)
            {
                sw.WriteLine(a);
                richTextBox1.Text += a.ToString() + "\r";
            }
            sw.Flush();
            sw.Close();
            //richTextBox1.Text = File.ReadAllText("out.txt");
        }
        private static string Reader(string path)
        {
            StreamReader sr = new StreamReader(path);
            string str = sr.ReadToEnd();
            sr.Close();
            return str;
        }
        private static double Calculate(string st)
        {
            string[] stNum = st.Split(',');
            double[] stnum = new double[stNum.Length];
            for (int i = 0; i < stNum.Length; i++)
            {
                stnum[i] = double.Parse(stNum[i]);
            }
            Array.Sort(stnum);
            Array.Reverse(stnum);
            return stnum[0];
        }
    }
}