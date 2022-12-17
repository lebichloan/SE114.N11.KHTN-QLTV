﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fInfoTuaSach : Form
    {
        private static int id;
        public fInfoTuaSach(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            var f = new fEditTuaSach(id);
            f.ShowDialog();

        }
    }
}
