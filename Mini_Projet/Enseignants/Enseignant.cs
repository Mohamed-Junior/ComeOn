using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Projet
{
    public partial class Enseignant : MetroFramework.Forms.MetroForm
    {
        private Dal_Enseignant DAL_Enseignant;
        private int childFormNumber = 0;

        public Enseignant()
        {
            InitializeComponent();
            DAL_Enseignant = new Dal_Enseignant();
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

        private void Btn_Importer_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog Ofd = new OpenFileDialog() { Filter = "PDF document (*.pdf)|*.pdf", ValidateNames = true, Multiselect = false }) 
            {
                if (Ofd.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = Ofd.FileName;

                 /*   //Read the contents of the file into a stream
                    var fileStream = Ofd.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    */
                }
            }
             
            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {

            Ajouter_Enseignant AjoutE = new Ajouter_Enseignant();
            AjoutE.ShowDialog();
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            Modifier_Enseigant ModifierE = new Modifier_Enseigant();
            if (ModifierE.ShowDialog() == DialogResult.OK)
            {
                 
            }
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            DataRowView currentDataRowView = (DataRowView)Dgv_Enseignant.CurrentRow.DataBoundItem;
            //DAL_Enseignant.DeleteEnseignant(DAL_Enseignant.GetEnseignantByNom(currentDataRowView.Row[1].ToString()));
            Dgv_Enseignant.DataSource = DAL_Enseignant.GetAllEnseignantsDataTable();
            if (DAL_Enseignant.GetAllEnseignantsDataTable().Rows.Count == 0)
            {

                Btn_Supprimer.Enabled = false;
                Btn_Modifier.Enabled = false;

            }
            MessageBox.Show("Suppression réuissie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
