﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Call_in_a_Doctor
{
    public partial class frmDoctorsListDermatologyAndVenereology : Form
    {
        public frmDoctorsListDermatologyAndVenereology()
        {
            InitializeComponent();
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoctorsListDermatologyAndVenereology_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
