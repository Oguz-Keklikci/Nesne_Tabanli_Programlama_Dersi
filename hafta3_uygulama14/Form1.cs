using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta3_uygulama14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;
            textBox3.Text = toplam.ToString();
            MessageBox.Show(toplam.ToString());
        }
    }
}
