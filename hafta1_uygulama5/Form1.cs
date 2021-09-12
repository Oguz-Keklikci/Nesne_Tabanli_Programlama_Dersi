using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta1_uygulama5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello World";
            textBox1.ForeColor = Color.Red;
            textBox1.Enabled = false;
            textBox1.Visible = false;
            textBox1.Font = new Font("Broadway", 16);
        }
    }
}
