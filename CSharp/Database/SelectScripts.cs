using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp.Database
{
    public partial class Database
    {
        //public List<User> GetAllUsers()
        //{
        //    List<User> Users = new List<User>();
        //    using (OracleConnection connection = Connection)
        //    {
        //        string query = "SELECT * FROM USER Order by Id";
        //        using (OracleCommand command = new OracleCommand(query, connection))
        //        {
        //            using (OracleDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Users.Add(CreateUserFromReader(reader));
        //                }
        //            }
        //        }
        //    }
        //    return Users;
        //}
    }
}