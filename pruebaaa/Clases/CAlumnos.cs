using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaaa.Clases
{
    internal class Cdatos
    {
        private Cconexion conexion;

        public Cdatos()
        {
            conexion = new Cconexion();
        }

        public List<string> ObtenerDatosDeTabla(string estudiantes)
        {
            List<string> datos = new List<string>();
            MySqlConnection conex = null;

            try
            {
                conex = conexion.establecerConexion();
                string query = "SELECT nombre, apellido, cedula FROM estudiantes;";
                MySqlCommand cmd = new MySqlCommand(query, conex);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        string cedula = reader["cedula"].ToString();

                        datos.Add($"{nombre} {apellido} - {cedula}");
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Error al obtener datos: {e.Message}");
            }
            finally
            {
                if (conex != null && conex.State == ConnectionState.Open)
                {
                    conex.Close();
                }
            }

            return datos;
        }

        public DataRow ObtenerDatosCompletos(string cedula)
        {
            DataTable dt = new DataTable();

            using(MySqlConnection conex = conexion.establecerConexion())
            {
                string query = "SELECT * FROM estudiantes WHERE cedula = @cedula";
                MySqlCommand cmd = new MySqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@cedula", cedula);

                try
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch(MySqlException e)
                {
                    MessageBox.Show($"Error al obtener datos completos: {e.Message}");
                    return null;
                }
            }
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public bool ExisteEstudiante(string cedula)
        {
            using (MySqlConnection conex = conexion.establecerConexion())
            {
                string query = "SELECT COUNT(*) FROM estudiantes WHERE cedula = @cedula";
                MySqlCommand cmd = new MySqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@cedula", cedula);

                try
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (MySqlException e)
                {
                    MessageBox.Show($"Error al verificar estudiante: {e.Message}");
                    return false;
                }
            }
        }

        public List<string> ObtenerValoresSexo()
        {
            List<string> valores = new List<string>();
            try
            {
                using (MySqlConnection conexion = new Cconexion().establecerConexion())
                {
                    string query = "SHOW COLUMNS FROM estudiantes WHERE Field = 'sexo'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string enumString = reader["Type"].ToString();
                                enumString = enumString.Substring(5, enumString.Length - 6);
                                valores = enumString.Split(',')
                                                  .Select(v => v.Trim('\''))
                                                  .ToList();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al obtener valores de sexo: " + ex.Message);
            }
            return valores;
        }
    }
}