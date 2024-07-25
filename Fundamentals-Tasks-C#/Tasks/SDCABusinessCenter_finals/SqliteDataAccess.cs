using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.Sqlite;
using Dapper;

namespace SDCABusinessCenter_finals
{
    internal class SqliteDataAccess
    {
        
        public static List<PersonModel> Loadpeople()
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("Select * From Student_Informmation_tbl", new DynamicParameters());
                return output.ToList();
            }
        }
        
        public static void SavePerson(PersonModel person)
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                cnn.Execute("",person );
            }
        }
        private static string LoadConnectionString(string id = "Default"){
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
    
}
