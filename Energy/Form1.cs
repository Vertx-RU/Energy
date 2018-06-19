using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Energy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         double resault=((Convert.ToDouble(textBox1.Text)/1000) * ((Convert.ToDouble(textBox2.Text)) * (Convert.ToDouble(textBox2.Text)))) / 2;
            Math.Round(resault,2);
            textBox3.Text = resault.ToString();
            if (resault > 0.2 && resault < 1.8)
            {
                MessageBox.Show("这是中国认定仿真枪动能范围内了！！！");
            }
            else if (resault < 0.2)
            {
                MessageBox.Show("恭喜你，保持这个弹重和初速，动能不在仿真枪认定范围内~~~");
            }
            else if (resault > 1.8)
            {
                MessageBox.Show("小子你完了。在中国已经判定为真枪了。");
            }
        }
    }
}
