using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp.Database
{
    public partial class Database
    {
        //public void UpdateUser(User user)
        //{
        //    using (OracleConnection connection = Connection)
        //    {

        //        string Update = "UPDATE USER SET STATUSNAAM =:STATUS, LIJN=:LIJNNUMMER, TYPENAAM =:TYPE  WHERE ID =:IDTRAM ";
        //        using (OracleCommand command = new OracleCommand(Update, connection))
        //        {
        //            command.Parameters.Add(new OracleParameter("STATUS", user.Status.Naam));
        //            command.Parameters.Add(new OracleParameter("LIJNNUMMER", user.Lijn));
        //            command.Parameters.Add(new OracleParameter("TYPE", user.Type.Naam));
        //            command.Parameters.Add(new OracleParameter("IDTRAM", user.Id));
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}