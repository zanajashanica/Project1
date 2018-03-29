using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async Task<int> Calculate()
        {
            System.Threading.Thread.Sleep(1000);
            textBox1.Text = (Double.Parse(txtNumber1.Text) + Double.Parse(txtNumber2.Text)).ToString();
            return 1;
        }

        private async void btnCalculate_Click_1(object sender, EventArgs e)
        {
            Task<int> task = Calculate();
            int result = await task;
        }
    }
}
