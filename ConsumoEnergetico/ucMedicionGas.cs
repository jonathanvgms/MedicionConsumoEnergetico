﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoEnergetico
{
    public partial class ucMedicionGas : UserControl
    {
        public ucMedicionGas()
        {
            InitializeComponent();
        }

        private void btnNuevoMedidor_Click(object sender, EventArgs e)
        {
            frmMedidor medidorGas = new frmMedidor();
            medidorGas.ShowDialog(this);
        }
    }
}
