using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_FS04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(textBox1.Text);
            double attend = Convert.ToDouble(textBox2.Text);
            double result = (attend * 100) / total;
            textBox3.Text = Convert.ToString(result);
            if (result > 60.00)
            {
                MessageBox.Show("Not Detained!!");
            }
            else
            {
                MessageBox.Show(" Detained!!");

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
