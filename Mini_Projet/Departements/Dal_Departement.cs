using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Dal_Departement
    {
        private static SqlCommand MySqlCommand;

        private static DataTable dt = new DataTable();

        static Departements ConvertRowToDepartements(DataRow row)
        {

            Departements CurrentDepartements = new Departements();

            string Nom = (row["Nom"].ToString().Length != 0) ? row["Nom"].ToString() : "pas de Nom";
            CurrentDepartements.PropNom = Nom;

            string Code = (row["Code"].ToString().Length != 0) ? row["Code"].ToString() : "pas de Code";
            CurrentDepartements.PropCode =Code;


            return CurrentDepartements;

        }


        public List<Departements> GetAllDepartementsList()
        {
            List<Departements> AllDepartements = new List<Departements>();

            MySqlCommand = new SqlCommand("select * from [Departements]");

            dt = DBConnection.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                AllDepartements.Add(ConvertRowToDepartements(row));
            }

            return AllDepartements;
        }

        public DataTable GetAllDepartementsDataTable()
        {
            MySqlCommand = new SqlCommand("select * from [Departements]");

            dt = DBConnection.FunctionToRead(MySqlCommand);

            return dt;
        }


        public Departements GetDepartementByNom(string Nom)
        {
            Departements DepartementsSearched = new Departements();

            MySqlCommand = new SqlCommand("select * from [Departements] where Nom = @Nom");

            MySqlCommand.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nom;

            dt = DBConnection.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                DepartementsSearched = ConvertRowToDepartements(row);
            }

            if (dt.Rows.Count == 0)
                return null;
            else
                return DepartementsSearched;
        }

        public void AddDepartement(Departements newDepartement)
        {

            MySqlCommand = new SqlCommand("insert into [Departements]( Nom,Code  )" +
                                         "values ( @Nom,@Code )");

            MySqlCommand.Parameters.Add("@Nom", SqlDbType.VarChar).Value = newDepartement.PropNom;
            MySqlCommand.Parameters.Add("@Code", SqlDbType.VarChar).Value = newDepartement.PropCode;


            DBConnection.FunctionToWrite(MySqlCommand);

        }

        public void DeleteDepartement(Departements Dept)
        {
            MySqlCommand = new SqlCommand("delete from [Departements] where Nom= @Nom ");
            MySqlCommand.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Dept.PropNom;
            DBConnection.FunctionToWrite(MySqlCommand);
            
        }

        
    }
}
