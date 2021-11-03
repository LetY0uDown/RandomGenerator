using System;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Random random = new Random();
        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bGenerate_Click(object sender, EventArgs e)
        {
            if(int.TryParse(numMin.Text, out int min) == false || int.TryParse(numMax.Text, out int max) == false|| max <= min)
            {
                MessageBox.Show("You input wrong values!", "Value error!");
                return;
            }
            labelResult.Text = random.Next(min, max + 1).ToString();
        }
    }
}
