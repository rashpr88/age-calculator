using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker2.Value;
            DateTime n = DateTime.Now;
            int days = (n - d).Days;
            String s = Convert.ToString(days / 365) + " yrs and " + Convert.ToString(days % 365) + " days ";
            textBox1.Text = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
