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
    public partial class Seance : MetroFramework.Forms.MetroForm
    {
        public Seance()
        {
            InitializeComponent();
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Ajouter_Seance AjoutSeance = new Ajouter_Seance();
            AjoutSeance.ShowDialog();
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            Modifier_Seance ModifierSeance = new Modifier_Seance();
            if (ModifierSeance.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
