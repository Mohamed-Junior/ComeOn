using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Dal_Surveillance
    {

        private SqlCommand MySqlCommand;

        private DataTable dt = new DataTable();

        private DBConnection MyDbConnection = new DBConnection();

        public Surveillances ConvertRowToSurveillances(DataRow row)
        {
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

            return CurrentSurveillances;

        }

        public DataTable PropAllSurveillances()
        {
            MySqlCommand = new SqlCommand("select Su.Id,SU.IdEnseignant, Su.CodeSeances, SU.NomSalle, Su.DateSurveillance, E.Nom as NomEns, E.Prenom as PrenomEns, E.Email, E.Statut, E.CodeDep, D.Nom as NomDep, Se.Nom as NomSeance, Se.HeureDebut, Se.HeureFin, Sa.Type From Surveillances as Su, Salles as Sa, Seances as Se, Enseignants as E, Departements as D where Su.NomSalle = Sa.Nom and Su.CodeSeances = Se.Code and Su.IdEnseignant = E.Id and E.CodeDep = D.Code;");

            dt = DBConnection.FunctionToRead(MySqlCommand);

            return dt;
        }

        public DataTable GetSurveillancesByEnseignant(int IdEns)
        {
            MySqlCommand = new SqlCommand("select Su.Id,SU.IdEnseignant, Su.CodeSeances, SU.NomSalle, Su.DateSurveillance, E.Nom as NomEns, E.Prenom as PrenomEns, E.Email, E.Statut, E.CodeDep, D.Nom as NomDep, Se.Nom as NomSeance, Se.HeureDebut, Se.HeureFin, Sa.Type From Surveillances as Su, Salles as Sa, Seances as Se, Enseignants as E, Departements as D where IdEnseignant = @IdEns and Su.NomSalle = Sa.Nom and Su.CodeSeances = Se.Code and Su.IdEnseignant = E.Id and E.CodeDep = D.Code;");

            MySqlCommand.Parameters.Add("@IdEns", SqlDbType.Int).Value = IdEns;

            dt = DBConnection.FunctionToRead(MySqlCommand);

            return dt;
        }
        
        public int AddSurveillances(Surveillances newSurveillances)
        {

            MySqlCommand = new SqlCommand("insert into Surveillance (IdEnseignant, CodeSeance, NomSalle, HeureDebut, HeureFin, DateSurveillance)" +
                                          "values (@IdEnseignant, @CodeSeance, @NomSalle, @HeureDebut, @HeureFin, @DateSurveillance)");

            MySqlCommand.Parameters.Add("@IdEnseignant", SqlDbType.Int).Value = newSurveillances.PropEnseignant.PropId;

            MySqlCommand.Parameters.Add("@CodeSeance", SqlDbType.VarChar).Value = newSurveillances.PropSeance.PropCode;

            MySqlCommand.Parameters.Add("@NomSalle", SqlDbType.VarChar).Value = newSurveillances.PropSalle.PropNom;

            MySqlCommand.Parameters.Add("@HeureDebut", SqlDbType.VarChar).Value = newSurveillances.PropSeance.PropHeureDebut;

            MySqlCommand.Parameters.Add("@HeureFin", SqlDbType.Int).Value = newSurveillances.PropSeance.PropHeureFin;

            MySqlCommand.Parameters.Add("@DateSurveillance", SqlDbType.DateTime).Value = (newSurveillances.PropDateSurveillance != null) ? newSurveillances.PropDateSurveillance : Convert.DBNull;
            
            return DBConnection.FunctionToWrite(MySqlCommand);


        }

        public int UpdateSurveillances(string IdEnseignant, Surveillances newSurveillances)
        {

            
            MySqlCommand = new SqlCommand("update Surveillance set IdEnseignant = @IdEnseignant, CodeSeance = @CodeSeance, NomSalle = @NomSalle, " +
                                          "HeureDebut = @HeureDebut, DateSurveillance = @DateSurveillance, HeureFin = @HeureFin  where Id = @OldId");

            MySqlCommand.Parameters.Add("@OldId", SqlDbType.Int).Value = newSurveillances.PropId;

            MySqlCommand.Parameters.Add("@IdEnseignant", SqlDbType.Int).Value = newSurveillances.PropEnseignant.PropId;

            MySqlCommand.Parameters.Add("@CodeSeance", SqlDbType.VarChar).Value = newSurveillances.PropSeance.PropCode;

            MySqlCommand.Parameters.Add("@NomSalle", SqlDbType.VarChar).Value = newSurveillances.PropSalle.PropNom;

            MySqlCommand.Parameters.Add("@HeureDebut", SqlDbType.VarChar).Value = newSurveillances.PropSeance.PropHeureDebut;

            MySqlCommand.Parameters.Add("@DateSurveillance", SqlDbType.DateTime).Value = (newSurveillances.PropDateSurveillance != null) ? newSurveillances.PropDateSurveillance : Convert.DBNull;
            
            MySqlCommand.Parameters.Add("@HeureFin", SqlDbType.Int).Value = newSurveillances.PropSeance.PropHeureFin;


            return DBConnection.FunctionToWrite(MySqlCommand);

        }

        public int DeleteSurveillances(int IdSurv)
        {

            MySqlCommand = new SqlCommand("delete from Surveillance where Id = @IdSurv");

            MySqlCommand.Parameters.Add("@IdSurv", SqlDbType.Int).Value = IdSurv;

            return DBConnection.FunctionToWrite(MySqlCommand);

        }
    }
}
