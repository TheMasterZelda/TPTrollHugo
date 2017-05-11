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
            this.grpPremier.Location = new System.Drawing.Point(3, 3);
            this.grpPremier.Name = "grpPremier";
            this.grpPremier.Size = new System.Drawing.Size(504, 171);
            this.grpPremier.TabIndex = 0;
            this.grpPremier.TabStop = false;
            this.grpPremier.Text = "Entrainement";
            // 
            // txtValeurEntraine
            // 
            this.txtValeurEntraine.Location = new System.Drawing.Point(339, 27);
            this.txtValeurEntraine.Name = "txtValeurEntraine";
            this.txtValeurEntraine.Size = new System.Drawing.Size(158, 20);
            this.txtValeurEntraine.TabIndex = 3;
            // 
            // btnEntrainement
            // 
            this.btnEntrainement.Location = new System.Drawing.Point(340, 76);
            this.btnEntrainement.Name = "btnEntrainement";
            this.btnEntrainement.Size = new System.Drawing.Size(158, 55);
            this.btnEntrainement.TabIndex = 2;
            this.btnEntrainement.Text = "Entrainement";
            this.btnEntrainement.UseVisualStyleBackColor = true;
            this.btnEntrainement.Click += new System.EventHandler(this.btnEntrainement_Click);
            // 
            // lblValeurEntraine
            // 
            this.lblValeurEntraine.AutoSize = true;
            this.lblValeurEntraine.Location = new System.Drawing.Point(237, 30);
            this.lblValeurEntraine.Name = "lblValeurEntraine";
            this.lblValeurEntraine.Size = new System.Drawing.Size(96, 13);
            this.lblValeurEntraine.TabIndex = 1;
            this.lblValeurEntraine.Text = "Valeur entrainée :  ";
            // 
            // grpDessin
            // 
            this.grpDessin.Controls.Add(this.btnEffacer);
            this.grpDessin.Controls.Add(this.ucDessin);
            this.grpDessin.Location = new System.Drawing.Point(21, 30);
            this.grpDessin.Name = "grpDessin";
            this.grpDessin.Size = new System.Drawing.Size(184, 118);
            this.grpDessin.TabIndex = 0;
            this.grpDessin.TabStop = false;
            this.grpDessin.Text = "Zone de dessin";
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(89, 19);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer.TabIndex = 1;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // ucDessin
            // 
            this.ucDessin.BackColor = System.Drawing.Color.White;
            this.ucDessin.Location = new System.Drawing.Point(6, 19);
            this.ucDessin.Name = "ucDessin";
            this.ucDessin.Size = new System.Drawing.Size(64, 64);
            this.ucDessin.TabIndex = 0;
            // 
            // ucPremierControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpPremier);
            this.Name = "ucPremierControle";
            this.Size = new System.Drawing.Size(526, 192);
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
