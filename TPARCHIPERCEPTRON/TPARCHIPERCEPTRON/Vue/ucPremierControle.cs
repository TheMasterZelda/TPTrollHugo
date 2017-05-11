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
        private string _NomFichierEntrainement;
        private string _EmplacementFichierEntrainement;
        private bool _NouveauFichier;
        private double _ConstanteApprentissage;

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

        [Category("Configuration")]
        public string NomFichierEntrainement
        {
            get
            {
                return _NomFichierEntrainement;
            }
            set
            {
                _NomFichierEntrainement = value;
            }
        }

        [Category("Configuration")]
        public string EmplacementFichierEntrainement
        {
            get
            {
                return _EmplacementFichierEntrainement;
            }
            set
            {
                _EmplacementFichierEntrainement = value;
            }
        }

        [Category("Configuration")]
        public bool NouveauFichier
        {
            get
            {
                return _NouveauFichier;
            }
            set
            {
                _NouveauFichier = value;
            }
        }

        [Category("Configuration")]
        public double ConstanteApprentissage
        {
            get
            {
                return _ConstanteApprentissage;
            }
            set
            {
                _ConstanteApprentissage = value;
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
        /// <summary>
        /// Événement du bouton effacer du controle utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            OnEffacerClick(e);
        }

        private void OnEffacerClick(EventArgs e)
        {
            BoutonEffacerClick(this, e);
        }
        /// <summary>
        /// Événement du bouton entrainer du controle utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrainement_Click(object sender, EventArgs e)
        {
            OnEntrainerClick(e);
        }

        private void OnEntrainerClick(EventArgs e)
        {
            BoutonEntrainerClick(this, e);
        }
    }
}
