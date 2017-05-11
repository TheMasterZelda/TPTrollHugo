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
        public delegate void EffacerButtonClickHandler(object sender, EventArgs e);
        public delegate void EntrainerButtonClickHandler(object sender, EventArgs e);

        [Category("Configuration"), Browsable(true), Description("Événement associé au bouton effacer")]
        public event EffacerButtonClickHandler BoutonEffacerClick;
        [Category("Configuration"), Browsable(true), Description("Événement associé au bouton entrainer")]
        public event EntrainerButtonClickHandler BoutonEntrainerClick;


        [Category("Configuration")]
        public string Titre
        {
            get
            {
                return grpPremier.Text;
            }
            set
            {
                grpPremier.Text = value;
            }
        }


        [Browsable(false)]
        public ucZoneDessin ZoneDessin
        {
            get
            {
                return ZoneDessin;
            }
            set
            {
                ZoneDessin = value;
            }
        }


        public ucPremierControle()
        {
            InitializeComponent();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
        }
    }
}
