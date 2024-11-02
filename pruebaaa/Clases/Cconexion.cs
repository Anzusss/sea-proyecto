using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaaa.Clases
{
    internal class Cconexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "pruebaconn";
        static string user = "root";
        static string pssw = "";
        static string port = "3306";

        string cadenaconexion = "server=" + servidor + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + pssw + ";" + "database=" + bd + ";";
    
        public MySqlConnection establecerConexion()
        {
            try { 
                conex.ConnectionString = cadenaconexion;
                conex.Open();
                //MessageBox.Show("Se conecto correctamente a la bd");
            }
            catch(MySqlException e) {
                MessageBox.Show("No se pudo conextar a la bd, error: " +e.ToString());
            }

            return conex;
        }

        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
