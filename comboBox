namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] list1 = new string[] { "沙拉油", "肥皂", "果汁", "酒精", "輕便雨衣" };
            CboItem.Items.AddRange(list1);
            for(int i = 1; i <= 5; i++)
                CboNum.Items.Add($"{i}");
            CboNum.DropDownStyle = ComboBoxStyle.DropDown;
            
            CboItem.SelectedIndex = 0;
            CboNum.SelectedIndex = 0;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            LstList.Items.Add($" {CboItem.Text} 數量 {CboNum.Text} ");
            bool a = CboNum.Items.Contains(CboNum.Text);
            if (!a)
            {
                CboNum.Items.Add(CboNum.Text);

            }
        }

        private void BtnCls_Click(object sender, EventArgs e)
        {
            LstList.Items.Clear();
        }
    }
}
