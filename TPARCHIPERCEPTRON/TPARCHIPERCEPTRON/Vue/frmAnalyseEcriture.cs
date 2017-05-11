using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using TPARCHIPERCEPTRON.Vue;

namespace TPARCHIPERCEPTRON
{
    /// <summary>
    /// Permet d'afficher l'interface pour la reconnaissance de caractères. 
    /// Cet interface fera appel au Perceptron pour identifier le caractère dessiné.
    /// </summary>
    public partial class frmAnalyseEcriture : Form
    {

        private Metier.GestionClassesPerceptrons _gcpAnalyseEcriture;
        private string _fichier = "";

        private List<ToolStripMenuItem> _langues = new List<ToolStripMenuItem>();
        private bool _changementLangueCourante = false;
        private ToolStripMenuItem _langueCourante = null;

        /// <summary>
        /// Constructeur de la form. Initialise les composants
        /// </summary>
        public frmAnalyseEcriture()
        {
            InitializeComponent();
            _fichier = ConfigurationManager.AppSettings["FichierApp"];
            _gcpAnalyseEcriture = new Metier.GestionClassesPerceptrons();
            ucDeuxiemeControle1.ZoneDessin.Width = CstApplication.TAILLEDESSINX;
            ucDeuxiemeControle1.ZoneDessin.Height = CstApplication.TAILLEDESSINY;
            ucPremierControle1.ZoneDessin.Width = CstApplication.TAILLEDESSINX;
            ucPremierControle1.ZoneDessin.Height = CstApplication.TAILLEDESSINY;
            _gcpAnalyseEcriture.ChargerCoordonnees(_fichier);
        }

        /// <summary>
        /// Lors de la fermeture de la form, enregistré les données des perceptrons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAnalyseEcriture_FormClosing(object sender, FormClosingEventArgs e)
        {
            _gcpAnalyseEcriture.SauvegarderCoordonnees(_fichier);
        }

        /// <summary>
        /// Appel le perceptron pour vérifier quel neuronne identifie le mieux le caractère dessiné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucDeuxiemeControle1_BoutonOKClick(object sender, EventArgs e)
        {
            ucDeuxiemeControle1.ResultText = _gcpAnalyseEcriture.TesterPerceptron(ucDeuxiemeControle1.ZoneDessin.Coordonnees);
            //txtConsole.Text = txtValeurTestee.Text;
        }

        /// <summary>
        /// Efface le caractère dessiné et sa matrice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucPremierControle1_BoutonEffacerClick(object sender, EventArgs e)
        {
            ucPremierControle1.ZoneDessin.EffacerDessin();
        }

        /// <summary>
        /// Entraine le bon Perceptron avec la valeur entrée dans le textBox txtValeurEntrainee et le caractère dessiné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucPremierControle1_BoutonEntrainerClick(object sender, EventArgs e)
        {
           // if (txtValeurEntrainee.Text == "")
           //     MessageBox.Show("Vous devez entrer au moins une valeur à faire apprendre.");
           // else
           // {
           //     txtConsole.Text = _gcpAnalyseEcriture.Entrainement(ucDessin.Coordonnees, txtValeurEntrainee.Text);
           //     //ucDessin.EffacerDessin();
           // }
        }

        private void langueToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem != _langueCourante)
            {
                SwitchLanguage(e.ClickedItem);
            }
        }

        private void SwitchLanguage(ToolStripItem tsi)
        {
            if (!_changementLangueCourante)
            {
                _changementLangueCourante = true;
                _langues[_langues.IndexOf(_langueCourante)].Checked = false;

                _langues[_langues.IndexOf((ToolStripMenuItem)tsi)].Checked = true;
                _langueCourante = (ToolStripMenuItem)tsi;

                CultureInfo c = (CultureInfo)tsi.Tag;

                Thread.CurrentThread.CurrentUICulture = c;
                Thread.CurrentThread.CurrentCulture = c;
                ComponentResourceManager res = new ComponentResourceManager(typeof(frmAnalyseEcriture));
                res.ApplyResources(this, "$this", c);
                foreach (ToolStripMenuItem i in menuPrincipal.Items)
                    res.ApplyResources(i, i.Name, c);

                foreach (Control con in this.Controls)
                    ChangerLangue(con, c, res);
                _changementLangueCourante = false;
            }
        }

        private void ChangerLangue(Control con, CultureInfo cul, ComponentResourceManager res)
        {
            if (con.Name == ucPremierControle1.Name)
                res = new ComponentResourceManager(typeof(ucPremierControle));
            if (con.Name == ucDeuxiemeControle1.Name)
                res = new ComponentResourceManager(typeof(ucDeuxiemeControle));
            res.ApplyResources(con, con.Name, cul);
            foreach (Control con2 in con.Controls)
            {
                ChangerLangue(con2, cul, res);
            }
        }

        private void frmAnalyseEcriture_Load(object sender, EventArgs e)
        {
            AjouterLangue(CultureInfo.GetCultureInfo("fr"));
            AjouterLangue(CultureInfo.GetCultureInfo("en"));
            _langues[0].Checked = true;
            _langueCourante = _langues[0];
            SwitchLanguage(_langueCourante);
        }
        private void AjouterLangue(CultureInfo culture)
        {
            ToolStripMenuItem itemMenu = new ToolStripMenuItem(culture.NativeName)
            {
                Tag = culture
            };
            tsmiLangue.DropDownItems.Add(itemMenu);
            _langues.Add(itemMenu);
        }
    }
}
