//using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp.Database
{
    public partial class Database
    {
        //public void InsertUser(User user)
        //{
        //    using (OracleConnection connection = Connection)
        //    {
        //        string Insert = "INSERT INTO USER (ID, Naam, Email, Functie, Adres, Postcode) VALUES (seq_Medewerker_ID.nextval, :NAAM, :EMAIL, :FUNCTIE, :ADRES, :POSTCODE)";
        //        using (OracleCommand command = new OracleCommand(Insert, connection))
        //        {
        //            command.Parameters.Add(new OracleParameter("NAAM", user.Naam));
        //            command.Parameters.Add(new OracleParameter("EMAIL", user.Email));
        //            command.Parameters.Add(new OracleParameter("FUNCTIE", user.Functie));
        //            command.Parameters.Add(new OracleParameter("ADRES", user.Adres));
        //            command.Parameters.Add(new OracleParameter("POSTCODE", user.Postcode));
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}