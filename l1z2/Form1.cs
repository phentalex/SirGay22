using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l1z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(textBox1.Text);
            double y = Double.Parse(textBox2.Text);
            double r = Double.Parse(textBox3.Text);

            if (x <= 0 && y >= 0 && Math.Pow(x + r, 2) + Math.Pow(y - r, 2) <= Math.Pow(r, 2) ||
                x >= 0 && x <= 2 * r && y <= 0 && y >= -r)

            {
                MessageBox.Show("Заданная точка попадает :)", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("Заданная точка не попадает :(", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
