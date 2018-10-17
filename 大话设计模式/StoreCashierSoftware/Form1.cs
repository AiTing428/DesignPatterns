using System;
using System.Windows.Forms;

namespace StoreCashierSoftware
{
    public partial class Form1 : Form
    {
        double Total = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            CashSuper cashSuper = CashFactory.creatCashAccept(comboBox1.SelectedItem.ToString());

            double totalPrices =cashSuper.CurPrice( Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));


            Total += totalPrices;

            listBox1.Items.Add("单价：" + textBox1.Text + "  数量：" +textBox2.Text + "  优惠选择："+comboBox1.Text+"  合计" + totalPrices.ToString());

            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = Total.ToString();
        }
    }
}
