using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject.DbContext
{
    public static class Connection
    {
        private static string connectionString = "mongodb://localhost:27017";

        public static MongoDatabaseBase CreateConnection()
        {
            var connection = new MongoClient(connectionString);

            var dataBase = connection.GetDatabase("local");

            return (MongoDatabaseBase)dataBase;
        }
    }
}
