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
    public partial class Salle : MetroFramework.Forms.MetroForm
    {
        public Salle()
        {
            InitializeComponent();
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Ajouter_Salle AjoutSalle = new Ajouter_Salle();
            AjoutSalle.ShowDialog();
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            Modifier_Salle ModifierSalle = new Modifier_Salle();
            if (ModifierSalle.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
