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
