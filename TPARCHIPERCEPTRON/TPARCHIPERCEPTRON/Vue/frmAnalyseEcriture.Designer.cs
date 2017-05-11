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
            this.ucPremierControle1 = new TPARCHIPERCEPTRON.Vue.ucPremierControle();
            this.ucDeuxiemeControle1 = new TPARCHIPERCEPTRON.Vue.ucDeuxiemeControle();
            this.SuspendLayout();
            // 
            // ucPremierControle1
            // 
            this.ucPremierControle1.ConstanteApprentissage = 0D;
            this.ucPremierControle1.EmplacementFichierEntrainement = null;
            this.ucPremierControle1.Location = new System.Drawing.Point(12, 12);
            this.ucPremierControle1.Name = "ucPremierControle1";
            this.ucPremierControle1.NomFichierEntrainement = null;
            this.ucPremierControle1.NouveauFichier = false;
            this.ucPremierControle1.Size = new System.Drawing.Size(526, 192);
            this.ucPremierControle1.TabIndex = 0;
            this.ucPremierControle1.Titre = "Entrainement";
            this.ucPremierControle1.BoutonEffacerClick += new TPARCHIPERCEPTRON.Vue.ucPremierControle.EffacerButtonClickHandler(this.ucPremierControle1_BoutonEffacerClick);
            this.ucPremierControle1.BoutonEntrainerClick += new TPARCHIPERCEPTRON.Vue.ucPremierControle.EntrainerButtonClickHandler(this.ucPremierControle1_BoutonEntrainerClick);
            // 
            // ucDeuxiemeControle1
            // 
            this.ucDeuxiemeControle1.CstApprentissage = 0D;
            this.ucDeuxiemeControle1.FichierEntrainement = null;
            this.ucDeuxiemeControle1.Location = new System.Drawing.Point(94, 210);
            this.ucDeuxiemeControle1.ModePhrase = false;
            this.ucDeuxiemeControle1.Name = "ucDeuxiemeControle1";
            this.ucDeuxiemeControle1.ResultText = "";
            this.ucDeuxiemeControle1.Size = new System.Drawing.Size(357, 331);
            this.ucDeuxiemeControle1.TabIndex = 1;
            this.ucDeuxiemeControle1.TextGrpDessin = "Zone de dessin";
            this.ucDeuxiemeControle1.BoutonOKClick += new TPARCHIPERCEPTRON.Vue.ucDeuxiemeControle.OKButtonClickHandler(this.ucDeuxiemeControle1_BoutonOKClick);
            // 
            // frmAnalyseEcriture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 593);
            this.Controls.Add(this.ucDeuxiemeControle1);
            this.Controls.Add(this.ucPremierControle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAnalyseEcriture";
            this.Text = "Analyse Écriture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnalyseEcriture_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Vue.ucPremierControle ucPremierControle1;
        private Vue.ucDeuxiemeControle ucDeuxiemeControle1;
    }
}

