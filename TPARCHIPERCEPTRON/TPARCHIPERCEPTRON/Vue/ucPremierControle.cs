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
    /// <summary>
    /// Auteur : Renaud Gariepy
    /// Description : Controle utilisateur qui gère l'entrainement
    /// Date : 2017-05-11
    /// </summary>
    /// 
    [Designer(typeof(DesignerPremierControle))]
    [Docking(DockingBehavior.Ask)]
    public partial class ucPremierControle : UserControl
    {
        public ucPremierControle()
        {
            InitializeComponent();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
        }
    }
}
