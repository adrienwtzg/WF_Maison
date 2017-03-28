namespace WF_Maison
{
    partial class frmMain
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
            this.SuspendLayout();
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 490);
            this.Name = "frmMain";
            this.Text = "Maison";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

    }
}

