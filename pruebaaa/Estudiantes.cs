using MySql.Data.MySqlClient;
using pruebaaa.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pruebaaa
{
    public partial class Estudiantes : Form
    {
        private Cdatos datos;

        public Estudiantes()
        {
            InitializeComponent();
            datos = new Cdatos();
            CargarSexoEnComboBox();
        }
        private void Estudiantes_Load(object sender, EventArgs e)
        {
            
            string estudiantes = "estudiantes";

            // Llamamos al método para obtener datos
            var listaDatos = datos.ObtenerDatosDeTabla(estudiantes);

            // Asignamos la lista de datos al ComboBox
            cmbEstudiantes.DataSource = listaDatos;

            CargarSexoEnComboBox();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = new Cconexion().establecerConexion())
                {
                    string itemSeleccionado = cmbEstudiantes.SelectedItem.ToString();
                    string cedula = itemSeleccionado.Split('-')[1].Trim();

                    string consulta = "SELECT * FROM estudiantes WHERE cedula = @cedula";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@cedula", cedula);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            DataRow datosEstudiante = dt.Rows[0];

                            // Aquí tu código para llenar los campos
                            if (dt.Columns.Contains("matricula"))
                                lblMatricula.Text = datosEstudiante["matricula"].ToString();
                            if (dt.Columns.Contains("nombre"))
                                txtNombre.Text = datosEstudiante["nombre"].ToString();
                            if (dt.Columns.Contains("apellido"))
                                txtApellido.Text = datosEstudiante["apellido"].ToString();
                            if (dt.Columns.Contains("cedula"))
                                txtCedula.Text = datosEstudiante["cedula"].ToString();
                            if (dt.Columns.Contains("email"))
                                txtEmail.Text = datosEstudiante["email"].ToString();
                            if (dt.Columns.Contains("telefono"))
                                txtTlf.Text = datosEstudiante["telefono"].ToString();
                            if (dt.Columns.Contains("sexo"))
                            {
                                string sexo = datosEstudiante["sexo"].ToString();
                                int index = cmbSexo.FindStringExact(sexo);
                                if (index != -1)
                                {
                                    cmbSexo.SelectedIndex = index;
                                }
                                else
                                {
                                    // Si no se encuentra el valor exacto, intenta buscar sin distinguir mayúsculas/minúsculas
                                    index = cmbSexo.FindString(sexo);
                                    if (index != -1)
                                    {
                                        cmbSexo.SelectedIndex = index;
                                    }
                                    else
                                    {
                                        // Si aún no se encuentra, puedes manejarlo como prefieras
                                        // Por ejemplo, seleccionar el primer ítem o dejar sin selección
                                        cmbSexo.SelectedIndex = -1;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void CargarSexoEnComboBox()
        {
            Cdatos datos = new Cdatos();
            List<string> valoresSexo = datos.ObtenerValoresSexo();

            cmbSexo.Items.Clear();
            cmbSexo.Items.AddRange(valoresSexo.ToArray());
        }
    }
}
