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
    /// Auteur :        David Fournier-Leduc
    /// Description :   Deuxieme controle utilisateur qui gère les tests
    /// Date :          Avant la remise
    /// </summary>
    [Designer(typeof(DesignerDeuxiemeControle))]
    [Docking(DockingBehavior.Ask)]
    public partial class ucDeuxiemeControle : UserControl
    {
        //Déclaration des délégués.
        public delegate void OKButtonClickHandler(object sender, EventArgs e);
        [Category("Configuration"), Description("Événement associé")]
        public event OKButtonClickHandler BoutonOKClick;
        private string _fichierEntrainement;
        private bool _modePhrase;
        private double _cstApprentissage;

        [Category("Configuration"), Description("Titre de la zone de dessin")]
        public string TextGrpDessin
        {
            get { return grpDessin.Text; }
            set { grpDessin.Text = value; }
        }

        [Category("Configuration"), Description("Texte Result")]
        public string ResultText
        {
            get { return txtResult.Text; }
            set { txtResult.Text = value; }
        }

        [Category("Configuration"), Description("Fichier entrainement")]
        public string FichierEntrainement
        {
            get { return _fichierEntrainement; }
            set { _fichierEntrainement = value; }
        }

        [Category("Configuration"), Description("Mode Phrase")]
        public bool ModePhrase
        {
            get { return _modePhrase; }
            set { _modePhrase = value; }
        }

        [Category("Configuration"), Description("Constante d'apprentissage")]
        public double CstApprentissage
        {
            get { return _cstApprentissage; }
            set { _cstApprentissage = value; }
        }

        [Browsable(false)]
        public ucZoneDessin ZoneDessin
        {
            get { return ucZoneDessin; }
        }

        public ucDeuxiemeControle()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OnOKButtonClick(e);
        }
        private void OnOKButtonClick(EventArgs e)
        {
            if (BoutonOKClick != null)
                BoutonOKClick(this, e);
        }
    }
}
