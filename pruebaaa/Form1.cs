using pruebaaa.Clases;

namespace pruebaaa
{
    public partial class SEA : Form
    {
        public SEA()
        {
            InitializeComponent();
        }

        private void MostrarFormularioEnPanel(Form formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
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
            MostrarFormularioEnPanel(new Estudiantes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new formMaterias());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnProf_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new FormProfesores());
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new FormAulas());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(new Horarios());
        }

        private void SEA_Load(object sender, EventArgs e)
        {

        }
    }
}
