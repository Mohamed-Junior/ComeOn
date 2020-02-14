using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Dal_Salle
    {
        private static SqlCommand MySqlCommand;

        private static DataTable dt = new DataTable();

        static Salles ConvertRowToSalles(DataRow row)
        {

            Salles CurrentSalles = new Salles();

            string Nom = (row["Nom"].ToString().Length != 0) ? row["Nom"].ToString() : "pas de Nom";
            CurrentSalles.PropNom = Nom;

            string Type = (row["Type"].ToString().Length != 0) ? row["Type"].ToString() : "pas de Type";
            CurrentSalles.PropType = Type;


            return CurrentSalles;

        }


        public List<Salles> GetAllSallesList()
        {
            List<Salles> AllSalles = new List<Salles>();

            MySqlCommand = new SqlCommand("select * from [Salles]");

            dt = DBConnection.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                AllSalles.Add(ConvertRowToSalles(row));
            }

            return AllSalles;
        }

        public DataTable GetAllSallesDataTable()
        {
            MySqlCommand = new SqlCommand("select * from [Salles]");

            dt = DBConnection.FunctionToRead(MySqlCommand);

            return dt;
        }


        public Salles GetSalleByNom(string Nom)
        {
            Salles SallesSearched = new Salles();

            MySqlCommand = new SqlCommand("select * from [Salles] where Nom = @Nom");

            MySqlCommand.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nom;

            dt = DBConnection.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                SallesSearched = ConvertRowToSalles(row);
            }

            if (dt.Rows.Count == 0)
                return null;
            else
                return SallesSearched;
        }

        public void AddSalle(Salles newSalle)
        {

            MySqlCommand = new SqlCommand("insert into [Salles]( Nom,Type  )" +
                                         "values ( @Nom,@Type )");

            MySqlCommand.Parameters.Add("@Nom", SqlDbType.VarChar).Value = newSalle.PropNom;
            MySqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = newSalle.PropType;


            DBConnection.FunctionToWrite(MySqlCommand);

        }

        public void DeleteSalle(Salles Dept)
        {
            MySqlCommand = new SqlCommand("delete from [Salles] where Nom= @Nom ");
            MySqlCommand.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Dept.PropNom;
            DBConnection.FunctionToWrite(MySqlCommand);


        }

    }
}
