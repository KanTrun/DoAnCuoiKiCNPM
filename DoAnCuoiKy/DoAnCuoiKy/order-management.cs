﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class order_management : Form
    {
        public order_management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order_management om = new order_management();
            om.Show();
            this.Hide();
        }
    }
}
