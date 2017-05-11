namespace TPARCHIPERCEPTRON.Vue
{
    partial class ucDeuxiemeControle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDeuxiemeControle));
            this.grpDeuxieme = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpDessin = new System.Windows.Forms.GroupBox();
            this.ucZoneDessin = new TPARCHIPERCEPTRON.ucZoneDessin();
            this.grpDeuxieme.SuspendLayout();
            this.grpDessin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDeuxieme
            // 
            resources.ApplyResources(this.grpDeuxieme, "grpDeuxieme");
            this.grpDeuxieme.Controls.Add(this.txtResult);
            this.grpDeuxieme.Controls.Add(this.btnOK);
            this.grpDeuxieme.Controls.Add(this.grpDessin);
            this.grpDeuxieme.Name = "grpDeuxieme";
            this.grpDeuxieme.TabStop = false;
            // 
            // txtResult
            // 
            resources.ApplyResources(this.txtResult, "txtResult");
            this.txtResult.Name = "txtResult";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpDessin
            // 
            resources.ApplyResources(this.grpDessin, "grpDessin");
            this.grpDessin.Controls.Add(this.ucZoneDessin);
            this.grpDessin.Name = "grpDessin";
            this.grpDessin.TabStop = false;
            // 
            // ucZoneDessin
            // 
            resources.ApplyResources(this.ucZoneDessin, "ucZoneDessin");
            this.ucZoneDessin.BackColor = System.Drawing.Color.White;
            this.ucZoneDessin.Name = "ucZoneDessin";
            // 
            // ucDeuxiemeControle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpDeuxieme);
            this.Name = "ucDeuxiemeControle";
            this.grpDeuxieme.ResumeLayout(false);
            this.grpDeuxieme.PerformLayout();
            this.grpDessin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDeuxieme;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpDessin;
        private ucZoneDessin ucZoneDessin;
    }
}
