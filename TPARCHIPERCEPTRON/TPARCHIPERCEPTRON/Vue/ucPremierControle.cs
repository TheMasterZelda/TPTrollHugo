using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPARCHIPERCEPTRON.Vue
{
    public partial class ucPremierControle : UserControl
    {
        public ucPremierControle()
        {
            InitializeComponent();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            ucDessin = new ucZoneDessin();
        }
    }
}
