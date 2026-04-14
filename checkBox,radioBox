namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total=0;
            string cup = Microsoft.VisualBasic.Interaction.InputBox("請輸入杯數(整數)：","杯數輸入");
            string msg;
            int cup1;
            if(!int.TryParse(cup, out cup1) || cup1<=0)
            {
                MessageBox.Show("請輸入正確杯數!","",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            else
            {
                string msg1, msg2, msg3, msg4;
                msg1 = "飲料：";
                if (radioButton1.Checked == true)
                {
                    msg1 += "紅茶(30元/杯)；";
                    total += 30;
                }
                else if (radioButton2.Checked == true)
                {
                    msg1 += "綠茶(25元/杯)；";
                    total += 25;
                }
                else
                {
                    msg1 += "奶茶(40元/杯)；";
                    total += 40;
                }
                msg2 = "加料：";
                if (checkBox1.Checked == true)
                {
                    msg2 += "珍珠；";
                    total += 10;
                }
                if (checkBox2.Checked == true)
                {
                    msg2 += "椰果；";
                    total += 10;
                }
                if (checkBox3.Checked == true)
                {
                    msg2 += "加冰；";
                }
                if(checkBox1.Checked ==false && checkBox2.Checked ==false && checkBox3.Checked ==false)
                {
                    msg2 += "無；";
                }
                msg3 = "杯數：" + cup + "；";
                total *= cup1;
                msg4 = $"總金額：{total}";
                label1.Text = msg1 + msg2 + msg3 + msg4;
            }
            
        }
    }
}
