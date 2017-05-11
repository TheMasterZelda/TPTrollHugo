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
            this.grpDeuxieme = new System.Windows.Forms.GroupBox();
            this.grpDessin = new System.Windows.Forms.GroupBox();
            this.ucZoneDessin = new TPARCHIPERCEPTRON.ucZoneDessin();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.grpDeuxieme.SuspendLayout();
            this.grpDessin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDeuxieme
            // 
            this.grpDeuxieme.Controls.Add(this.txtText);
            this.grpDeuxieme.Controls.Add(this.btnOK);
            this.grpDeuxieme.Controls.Add(this.grpDessin);
            this.grpDeuxieme.Location = new System.Drawing.Point(3, 3);
            this.grpDeuxieme.Name = "grpDeuxieme";
            this.grpDeuxieme.Size = new System.Drawing.Size(348, 326);
            this.grpDeuxieme.TabIndex = 0;
            this.grpDeuxieme.TabStop = false;
            // 
            // grpDessin
            // 
            this.grpDessin.Controls.Add(this.ucZoneDessin);
            this.grpDessin.Location = new System.Drawing.Point(31, 28);
            this.grpDessin.Name = "grpDessin";
            this.grpDessin.Size = new System.Drawing.Size(109, 134);
            this.grpDessin.TabIndex = 0;
            this.grpDessin.TabStop = false;
            this.grpDessin.Text = "Zone de dessin";
            // 
            // ucZoneDessin
            // 
            this.ucZoneDessin.BackColor = System.Drawing.Color.White;
            this.ucZoneDessin.Location = new System.Drawing.Point(21, 40);
            this.ucZoneDessin.Name = "ucZoneDessin";
            this.ucZoneDessin.Size = new System.Drawing.Size(64, 64);
            this.ucZoneDessin.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(166, 38);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 53);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(31, 185);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(285, 114);
            this.txtText.TabIndex = 2;
            // 
            // ucDeuxiemeControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpDeuxieme);
            this.Name = "ucDeuxiemeControle";
            this.Size = new System.Drawing.Size(357, 331);
            this.grpDeuxieme.ResumeLayout(false);
            this.grpDeuxieme.PerformLayout();
            this.grpDessin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDeuxieme;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpDessin;
        private ucZoneDessin ucZoneDessin;
    }
}
