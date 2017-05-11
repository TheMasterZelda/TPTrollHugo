using System;
using System.Configuration;
using System.Windows.Forms;

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
    }
}
