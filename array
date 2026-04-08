namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str1 = "不為誰而作的歌,餘波盪漾,後來的我們,不該,年輪說,滿座,關鍵詞,天真有邪,獨善其身,一次幸福的機會";
        string str2 = "林俊傑,田馥甄,五月天,周杰倫,楊丞琳,李榮浩,林俊傑,林宥嘉,田馥甄,蕭敬騰";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] s1 = str1.Split(',');
            string[] s2 = str2.Split(',');
            int[] n = new int[s1.Length];
            textBox1.Text = "排名\t歌手\t歌曲\r\n";
            for(int i=0; i<s1.Length; i++)
            {
                n[i] = i+1;
            }
            for (int i = 0; i < s1.Length; i++)
            {
                textBox1.Text += $"{n[i]}\t{s2[i]}\t{s1[i]}\r\n";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "排名\t歌手\t歌曲\r\n";
            string[] s1 = str1.Split(',');
            string[] s2 = str2.Split(',');
            string[] sing = new string[10];
            int[] n = new int[10];
            for (int i = 0; i < s1.Length; i++)
            {
                n[i] = i+1;
            }
            s2.CopyTo(sing, 0);
            //後面的排序n會跟著前面的s2
            Array.Sort(sing,n);
            Array.Sort(s2,s1);

            Array.Reverse(s1);
            Array.Reverse(s2);
            Array.Reverse(n);
            for (int i=0; i<sing.Length; i++)
            {
                textBox1.Text += $"{n[i]}\t{s2[i]}\t{s1[i]}\r\n";

            }

        }
    }
}
