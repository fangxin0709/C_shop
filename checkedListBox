namespace Books
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] books = new string[] { "三國演義", "水滸傳", "西遊記", "紅樓夢", "聊齋志異", "鏡花緣" };
            ClstBooks.Items.AddRange(books);
            ClstBooks.CheckOnClick = true;
            ClstBorrow.CheckOnClick = true;
        }

        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            int n = 0;
            for (int i = 0; i < ClstBooks.Items.Count; i++)
            {
                if (ClstBooks.GetItemChecked(i))
                {
                    n++;
                }
            }
            for (int i = 0; i < ClstBorrow.Items.Count; i++)
            {
                if (ClstBorrow.GetItemChecked(i))
                {
                    n++;
                }
            }
            if (n == 0)
            {
                MessageBox.Show("未勾選項目", "提醒");
            }
            if (ClstBooks.CheckedItems.Count + ClstBorrow.Items.Count >= 3)
            {
                MessageBox.Show("最多借兩本書！", "注意！");
                for (int i = 0; i < ClstBooks.Items.Count; i++)
                    ClstBooks.SetItemChecked(i, false);
            }
            else
            {
                for (int i = ClstBooks.Items.Count - 1; i >= 0; i--)
                {
                    if (ClstBooks.GetItemChecked(i) == true)
                    {
                        ClstBorrow.Items.Add(ClstBooks.Items[i]);
                        ClstBooks.Items.RemoveAt(i);
                    }
                }

            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            int n =0;
            for(int i = 0; i < ClstBooks.Items.Count; i++)
            {
                if (ClstBooks.GetItemChecked(i)){
                    n++;
                }
            }
            for (int i = 0; i < ClstBorrow.Items.Count; i++)
            {
                if (ClstBorrow.GetItemChecked(i))
                {
                    n++;
                }
            }
            if (n==0)
            {
                MessageBox.Show("未勾選項目", "提醒");
            }
                foreach (int i in ClstBorrow.CheckedIndices)
                    ClstBooks.Items.Add(ClstBorrow.Items[i]);
                for (int i = ClstBorrow.Items.Count - 1; i >= 0; i--)
                {
                    if (ClstBorrow.GetItemChecked(i) == true)
                        ClstBorrow.Items.RemoveAt(i);
                }
            
        }

        private void ClstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClstBooks.CheckedItems.Count + ClstBorrow.Items.Count >= 3)
            {
                MessageBox.Show("最多借兩本書！", "注意！");
                int index = ClstBooks.SelectedIndex;
                if (index >= 0)
                {
                    ClstBooks.SetItemChecked(index, false);
                }
            }
        }
    }
}
