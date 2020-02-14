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
    public partial class Surveillance : MetroFramework.Forms.MetroForm 
    {
        private int childFormNumber = 0;


        string ChoiceRecherche = "";
        int CurrentIndex = 0;

        DataTable CurrentDataTableEnseignant = new DataTable();
        DataTable CurrentDataTableProgrammes = new DataTable();

        DataTable CurrentDataTableEnseignantInit = new DataTable();
        DataTable CurrentDataTableProgrammesInit = new DataTable();

        Enseignants CurrentEns = null;

        public Surveillance()
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

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Ajouter_Surveillance AjoutSurv = new Ajouter_Surveillance();
            AjoutSurv.ShowDialog();
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            Modifier_Surveillance ModifierSurv = new Modifier_Surveillance();
            if (ModifierSurv.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Btn_Enregistrer_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {

        }



        private void TmsOptionRecherche_ItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem Obj= (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem Item in TsmOptionRecherche.DropDownItems)
            {
                Item.Checked = false;
            }
            foreach (ToolStripMenuItem Item in TsmRechercheEtat.DropDownItems)
            {
                Item.Checked = false;
            }
            Obj.Checked = true;
            ChoiceRecherche = Obj.Text;
            TxtSearch_value_change(null, null);
        }

        private void TxtSearch_value_change(object sender, EventArgs e)
        {
            List<DataGridViewRow> RowToDelete = new List<DataGridViewRow>();

            if (CurrentDataTableEnseignant != null)
            {
                DtgListeEnseignants.DataSource = Helper.AdaptDataTableEnseignant(CurrentDataTableEnseignantInit);
            }


            if (TsmRechercheNom.Checked)
            {
                if (TxtSearch.Text.Trim().Length != 0)
                {
                    try
                    {
                        DtgListeEnseignants.ClearSelection();
                        foreach (DataGridViewRow row in DtgListeEnseignants.Rows)
                        {
                            if (row.Cells[1].Value != null && !row.Cells[1].Value.ToString().ToLower().Contains(TxtSearch.Text.Trim().ToLower()))
                            {
                                RowToDelete.Add(row);
                            }
                        }

                        foreach (DataGridViewRow CurrentRow in RowToDelete)
                        {
                            DtgListeEnseignants.Rows.Remove(CurrentRow);
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Ce Nom n'existe pas, SVP essayer encore. " + exc.StackTrace);
                    }
                }
            }
            else if (TsmRechercheEnCour.Checked)
            {
                try
                {
                    DtgListeEnseignants.ClearSelection();
                    foreach (DataGridViewRow row in DtgListeEnseignants.Rows)
                    {
                        if (row.Cells[3].Value != null && !row.Cells[3].Value.ToString().ToLower().Contains("en cour"))
                        {
                            RowToDelete.Add(row);
                        }
                    }

                    foreach (DataGridViewRow CurrentRow in RowToDelete)
                    {
                        DtgListeEnseignants.Rows.Remove(CurrentRow);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erreur , SVP essayer encore. " + exc.StackTrace);
                }
            }
            else if (TsmRechercheTermine.Checked)
            {
                try
                {
                    DtgListeEnseignants.ClearSelection();
                    foreach (DataGridViewRow row in DtgListeEnseignants.Rows)
                    {
                        if (row.Cells[3].Value != null && !row.Cells[3].Value.ToString().ToLower().Contains("termine"))
                        {
                            RowToDelete.Add(row);
                        }
                    }

                    foreach (DataGridViewRow CurrentRow in RowToDelete)
                    {
                        DtgListeEnseignants.Rows.Remove(CurrentRow);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erreur , SVP essayer encore. " + exc.StackTrace);
                }
            }
            else if(TsmRechercheDepartement.Checked)
            {

                if (TxtSearch.Text.Trim().Length != 0)
                {
                    try
                    {
                        DtgListeEnseignants.ClearSelection();
                        foreach (DataGridViewRow row in DtgListeEnseignants.Rows)
                        {
                            if (row.Cells[2].Value != null && !row.Cells[2].Value.ToString().ToLower().Contains(TxtSearch.Text.Trim().ToLower()))
                            {
                                RowToDelete.Add(row);
                            }
                        }

                        foreach (DataGridViewRow CurrentRow in RowToDelete)
                        {
                            DtgListeEnseignants.Rows.Remove(CurrentRow);
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Ce Departement n'existe pas, SVP essayer encore. " + exc.StackTrace);
                    }
                }
            }
        }
        private void Surveillance_Load(object sender, EventArgs e)
        {

            DtgListeEnseignants.DataSource = Helper.InitialiseDataGridEnseignant(CurrentDataTableEnseignant);
            DtgListeProgrames.DataSource = Helper.InitialiseDataGridProgrammes(CurrentDataTableProgrammes);
            FillDtgListeEnseignants();
        }

        public void FillDtgListeEnseignants()
        {
            CurrentDataTableEnseignant = new Dal_Enseignant().GetAllEnseignantsDataTable();
            CurrentDataTableEnseignantInit = CurrentDataTableEnseignant;
            CurrentDataTableEnseignant = Helper.AdaptDataTableEnseignant(CurrentDataTableEnseignant);

            DtgListeEnseignants.DataSource = CurrentDataTableEnseignant;
            ParameterDetail();

        }

        public void ParameterDetail()
        {

            if (DtgListeEnseignants.SelectedCells.Count > 0)
            {
                int IndexRowSelected = DtgListeEnseignants.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = DtgListeEnseignants.Rows[IndexRowSelected];

                if (SelectedRow.Cells["Nom"].Value != null
                    && SelectedRow.Cells["Nom"].Value.ToString().Trim().Length != 0
                    && IndexRowSelected < Helper.AllEnseignants.Count)
                {
                    CurrentIndex = IndexRowSelected;
                    CurrentEns = Helper.AllEnseignants[IndexRowSelected];

                    InitialChamp(CurrentEns);
                }
                else
                {
                    CurrentEns = null;
                    InitialChamp(null);
                }
            }
            else
            {
                CurrentEns = null;
                InitialChamp(null);
            }
        }

        private void InitialChamp(Enseignants CurrentEnseignant)
        {
            if (CurrentEnseignant != null)
            {

                if (CurrentEnseignant.PropNom != null && CurrentEnseignant.PropNom.Trim().Length != 0)
                    LbValueNom.Text = CurrentEnseignant.PropNom + ' ' + CurrentEnseignant.PropPrenom;
                else
                    LbValueNom.Text = "Pas de nom";

                if (CurrentEnseignant.PropDepartements != null && CurrentEnseignant.PropDepartements.PropNom.Trim().Length != 0)
                    LbValueDep.Text = CurrentEnseignant.PropDepartements.PropNom;
                else
                    LbValueDep.Text = "Pas de departement";

                if (CurrentEnseignant.PropStatut.ToLower().Trim().Equals("termine"))
                    CbEtat.SelectedItem = CbEtat.Items[1];
                else
                    CbEtat.SelectedItem = CbEtat.Items[0];

                FillDtgListeProgrames(CurrentEnseignant.PropId);
            }
            else
            {
                LbValueNom.Text = "Pas de nom";
                LbValueDep.Text = "Pas de departement";
                FillDtgListeProgrames(0);
            }
        }


        public void FillDtgListeProgrames(int IdEns)
        {

            CurrentDataTableProgrammes = new Dal_Surveillance().GetSurveillancesByEnseignant(IdEns);
            CurrentDataTableProgrammesInit = CurrentDataTableProgrammes;

            CurrentDataTableProgrammes = Helper.AdaptDataTableProgrammes(CurrentDataTableProgrammes);
            DtgListeProgrames.DataSource = CurrentDataTableProgrammes;
            
        }

        private void DtgListeEns_SelectionChanged(object sender, EventArgs e)
        {
            ParameterDetail();
        }
    }
}
