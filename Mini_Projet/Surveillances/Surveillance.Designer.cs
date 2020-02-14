namespace Mini_Projet
{
    partial class Surveillance
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.impressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoiDuProgrammeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTousLesEnseigantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auxEnseignantsSelectionnésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmOptionRecherche = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmRechercheNom = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmRechercheDepartement = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbValueDep = new System.Windows.Forms.Label();
            this.LbValueNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbProgramme = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbEtat = new System.Windows.Forms.ComboBox();
            this.LbDep = new System.Windows.Forms.Label();
            this.LbNomEns = new System.Windows.Forms.Label();
            this.Btn_Enregistrer = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.DtgListeProgrames = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbListeEns = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DtgListeEnseignants = new System.Windows.Forms.DataGridView();
            this.TsmRechercheEtat = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmRechercheEnCour = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmRechercheTermine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeProgrames)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeEnseignants)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressionToolStripMenuItem,
            this.envoiDuProgrammeToolStripMenuItem,
            this.TsmOptionRecherche});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // impressionToolStripMenuItem
            // 
            this.impressionToolStripMenuItem.Name = "impressionToolStripMenuItem";
            this.impressionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.impressionToolStripMenuItem.Text = "Impression";
            // 
            // envoiDuProgrammeToolStripMenuItem
            // 
            this.envoiDuProgrammeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aTousLesEnseigantsToolStripMenuItem,
            this.auxEnseignantsSelectionnésToolStripMenuItem});
            this.envoiDuProgrammeToolStripMenuItem.Name = "envoiDuProgrammeToolStripMenuItem";
            this.envoiDuProgrammeToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.envoiDuProgrammeToolStripMenuItem.Text = "Envoyer  par email";
            // 
            // aTousLesEnseigantsToolStripMenuItem
            // 
            this.aTousLesEnseigantsToolStripMenuItem.Name = "aTousLesEnseigantsToolStripMenuItem";
            this.aTousLesEnseigantsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.aTousLesEnseigantsToolStripMenuItem.Text = "A tous les enseigants";
            // 
            // auxEnseignantsSelectionnésToolStripMenuItem
            // 
            this.auxEnseignantsSelectionnésToolStripMenuItem.Checked = true;
            this.auxEnseignantsSelectionnésToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.auxEnseignantsSelectionnésToolStripMenuItem.Name = "auxEnseignantsSelectionnésToolStripMenuItem";
            this.auxEnseignantsSelectionnésToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.auxEnseignantsSelectionnésToolStripMenuItem.Text = "Aux enseignants selectionnés";
            // 
            // TsmOptionRecherche
            // 
            this.TsmOptionRecherche.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmRechercheNom,
            this.TsmRechercheDepartement,
            this.TsmRechercheEtat});
            this.TsmOptionRecherche.Name = "TsmOptionRecherche";
            this.TsmOptionRecherche.Size = new System.Drawing.Size(127, 20);
            this.TsmOptionRecherche.Text = "Option de recherche";
            // 
            // TsmRechercheNom
            // 
            this.TsmRechercheNom.Checked = true;
            this.TsmRechercheNom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TsmRechercheNom.Name = "TsmRechercheNom";
            this.TsmRechercheNom.Size = new System.Drawing.Size(220, 22);
            this.TsmRechercheNom.Text = "Recherche par nom";
            this.TsmRechercheNom.Click += new System.EventHandler(this.TmsOptionRecherche_ItemClicked);
            // 
            // TsmRechercheDepartement
            // 
            this.TsmRechercheDepartement.Name = "TsmRechercheDepartement";
            this.TsmRechercheDepartement.Size = new System.Drawing.Size(220, 22);
            this.TsmRechercheDepartement.Text = "Recherche par departement";
            this.TsmRechercheDepartement.Click += new System.EventHandler(this.TmsOptionRecherche_ItemClicked);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(20, 605);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1085, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel.Text = "État";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.ForeColor = System.Drawing.Color.Lime;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 87);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1077, 513);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LbValueDep);
            this.groupBox2.Controls.Add(this.LbValueNom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LbProgramme);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CbEtat);
            this.groupBox2.Controls.Add(this.LbDep);
            this.groupBox2.Controls.Add(this.LbNomEns);
            this.groupBox2.Controls.Add(this.Btn_Enregistrer);
            this.groupBox2.Controls.Add(this.Btn_Supprimer);
            this.groupBox2.Controls.Add(this.Btn_Modifier);
            this.groupBox2.Controls.Add(this.Btn_Ajouter);
            this.groupBox2.Controls.Add(this.DtgListeProgrames);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(435, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 497);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Programmes de surveillance";
            // 
            // LbValueDep
            // 
            this.LbValueDep.AutoSize = true;
            this.LbValueDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValueDep.Location = new System.Drawing.Point(207, 144);
            this.LbValueDep.Name = "LbValueDep";
            this.LbValueDep.Size = new System.Drawing.Size(181, 24);
            this.LbValueDep.TabIndex = 12;
            this.LbValueDep.Text = "Pas de Departement";
            // 
            // LbValueNom
            // 
            this.LbValueNom.AutoSize = true;
            this.LbValueNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValueNom.Location = new System.Drawing.Point(207, 102);
            this.LbValueNom.Name = "LbValueNom";
            this.LbValueNom.Size = new System.Drawing.Size(111, 24);
            this.LbValueNom.TabIndex = 11;
            this.LbValueNom.Text = "Pas de nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // LbProgramme
            // 
            this.LbProgramme.AutoSize = true;
            this.LbProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProgramme.Location = new System.Drawing.Point(67, 32);
            this.LbProgramme.Name = "LbProgramme";
            this.LbProgramme.Size = new System.Drawing.Size(433, 37);
            this.LbProgramme.TabIndex = 9;
            this.LbProgramme.Text = "Programme de l\'enseignant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Etat de finalisation";
            // 
            // CbEtat
            // 
            this.CbEtat.FormattingEnabled = true;
            this.CbEtat.Items.AddRange(new object[] {
            "En cours",
            "Termine"});
            this.CbEtat.Location = new System.Drawing.Point(488, 108);
            this.CbEtat.Name = "CbEtat";
            this.CbEtat.Size = new System.Drawing.Size(136, 24);
            this.CbEtat.TabIndex = 7;
            // 
            // LbDep
            // 
            this.LbDep.AutoSize = true;
            this.LbDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDep.Location = new System.Drawing.Point(6, 144);
            this.LbDep.Name = "LbDep";
            this.LbDep.Size = new System.Drawing.Size(170, 25);
            this.LbDep.TabIndex = 6;
            this.LbDep.Text = "Département        :";
            // 
            // LbNomEns
            // 
            this.LbNomEns.AutoSize = true;
            this.LbNomEns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNomEns.Location = new System.Drawing.Point(6, 101);
            this.LbNomEns.Name = "LbNomEns";
            this.LbNomEns.Size = new System.Drawing.Size(171, 25);
            this.LbNomEns.TabIndex = 5;
            this.LbNomEns.Text = "Nom  Prénom(s)  :";
            // 
            // Btn_Enregistrer
            // 
            this.Btn_Enregistrer.Location = new System.Drawing.Point(488, 424);
            this.Btn_Enregistrer.Name = "Btn_Enregistrer";
            this.Btn_Enregistrer.Size = new System.Drawing.Size(136, 44);
            this.Btn_Enregistrer.TabIndex = 4;
            this.Btn_Enregistrer.Text = "Enregistrer";
            this.Btn_Enregistrer.UseVisualStyleBackColor = true;
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.Location = new System.Drawing.Point(488, 348);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(136, 44);
            this.Btn_Supprimer.TabIndex = 3;
            this.Btn_Supprimer.Text = "Supprimer";
            this.Btn_Supprimer.UseVisualStyleBackColor = true;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Location = new System.Drawing.Point(488, 272);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(136, 44);
            this.Btn_Modifier.TabIndex = 2;
            this.Btn_Modifier.Text = "Modifier";
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Modifier.Click += new System.EventHandler(this.Btn_Modifier_Click);
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(488, 196);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(136, 44);
            this.Btn_Ajouter.TabIndex = 1;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // DtgListeProgrames
            // 
            this.DtgListeProgrames.AllowUserToAddRows = false;
            this.DtgListeProgrames.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DtgListeProgrames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgListeProgrames.Location = new System.Drawing.Point(6, 196);
            this.DtgListeProgrames.Name = "DtgListeProgrames";
            this.DtgListeProgrames.RowHeadersVisible = false;
            this.DtgListeProgrames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgListeProgrames.Size = new System.Drawing.Size(464, 295);
            this.DtgListeProgrames.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbListeEns);
            this.groupBox1.Controls.Add(this.TxtSearch);
            this.groupBox1.Controls.Add(this.DtgListeEnseignants);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 497);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enseignants";
            // 
            // LbListeEns
            // 
            this.LbListeEns.AutoSize = true;
            this.LbListeEns.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbListeEns.Location = new System.Drawing.Point(27, 32);
            this.LbListeEns.Name = "LbListeEns";
            this.LbListeEns.Size = new System.Drawing.Size(346, 37);
            this.LbListeEns.TabIndex = 4;
            this.LbListeEns.Text = "Liste des enseignants";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(51, 85);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(304, 22);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_value_change);
            // 
            // DtgListeEnseignants
            // 
            this.DtgListeEnseignants.AllowUserToAddRows = false;
            this.DtgListeEnseignants.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DtgListeEnseignants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgListeEnseignants.Location = new System.Drawing.Point(7, 113);
            this.DtgListeEnseignants.Name = "DtgListeEnseignants";
            this.DtgListeEnseignants.RowHeadersVisible = false;
            this.DtgListeEnseignants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgListeEnseignants.Size = new System.Drawing.Size(396, 378);
            this.DtgListeEnseignants.TabIndex = 0;
            this.DtgListeEnseignants.SelectionChanged += new System.EventHandler(this.DtgListeEns_SelectionChanged);
            // 
            // TsmRechercheEtat
            // 
            this.TsmRechercheEtat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmRechercheEnCour,
            this.TsmRechercheTermine});
            this.TsmRechercheEtat.Name = "TsmRechercheEtat";
            this.TsmRechercheEtat.Size = new System.Drawing.Size(220, 22);
            this.TsmRechercheEtat.Text = "Recherche par etat";
            this.TsmRechercheEtat.Click += new System.EventHandler(this.TmsOptionRecherche_ItemClicked);
            // 
            // TsmRechercheEnCour
            // 
            this.TsmRechercheEnCour.Name = "TsmRechercheEnCour";
            this.TsmRechercheEnCour.Size = new System.Drawing.Size(180, 22);
            this.TsmRechercheEnCour.Text = "En Cour";
            this.TsmRechercheEnCour.Click += new System.EventHandler(this.TmsOptionRecherche_ItemClicked);
            // 
            // TsmRechercheTermine
            // 
            this.TsmRechercheTermine.Name = "TsmRechercheTermine";
            this.TsmRechercheTermine.Size = new System.Drawing.Size(180, 22);
            this.TsmRechercheTermine.Text = "Termine";
            this.TsmRechercheTermine.Click += new System.EventHandler(this.TmsOptionRecherche_ItemClicked);
            // 
            // Surveillance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 647);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Surveillance";
            this.Text = "Surveillance";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Surveillance_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeProgrames)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeEnseignants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem impressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoiDuProgrammeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTousLesEnseigantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auxEnseignantsSelectionnésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmOptionRecherche;
        private System.Windows.Forms.ToolStripMenuItem TsmRechercheNom;
        private System.Windows.Forms.ToolStripMenuItem TsmRechercheDepartement;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LbProgramme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbEtat;
        private System.Windows.Forms.Label LbDep;
        private System.Windows.Forms.Label LbNomEns;
        private System.Windows.Forms.Button Btn_Enregistrer;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.DataGridView DtgListeProgrames;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbListeEns;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DtgListeEnseignants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbValueDep;
        private System.Windows.Forms.Label LbValueNom;
        private System.Windows.Forms.ToolStripMenuItem TsmRechercheEtat;
        private System.Windows.Forms.ToolStripMenuItem TsmRechercheEnCour;
        private System.Windows.Forms.ToolStripMenuItem TsmRechercheTermine;
    }
}



