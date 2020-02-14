using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Dal_Seance
    {
        private static SqlCommand MySqlCommand;
         

        private static DataTable dt = new DataTable();

        static Seances ConvertRowToSeances(DataRow row)
        {

            Seances CurrentSeances = new Seances();

            string Nom = (row["Nom"].ToString().Length != 0) ? row["Nom"].ToString() : "pas de Nom";
            CurrentSeances.PropNom = Nom;

            string Code = (row["Code"].ToString().Length != 0) ? row["Code"].ToString() : "pas de Code";
            CurrentSeances.PropNom = Code;

            string HeureD = (row["HeureDebut"].ToString().Length != 0) ? row["HeureDebut"].ToString() : "pas d'heure";
            CurrentSeances.PropHeureDebut = HeureD;

            string HeureF = (row["HeureFin"].ToString().Length != 0) ? row["HeureFin"].ToString() : "pas d'heure";
            CurrentSeances.PropHeureFin= HeureF;


            return CurrentSeances;

        }


        public List<Seances> GetAllSeancesList()
        {
            List<Seances> AllSeances = new List<Seances>();

            MySqlCommand = new SqlCommand("select * from [Seances]");

            dt = DBConnection.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                AllSeances.Add(ConvertRowToSeances(row));
            }

            return AllSeances;
        }

        public DataTable GetAllSeancesDataTable()
        {
            MySqlCommand = new SqlCommand("select * from [Seances]");

            dt = DBConnection.FunctionToRead(MySqlCommand);

            return dt;
        }


        public Seances GetSeanceByNom(string Nom)
        {
            Seances SeancesSearched = new Seances();

            MySqlCommand = new SqlCommand("select * from [Seances] where Nom = @Nom");

            MySqlCommand.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nom;

            dt = DBConnection.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                SeancesSearched = ConvertRowToSeances(row);
            }

            if (dt.Rows.Count == 0)
                return null;
            else
                return SeancesSearched;
        }

        public void AddSeance(Seances newSeance)
        {

            MySqlCommand = new SqlCommand("insert into [Seances]( Nom,Code, HeureDebut, HeureFin  )" +
                                         "values ( @Nom,@Code, @HeureDebut, @HeureFin )");

            MySqlCommand.Parameters.Add("@Nom", SqlDbType.VarChar).Value = newSeance.PropNom;
            MySqlCommand.Parameters.Add("@Code", SqlDbType.VarChar).Value = newSeance.PropCode; 
            MySqlCommand.Parameters.Add("@HeureDebut", SqlDbType.DateTime).Value = newSeance.PropHeureDebut;
            MySqlCommand.Parameters.Add("@HeureFin", SqlDbType.DateTime).Value = newSeance.PropHeureFin;


            DBConnection.FunctionToWrite(MySqlCommand);

        }

        public void DeleteSeance(Seances Seance)
        {
            MySqlCommand = new SqlCommand("delete from [Seances] where Nom= @Nom ");
            MySqlCommand.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Seance.PropNom;
            DBConnection.FunctionToWrite(MySqlCommand);


        }

    }
}
