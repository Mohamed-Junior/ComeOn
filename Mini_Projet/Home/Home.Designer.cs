namespace Mini_Projet
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_Surveillance = new MetroFramework.Controls.MetroTile();
            this.Btn_Config = new MetroFramework.Controls.MetroTile();
            this.Btn_Enseignant = new MetroFramework.Controls.MetroTile();
            this.Btn_Seance = new MetroFramework.Controls.MetroTile();
            this.Btn_Salle = new MetroFramework.Controls.MetroTile();
            this.Btn_Departement = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // Btn_Surveillance
            // 
            this.Btn_Surveillance.ActiveControl = null;
            this.Btn_Surveillance.Location = new System.Drawing.Point(23, 117);
            this.Btn_Surveillance.Name = "Btn_Surveillance";
            this.Btn_Surveillance.Size = new System.Drawing.Size(233, 129);
            this.Btn_Surveillance.TabIndex = 13;
            this.Btn_Surveillance.Text = "Surveillances";
            this.Btn_Surveillance.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Surveillance.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.Btn_Surveillance.UseSelectable = true;
            this.Btn_Surveillance.UseTileImage = true;
            this.Btn_Surveillance.Click += new System.EventHandler(this.Btn_Surveillance_Click);
            // 
            // Btn_Config
            // 
            this.Btn_Config.ActiveControl = null;
            this.Btn_Config.Location = new System.Drawing.Point(23, 371);
            this.Btn_Config.Name = "Btn_Config";
            this.Btn_Config.Size = new System.Drawing.Size(233, 118);
            this.Btn_Config.TabIndex = 14;
            this.Btn_Config.Text = "Configurations";
            this.Btn_Config.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Config.UseSelectable = true;
            this.Btn_Config.UseTileImage = true;
            this.Btn_Config.Click += new System.EventHandler(this.Btn_Config_Click);
            // 
            // Btn_Enseignant
            // 
            this.Btn_Enseignant.ActiveControl = null;
            this.Btn_Enseignant.Location = new System.Drawing.Point(328, 115);
            this.Btn_Enseignant.Name = "Btn_Enseignant";
            this.Btn_Enseignant.Size = new System.Drawing.Size(313, 125);
            this.Btn_Enseignant.TabIndex = 15;
            this.Btn_Enseignant.Text = "Enseignants";
            this.Btn_Enseignant.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Enseignant.UseSelectable = true;
            this.Btn_Enseignant.UseTileImage = true;
            this.Btn_Enseignant.Click += new System.EventHandler(this.Btn_Enseignant_Click);
            // 
            // Btn_Seance
            // 
            this.Btn_Seance.ActiveControl = null;
            this.Btn_Seance.Location = new System.Drawing.Point(328, 246);
            this.Btn_Seance.Name = "Btn_Seance";
            this.Btn_Seance.Size = new System.Drawing.Size(149, 118);
            this.Btn_Seance.TabIndex = 16;
            this.Btn_Seance.Text = "Séances";
            this.Btn_Seance.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Seance.UseSelectable = true;
            this.Btn_Seance.UseTileImage = true;
            this.Btn_Seance.Click += new System.EventHandler(this.Btn_Seance_Click);
            // 
            // Btn_Salle
            // 
            this.Btn_Salle.ActiveControl = null;
            this.Btn_Salle.Location = new System.Drawing.Point(492, 246);
            this.Btn_Salle.Name = "Btn_Salle";
            this.Btn_Salle.Size = new System.Drawing.Size(149, 118);
            this.Btn_Salle.TabIndex = 17;
            this.Btn_Salle.Text = "Salles";
            this.Btn_Salle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Salle.UseSelectable = true;
            this.Btn_Salle.UseTileImage = true;
            this.Btn_Salle.Click += new System.EventHandler(this.Btn_Salle_Click);
            // 
            // Btn_Departement
            // 
            this.Btn_Departement.ActiveControl = null;
            this.Btn_Departement.Location = new System.Drawing.Point(328, 370);
            this.Btn_Departement.Name = "Btn_Departement";
            this.Btn_Departement.Size = new System.Drawing.Size(313, 119);
            this.Btn_Departement.TabIndex = 18;
            this.Btn_Departement.Text = "Départements";
            this.Btn_Departement.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Departement.UseSelectable = true;
            this.Btn_Departement.UseTileImage = true;
            this.Btn_Departement.Click += new System.EventHandler(this.Btn_Departement_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(328, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Paramètres";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(152, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Gestion des surveillances";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 345);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Configurations  ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 526);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Btn_Departement);
            this.Controls.Add(this.Btn_Salle);
            this.Controls.Add(this.Btn_Seance);
            this.Controls.Add(this.Btn_Enseignant);
            this.Controls.Add(this.Btn_Config);
            this.Controls.Add(this.Btn_Surveillance);
            this.Name = "Home";
            this.Text = "Accueil";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private MetroFramework.Controls.MetroTile Btn_Surveillance;
        private MetroFramework.Controls.MetroTile Btn_Config;
        private MetroFramework.Controls.MetroTile Btn_Enseignant;
        private MetroFramework.Controls.MetroTile Btn_Seance;
        private MetroFramework.Controls.MetroTile Btn_Salle;
        private MetroFramework.Controls.MetroTile Btn_Departement;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}



