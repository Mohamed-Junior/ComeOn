using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Projet
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        private int childFormNumber = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
/*
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        */
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void surveillanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void enseignentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void departementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void séancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Surveillance_Click(object sender, EventArgs e)
        {
            Surveillance SurveillanceView = new Surveillance(); 
            SurveillanceView.ShowDialog();
        }

        private void Btn_Config_Click(object sender, EventArgs e)
        {
            Configuration Config = new Configuration();
            Config.ShowDialog();
        }

        private void Btn_Enseignant_Click(object sender, EventArgs e)
        {
            Enseignant EnseignantView = new Enseignant();
            EnseignantView.ShowDialog();
        }

        private void Btn_Seance_Click(object sender, EventArgs e)
        {
            Seance SeanceView = new Seance();
            SeanceView.ShowDialog();
        }

        private void Btn_Salle_Click(object sender, EventArgs e)
        {
            Salle SalleView = new Salle();
            SalleView.ShowDialog();
        }

        private void Btn_Departement_Click(object sender, EventArgs e)
        {
            Departement DepartementView = new Departement();
            DepartementView.ShowDialog();
        }

        
    }
}
