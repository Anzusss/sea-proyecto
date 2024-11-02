using pruebaaa.Clases;

namespace pruebaaa
{
    public partial class SEA : Form
    {
        public SEA()
        {
            InitializeComponent();
            Clases.Cconexion objConex = new Cconexion();
            objConex.establecerConexion();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiantes estd = new Estudiantes();
            MostrarFormularioEnPanel(estd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MostrarFormularioEnPanel(Form formHijo)
        {
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.None;

            panel1.Controls.Clear(); // Limpia controles anteriores
            panel1.Controls.Add(formHijo);

            // Centra el formulario en el panel
            formHijo.Location = new Point(
                (panel1.Width - formHijo.Width) / 2,
                (panel1.Height - formHijo.Height) / 2
            );

            formHijo.Show();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            panel1.Resize += panel1_Resize;
        }
        private void panel1_Resize(object sender, EventArgs e)
        {
            if (panel1.Controls.Count > 0)
            {
                Form formHijo = panel1.Controls[0] as Form;
                if (formHijo != null)
                {
                    formHijo.Location = new Point(
                        (panel1.Width - formHijo.Width) / 2,
                        (panel1.Height - formHijo.Height) / 2
                    );
                }
            }
        }
    }
}
