using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace sgi_app.infrastructure.mysql
{
    public class DbConnection
    {
        private static DbConnection _instance;
        private static readonly object _lock = new object();
        private MySqlConnection conex;

        private string cadenaConexion = "server=localhost;port=3306;user id=root;password=root;database=sgi-db;";

        private DbConnection()
        {
            conex = new MySqlConnection(cadenaConexion);
        }

        public static DbConnection GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DbConnection();
                    }
                }
            }
            return _instance;
        }

        public MySqlConnection EstablecerConexion()
        {
            if (conex.State != System.Data.ConnectionState.Open)
            {
                conex.Open();
                Console.WriteLine("Conexión realizada");
            }
            return conex;
        }

        public void CerrarConexion()
        {
            if (conex.State != System.Data.ConnectionState.Closed)
            {
                conex.Close();
            }
        }
    }
}
