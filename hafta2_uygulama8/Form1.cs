﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta2_uygulama8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mause üzerimdedir.");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Mause artık üzerimde değildir.");
        }
    }
}
