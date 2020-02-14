using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Helper
    {

        public static List<Enseignants> AllEnseignants = null;
        public static List<Surveillances> AllSurveillance = null;

        public static DataTable InitialiseDataGridEnseignant(DataTable CurrentDataTableEnseignant)
        {

            DataColumn ColumnLigneFacture = new DataColumn();

            ColumnLigneFacture = new DataColumn();
            ColumnLigneFacture.DataType = System.Type.GetType("System.Boolean");
            ColumnLigneFacture.ColumnName = "Selectionner";
            ColumnLigneFacture.ReadOnly = false;
            ColumnLigneFacture.Unique = false;
            // Add the Column to the DataColumnCollection.
            CurrentDataTableEnseignant.Columns.Add(ColumnLigneFacture);

            ColumnLigneFacture = new DataColumn();
            ColumnLigneFacture.DataType = System.Type.GetType("System.String");
            ColumnLigneFacture.ColumnName = "Nom";
            ColumnLigneFacture.ReadOnly = true;
            ColumnLigneFacture.Unique = false;
            // Add the Column to the DataColumnCollection.
            CurrentDataTableEnseignant.Columns.Add(ColumnLigneFacture);

            ColumnLigneFacture = new DataColumn();
            ColumnLigneFacture.DataType = System.Type.GetType("System.String");
            ColumnLigneFacture.ColumnName = "Departement";
            ColumnLigneFacture.ReadOnly = true;
            ColumnLigneFacture.Unique = false;
            // Add the Column to the DataColumnCollection.
            CurrentDataTableEnseignant.Columns.Add(ColumnLigneFacture);

            ColumnLigneFacture = new DataColumn();
            ColumnLigneFacture.DataType = System.Type.GetType("System.String");
            ColumnLigneFacture.ColumnName = "Etat";
            ColumnLigneFacture.ReadOnly = true;
            ColumnLigneFacture.Unique = false;
            // Add the Column to the DataColumnCollection.
            CurrentDataTableEnseignant.Columns.Add(ColumnLigneFacture);

            return CurrentDataTableEnseignant;


        }

        public static DataTable InitialiseDataGridProgrammes(DataTable CurrentDataTableEnseignant)
        {

            DataColumn ColumnLigneFacture = new DataColumn();
            

            ColumnLigneFacture = new DataColumn();
            ColumnLigneFacture.DataType = System.Type.GetType("System.String");
            ColumnLigneFacture.ColumnName = "Nom Salle";
            ColumnLigneFacture.ReadOnly = true;
            ColumnLigneFacture.Unique = false;
            // Add the Column to the DataColumnCollection.
            CurrentDataTableEnseignant.Columns.Add(ColumnLigneFacture);

            ColumnLigneFacture = new DataColumn();
            ColumnLigneFacture.DataType = System.Type.GetType("System.String");
            ColumnLigneFacture.ColumnName = "Nom Seance";
            ColumnLigneFacture.ReadOnly = true;
            ColumnLigneFacture.Unique = false;
            // Add the Column to the DataColumnCollection.
            CurrentDataTableEnseignant.Columns.Add(ColumnLigneFacture);

            ColumnLigneFacture = new DataColumn();
            ColumnLigneFacture.DataType = System.Type.GetType("System.String");
            ColumnLigneFacture.ColumnName = "Heure Debut";
            ColumnLigneFacture.ReadOnly = true;
            ColumnLigneFacture.Unique = false;
            // Add the Column to the DataColumnCollection.
            CurrentDataTableEnseignant.Columns.Add(ColumnLigneFacture);

            ColumnLigneFacture = new DataColumn();
            ColumnLigneFacture.DataType = System.Type.GetType("System.String");
            ColumnLigneFacture.ColumnName = "Heure Fin";
            ColumnLigneFacture.ReadOnly = true;
            ColumnLigneFacture.Unique = false;
            // Add the Column to the DataColumnCollection.
            CurrentDataTableEnseignant.Columns.Add(ColumnLigneFacture);

            ColumnLigneFacture = new DataColumn();
            ColumnLigneFacture.DataType = System.Type.GetType("System.DateTime");
            ColumnLigneFacture.ColumnName = "Date Surveillance";
            ColumnLigneFacture.ReadOnly = true;
            ColumnLigneFacture.Unique = false;
            // Add the Column to the DataColumnCollection.

            CurrentDataTableEnseignant.Columns.Add(ColumnLigneFacture);

            return CurrentDataTableEnseignant;


        }

        public static DataTable AdaptDataTableEnseignant(DataTable CurrentDataTable)
        {

            AllEnseignants = new List<Enseignants>();

            DataTable Datatable = new DataTable();
            Datatable = InitialiseDataGridEnseignant(Datatable);

            //Get All The Rows Of The First DataTable
            foreach (DataRow row in CurrentDataTable.Rows)
            {

                Enseignants CurrentEnseignant = new Enseignants();

                int Id = 0;

                try
                {
                    Id = int.Parse(row["Id"].ToString());
                }
                catch (Exception e)
                {
                    Id = 0;
                }
                string Nom = (row["Nom"].ToString().Length != 0) ? row["Nom"].ToString() : "pas de Nom";

                string PreNom = (row["Prenom"].ToString().Length != 0) ? row["Prenom"].ToString() : "pas de PreNom";
                string Email = (row["Email"].ToString().Length != 0) ? row["Email"].ToString() : "pas de Email";
                string Status = (row["Statut"].ToString().Length != 0) ? row["Statut"].ToString() : "pas de Status";

                string CodeDep = row["CodeDep"].ToString();

                if (CodeDep.Length != 0)
                {

                    Departements CurrentDepartements = new Departements();

                    string NomDep = (row["NomDep"].ToString().Length != 0) ? row["NomDep"].ToString() : "pas de Nom de Departement";
                    CurrentDepartements.PropNom = NomDep;
                    CurrentDepartements.PropCode = CodeDep;

                    CurrentEnseignant = new Enseignants(Nom, PreNom, Email, Status, CurrentDepartements);
                    Datatable.Rows.Add(
                        false,
                        Nom + ' ' + PreNom.Split(' ')[0],
                        CurrentDepartements.PropNom,
                        Status
                    );
                }
                else
                {
                    CodeDep = "pas de Departement";
                    CurrentEnseignant = new Enseignants(Nom, PreNom, Email, Status, new Departements("", CodeDep));
                    Datatable.Rows.Add(
                         false,
                         Nom + ' ' + PreNom.Split(' ')[0],
                        "pas de Departement",
                         Status
                     );
                }

                CurrentEnseignant.PropId = Id;
                AllEnseignants.Add(CurrentEnseignant);
            }

            return Datatable;
        }

        public static DataTable AdaptDataTableProgrammes(DataTable CurrentDataTable)
        {

            AllSurveillance = new List<Surveillances>();
        
            DataTable Datatable = new DataTable();

            Datatable = InitialiseDataGridProgrammes(Datatable);

            //Get All The Rows Of The First DataTable
            foreach (DataRow row in CurrentDataTable.Rows)
            {

                Surveillances CurrentSurveillance = new Surveillances();
                int Id = 0;
                try
                {
                    Id = int.Parse(row["Id"].ToString());
                }
                catch (Exception e)
                {
                    Id = 0;
                }
                int IdEnseignant = 0;

                try
                {
                    IdEnseignant = int.Parse(row["IdEnseignant"].ToString());
                }
                catch (Exception e)
                {
                    IdEnseignant = 0;
                }

                string CodeSeance = (row["CodeSeances"].ToString().Length != 0) ? row["CodeSeances"].ToString() : "";
                string NomSalle = (row["NomSalle"].ToString().Length != 0) ? row["NomSalle"].ToString() : "";
                string DateText = (row["DateSurveillance"].ToString().Length >= 8) ? row["DateSurveillance"].ToString() : null;
                DateTime DateSurveillance = DateTime.MinValue;

                if (DateText != null)
                {
                    DateSurveillance = DateTime.Parse(DateText);
                }


                Enseignants CurrentProf = new Enseignants();
                CurrentProf.PropId = IdEnseignant;

                if (IdEnseignant != 0)
                {

                    string NomEns = (row["NomEns"].ToString().Length != 0) ? row["NomEns"].ToString() : "pas de Nom D'enseignant";
                    CurrentProf.PropNom = NomEns;

                    string PrenomEns = (row["PrenomEns"].ToString().Length != 0) ? row["PrenomEns"].ToString() : "pas de Prenom d'enseignant";
                    CurrentProf.PropPrenom = PrenomEns;

                    string Email = (row["Email"].ToString().Length != 0) ? row["Email"].ToString() : "pas d'Email";
                    CurrentProf.PropEmail = Email;

                    string Statut = (row["Statut"].ToString().Length != 0) ? row["Statut"].ToString() : "pas de statut";
                    CurrentProf.PropStatut = Statut;

                    string CodeDep = row["CodeDep"].ToString();
                    if (CodeDep.Length != 0)
                    {

                        Departements CurrentDepartements = new Departements();

                        string NomDep = (row["NomDep"].ToString().Length != 0) ? row["NomDep"].ToString() : "pas de Nom de Departement";
                        CurrentDepartements.PropNom = NomDep;
                        CurrentDepartements.PropCode = CodeDep;

                        CurrentProf.PropDepartements = new Departements(CurrentDepartements);
                    }
                    else
                    {
                        CodeDep = "pas de Departement";
                        CurrentProf.PropDepartements = null;
                    }
                    CurrentProf.PropStatut = Statut;

                }

                Seances CurrentSeance = new Seances();
                CurrentSeance.PropCode = CodeSeance;
                CurrentSeance.PropNom = (row["NomSeance"].ToString().Length != 0) ? row["NomSeance"].ToString() : "pas de Nom de Seance";
                CurrentSeance.PropHeureDebut = (row["HeureDebut"].ToString().Length != 0) ? row["HeureDebut"].ToString() : "pas de HeureDebut";
                CurrentSeance.PropHeureFin = (row["HeureFin"].ToString().Length != 0) ? row["HeureFin"].ToString() : "pas de HeureFin";

                Salles CurrentSalle = new Salles();
                CurrentSalle.PropNom = NomSalle;
                CurrentSalle.PropType = (row["type"].ToString().Length != 0) ? row["type"].ToString() : "pas de type salle";




                Surveillances CurrentSurveillances = new Surveillances(CurrentProf, CurrentSeance, CurrentSalle, DateSurveillance);
                CurrentSurveillances.PropId = Id;

                Datatable.Rows.Add(
                         CurrentSalle.PropNom,
                         CurrentSeance.PropNom,
                         CurrentSeance.PropHeureDebut,
                         CurrentSeance.PropHeureFin,
                         DateSurveillance
                     );

                AllSurveillance.Add(CurrentSurveillances);

            }

            return Datatable;
        }
    }
}
