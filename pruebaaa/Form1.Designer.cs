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
            panel1 = new Panel();
            btnMaterias = new Button();
            SuspendLayout();
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEstudiantes.Location = new Point(8, 9);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(159, 30);
            btnEstudiantes.TabIndex = 0;
            btnEstudiantes.Text = "Estudiantes";
            btnEstudiantes.UseVisualStyleBackColor = true;
            btnEstudiantes.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(173, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 682);
            panel1.TabIndex = 5;
            // 
            // btnMaterias
            // 
            btnMaterias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaterias.Location = new Point(8, 45);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(159, 30);
            btnMaterias.TabIndex = 0;
            btnMaterias.Text = "Materias";
            btnMaterias.UseVisualStyleBackColor = true;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // SEA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnMaterias);
            Controls.Add(panel1);
            Controls.Add(btnEstudiantes);
            MinimumSize = new Size(1280, 720);
            Name = "SEA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "S.E.A";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEstudiantes;
        private Panel panel1;
        private Button btnMaterias;
    }
}
