namespace TPARCHIPERCEPTRON.Vue
{
    partial class ucPremierControle
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPremierControle));
            this.grpPremier = new System.Windows.Forms.GroupBox();
            this.txtValeurEntraine = new System.Windows.Forms.TextBox();
            this.btnEntrainement = new System.Windows.Forms.Button();
            this.lblValeurEntraine = new System.Windows.Forms.Label();
            this.grpDessin = new System.Windows.Forms.GroupBox();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.ucDessin = new TPARCHIPERCEPTRON.ucZoneDessin();
            this.grpPremier.SuspendLayout();
            this.grpDessin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPremier
            // 
            this.grpPremier.Controls.Add(this.txtValeurEntraine);
            this.grpPremier.Controls.Add(this.btnEntrainement);
            this.grpPremier.Controls.Add(this.lblValeurEntraine);
            this.grpPremier.Controls.Add(this.grpDessin);
            resources.ApplyResources(this.grpPremier, "grpPremier");
            this.grpPremier.Name = "grpPremier";
            this.grpPremier.TabStop = false;
            // 
            // txtValeurEntraine
            // 
            resources.ApplyResources(this.txtValeurEntraine, "txtValeurEntraine");
            this.txtValeurEntraine.Name = "txtValeurEntraine";
            // 
            // btnEntrainement
            // 
            resources.ApplyResources(this.btnEntrainement, "btnEntrainement");
            this.btnEntrainement.Name = "btnEntrainement";
            this.btnEntrainement.UseVisualStyleBackColor = true;
            this.btnEntrainement.Click += new System.EventHandler(this.btnEntrainement_Click);
            // 
            // lblValeurEntraine
            // 
            resources.ApplyResources(this.lblValeurEntraine, "lblValeurEntraine");
            this.lblValeurEntraine.Name = "lblValeurEntraine";
            // 
            // grpDessin
            // 
            this.grpDessin.Controls.Add(this.btnEffacer);
            this.grpDessin.Controls.Add(this.ucDessin);
            resources.ApplyResources(this.grpDessin, "grpDessin");
            this.grpDessin.Name = "grpDessin";
            this.grpDessin.TabStop = false;
            // 
            // btnEffacer
            // 
            resources.ApplyResources(this.btnEffacer, "btnEffacer");
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // ucDessin
            // 
            this.ucDessin.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucDessin, "ucDessin");
            this.ucDessin.Name = "ucDessin";
            // 
            // ucPremierControle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpPremier);
            this.Name = "ucPremierControle";
            this.grpPremier.ResumeLayout(false);
            this.grpPremier.PerformLayout();
            this.grpDessin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPremier;
        private System.Windows.Forms.TextBox txtValeurEntraine;
        private System.Windows.Forms.Button btnEntrainement;
        private System.Windows.Forms.Label lblValeurEntraine;
        private System.Windows.Forms.GroupBox grpDessin;
        private System.Windows.Forms.Button btnEffacer;
        private ucZoneDessin ucDessin;
    }
}
