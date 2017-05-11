namespace TPARCHIPERCEPTRON
{
    partial class frmAnalyseEcriture
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyseEcriture));
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiLangue = new System.Windows.Forms.ToolStripMenuItem();
            this.ucDeuxiemeControle1 = new TPARCHIPERCEPTRON.Vue.ucDeuxiemeControle();
            this.ucPremierControle1 = new TPARCHIPERCEPTRON.Vue.ucPremierControle();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            resources.ApplyResources(this.txtConsole, "txtConsole");
            this.txtConsole.Name = "txtConsole";
            // 
            // menuPrincipal
            // 
            resources.ApplyResources(this.menuPrincipal, "menuPrincipal");
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLangue});
            this.menuPrincipal.Name = "menuPrincipal";
            // 
            // tsmiLangue
            // 
            resources.ApplyResources(this.tsmiLangue, "tsmiLangue");
            this.tsmiLangue.Name = "tsmiLangue";
            this.tsmiLangue.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.langueToolStripMenuItem_DropDownItemClicked);
            // 
            // ucDeuxiemeControle1
            // 
            resources.ApplyResources(this.ucDeuxiemeControle1, "ucDeuxiemeControle1");
            this.ucDeuxiemeControle1.CstApprentissage = 0.01D;
            this.ucDeuxiemeControle1.FichierEntrainement = "Train.dat";
            this.ucDeuxiemeControle1.ModePhrase = true;
            this.ucDeuxiemeControle1.Name = "ucDeuxiemeControle1";
            this.ucDeuxiemeControle1.ResultText = "";
            this.ucDeuxiemeControle1.TextGrpDessin = "Zone de dessin";
            this.ucDeuxiemeControle1.BoutonOKClick += new TPARCHIPERCEPTRON.Vue.ucDeuxiemeControle.OKButtonClickHandler(this.ucDeuxiemeControle1_BoutonOKClick);
            // 
            // ucPremierControle1
            // 
            resources.ApplyResources(this.ucPremierControle1, "ucPremierControle1");
            this.ucPremierControle1.ConstanteApprentissage = 0D;
            this.ucPremierControle1.EmplacementFichierEntrainement = null;
            this.ucPremierControle1.Name = "ucPremierControle1";
            this.ucPremierControle1.NomFichierEntrainement = null;
            this.ucPremierControle1.NouveauFichier = false;
            this.ucPremierControle1.ResultatEntrainement = "";
            this.ucPremierControle1.Titre = "Entrainement";
            this.ucPremierControle1.BoutonEffacerClick += new TPARCHIPERCEPTRON.Vue.ucPremierControle.EffacerButtonClickHandler(this.ucPremierControle1_BoutonEffacerClick);
            this.ucPremierControle1.BoutonEntrainerClick += new TPARCHIPERCEPTRON.Vue.ucPremierControle.EntrainerButtonClickHandler(this.ucPremierControle1_BoutonEntrainerClick);
            // 
            // frmAnalyseEcriture
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.ucDeuxiemeControle1);
            this.Controls.Add(this.ucPremierControle1);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "frmAnalyseEcriture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnalyseEcriture_FormClosing);
            this.Load += new System.EventHandler(this.frmAnalyseEcriture_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vue.ucPremierControle ucPremierControle1;
        private Vue.ucDeuxiemeControle ucDeuxiemeControle1;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiLangue;
    }
}

