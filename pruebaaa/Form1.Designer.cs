namespace pruebaaa
{
    partial class SEA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEstudiantes = new Button();
            panelContenedor = new Panel();
            btnMaterias = new Button();
            btnProf = new Button();
            btnAulas = new Button();
            btnHorario = new Button();
            SuspendLayout();
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.BackColor = SystemColors.Control;
            btnEstudiantes.FlatStyle = FlatStyle.Popup;
            btnEstudiantes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEstudiantes.Location = new Point(8, 9);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(159, 30);
            btnEstudiantes.TabIndex = 0;
            btnEstudiantes.Text = "Estudiantes";
            btnEstudiantes.UseVisualStyleBackColor = false;
            btnEstudiantes.Click += button1_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenedor.BackColor = SystemColors.Control;
            panelContenedor.BorderStyle = BorderStyle.Fixed3D;
            panelContenedor.Location = new Point(173, -1);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1103, 662);
            panelContenedor.TabIndex = 5;
            panelContenedor.Paint += panel1_Paint;
            // 
            // btnMaterias
            // 
            btnMaterias.BackColor = SystemColors.Control;
            btnMaterias.FlatStyle = FlatStyle.Popup;
            btnMaterias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaterias.Location = new Point(8, 81);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(159, 30);
            btnMaterias.TabIndex = 0;
            btnMaterias.Text = "Materias";
            btnMaterias.UseVisualStyleBackColor = false;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // btnProf
            // 
            btnProf.BackColor = SystemColors.Control;
            btnProf.FlatStyle = FlatStyle.Popup;
            btnProf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProf.Location = new Point(8, 45);
            btnProf.Name = "btnProf";
            btnProf.Size = new Size(159, 30);
            btnProf.TabIndex = 6;
            btnProf.Text = "Profesores";
            btnProf.UseVisualStyleBackColor = false;
            btnProf.Click += btnProf_Click;
            // 
            // btnAulas
            // 
            btnAulas.BackColor = SystemColors.Control;
            btnAulas.FlatStyle = FlatStyle.Popup;
            btnAulas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAulas.Location = new Point(8, 117);
            btnAulas.Name = "btnAulas";
            btnAulas.Size = new Size(159, 30);
            btnAulas.TabIndex = 7;
            btnAulas.Text = "Aulas";
            btnAulas.UseVisualStyleBackColor = false;
            btnAulas.Click += btnAulas_Click;
            // 
            // btnHorario
            // 
            btnHorario.BackColor = SystemColors.Control;
            btnHorario.FlatStyle = FlatStyle.Popup;
            btnHorario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHorario.Location = new Point(8, 153);
            btnHorario.Name = "btnHorario";
            btnHorario.Size = new Size(159, 30);
            btnHorario.TabIndex = 8;
            btnHorario.Text = "Horarios";
            btnHorario.UseVisualStyleBackColor = false;
            btnHorario.Click += btnHorario_Click;
            // 
            // SEA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1264, 661);
            Controls.Add(btnHorario);
            Controls.Add(btnProf);
            Controls.Add(btnAulas);
            Controls.Add(btnMaterias);
            Controls.Add(panelContenedor);
            Controls.Add(btnEstudiantes);
            MinimumSize = new Size(1170, 700);
            Name = "SEA";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "S.E.A";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEstudiantes;
        private Panel panelContenedor;
        private Button btnMaterias;
        private Button btnProf;
        private Button btnAulas;
        private Button btnHorario;
    }
}
