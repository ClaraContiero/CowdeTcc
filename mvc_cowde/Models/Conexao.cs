using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace mvc_cowde.Models
{
    public class Conexao
    {
        public static MySqlConnection getConexao()
        {
            return new MySqlConnection(
                Configuration().GetConnectionString("Default"));
        }

        private static IConfigurationRoot Configuration()
        {
            IConfigurationBuilder builder =
                new ConfigurationBuilder().SetBasePath(
                    Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            return builder.Build();
        }
    }
}
