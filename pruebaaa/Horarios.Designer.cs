namespace pruebaaa
{
    partial class Horarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            cmbDiaId = new ComboBox();
            cmbGrupoId = new ComboBox();
            cmbAulasId = new ComboBox();
            cmbProfesorId = new ComboBox();
            cmbMateriasId = new ComboBox();
            label2 = new Label();
            cmbProfesor = new ComboBox();
            txtId = new TextBox();
            label1 = new Label();
            cmbGrupo = new ComboBox();
            btnDel = new Button();
            btnMod = new Button();
            btnAgregar = new Button();
            lblHsalida = new Label();
            lblHentrada = new Label();
            lblDia = new Label();
            lblAula = new Label();
            lblMateria = new Label();
            cmbHoraS = new ComboBox();
            cmbHoraE = new ComboBox();
            cmbDia = new ComboBox();
            cmbAulas = new ComboBox();
            cmbMaterias = new ComboBox();
            panel2 = new Panel();
            dgvHorarios = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbDiaId);
            panel1.Controls.Add(cmbGrupoId);
            panel1.Controls.Add(cmbAulasId);
            panel1.Controls.Add(cmbProfesorId);
            panel1.Controls.Add(cmbMateriasId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbProfesor);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbGrupo);
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnMod);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(lblHsalida);
            panel1.Controls.Add(lblHentrada);
            panel1.Controls.Add(lblDia);
            panel1.Controls.Add(lblAula);
            panel1.Controls.Add(lblMateria);
            panel1.Controls.Add(cmbHoraS);
            panel1.Controls.Add(cmbHoraE);
            panel1.Controls.Add(cmbDia);
            panel1.Controls.Add(cmbAulas);
            panel1.Controls.Add(cmbMaterias);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 56);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // cmbDiaId
            // 
            cmbDiaId.FormattingEnabled = true;
            cmbDiaId.Location = new Point(419, 56);
            cmbDiaId.Name = "cmbDiaId";
            cmbDiaId.Size = new Size(85, 23);
            cmbDiaId.TabIndex = 22;
            // 
            // cmbGrupoId
            // 
            cmbGrupoId.FormattingEnabled = true;
            cmbGrupoId.Location = new Point(320, 56);
            cmbGrupoId.Name = "cmbGrupoId";
            cmbGrupoId.Size = new Size(91, 23);
            cmbGrupoId.TabIndex = 21;
            // 
            // cmbAulasId
            // 
            cmbAulasId.FormattingEnabled = true;
            cmbAulasId.Location = new Point(230, 56);
            cmbAulasId.Name = "cmbAulasId";
            cmbAulasId.Size = new Size(84, 23);
            cmbAulasId.TabIndex = 20;
            // 
            // cmbProfesorId
            // 
            cmbProfesorId.FormattingEnabled = true;
            cmbProfesorId.Location = new Point(121, 56);
            cmbProfesorId.Name = "cmbProfesorId";
            cmbProfesorId.Size = new Size(103, 23);
            cmbProfesorId.TabIndex = 19;
            // 
            // cmbMateriasId
            // 
            cmbMateriasId.FormattingEnabled = true;
            cmbMateriasId.Location = new Point(12, 56);
            cmbMateriasId.Name = "cmbMateriasId";
            cmbMateriasId.Size = new Size(103, 23);
            cmbMateriasId.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 11);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 17;
            label2.Text = "Profesor";
            // 
            // cmbProfesor
            // 
            cmbProfesor.FormattingEnabled = true;
            cmbProfesor.Location = new Point(121, 27);
            cmbProfesor.Name = "cmbProfesor";
            cmbProfesor.Size = new Size(103, 23);
            cmbProfesor.TabIndex = 16;
            cmbProfesor.SelectedIndexChanged += cmbProfesor_SelectedIndexChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(609, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(55, 23);
            txtId.TabIndex = 14;
            txtId.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 11);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 13;
            label1.Text = "Grupo";
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(320, 27);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(91, 23);
            cmbGrupo.TabIndex = 12;
            cmbGrupo.SelectedIndexChanged += cmbGrupo_SelectedIndexChanged;
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDel.Location = new Point(883, 27);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 11;
            btnDel.Text = "Eliminar";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(777, 27);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 23);
            btnMod.TabIndex = 11;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(696, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblHsalida
            // 
            lblHsalida.AutoSize = true;
            lblHsalida.Location = new Point(593, 31);
            lblHsalida.Name = "lblHsalida";
            lblHsalida.Size = new Size(13, 15);
            lblHsalida.TabIndex = 9;
            lblHsalida.Text = "a";
            // 
            // lblHentrada
            // 
            lblHentrada.AutoSize = true;
            lblHentrada.Location = new Point(504, 31);
            lblHentrada.Name = "lblHentrada";
            lblHentrada.Size = new Size(20, 15);
            lblHentrada.TabIndex = 8;
            lblHentrada.Text = "de";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(449, 11);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(24, 15);
            lblDia.TabIndex = 7;
            lblDia.Text = "Dia";
            // 
            // lblAula
            // 
            lblAula.AutoSize = true;
            lblAula.Location = new Point(254, 11);
            lblAula.Name = "lblAula";
            lblAula.Size = new Size(31, 15);
            lblAula.TabIndex = 6;
            lblAula.Text = "Aula";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(38, 11);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(47, 15);
            lblMateria.TabIndex = 5;
            lblMateria.Text = "Materia";
            // 
            // cmbHoraS
            // 
            cmbHoraS.FormattingEnabled = true;
            cmbHoraS.Location = new Point(609, 27);
            cmbHoraS.Name = "cmbHoraS";
            cmbHoraS.Size = new Size(65, 23);
            cmbHoraS.TabIndex = 4;
            cmbHoraS.SelectedIndexChanged += cmbHoraS_SelectedIndexChanged;
            // 
            // cmbHoraE
            // 
            cmbHoraE.FormattingEnabled = true;
            cmbHoraE.Location = new Point(525, 27);
            cmbHoraE.Name = "cmbHoraE";
            cmbHoraE.Size = new Size(65, 23);
            cmbHoraE.TabIndex = 3;
            cmbHoraE.SelectedIndexChanged += cmbHoraE_SelectedIndexChanged;
            // 
            // cmbDia
            // 
            cmbDia.FormattingEnabled = true;
            cmbDia.Location = new Point(419, 27);
            cmbDia.Name = "cmbDia";
            cmbDia.Size = new Size(85, 23);
            cmbDia.TabIndex = 2;
            cmbDia.SelectedIndexChanged += cmbDia_SelectedIndexChanged;
            // 
            // cmbAulas
            // 
            cmbAulas.FormattingEnabled = true;
            cmbAulas.Location = new Point(230, 27);
            cmbAulas.Name = "cmbAulas";
            cmbAulas.Size = new Size(84, 23);
            cmbAulas.TabIndex = 1;
            cmbAulas.SelectedIndexChanged += cmbAulas_SelectedIndexChanged;
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(12, 27);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(103, 23);
            cmbMaterias.TabIndex = 0;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(968, 446);
            panel2.TabIndex = 1;
            // 
            // dgvHorarios
            // 
            dgvHorarios.AllowUserToAddRows = false;
            dgvHorarios.AllowUserToDeleteRows = false;
            dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHorarios.Dock = DockStyle.Fill;
            dgvHorarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvHorarios.Location = new Point(0, 56);
            dgvHorarios.Name = "dgvHorarios";
            dgvHorarios.ReadOnly = true;
            dgvHorarios.Size = new Size(968, 446);
            dgvHorarios.TabIndex = 0;
            dgvHorarios.CellDoubleClick += dgvHorarios_CellDoubleClick;
            // 
            // Horarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 502);
            Controls.Add(dgvHorarios);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Horarios";
            Text = "Horarios";
            Load += Horarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvHorarios;
        private Label lblDia;
        private Label lblAula;
        private Label lblMateria;
        private ComboBox cmbHoraS;
        private ComboBox cmbHoraE;
        private ComboBox cmbDia;
        private ComboBox cmbAulas;
        private ComboBox cmbMaterias;
        private Button btnDel;
        private Button btnMod;
        private Button btnAgregar;
        private Label lblHsalida;
        private Label lblHentrada;
        private Label label1;
        private ComboBox cmbGrupo;
        private TextBox txtId;
        private Label label2;
        private ComboBox cmbProfesor;
        private ComboBox cmbMateriasId;
        private ComboBox cmbDiaId;
        private ComboBox cmbGrupoId;
        private ComboBox cmbAulasId;
        private ComboBox cmbProfesorId;
    }
}