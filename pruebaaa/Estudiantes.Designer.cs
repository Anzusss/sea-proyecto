namespace pruebaaa
{
    partial class Estudiantes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCedula = new TextBox();
            txtEmail = new TextBox();
            txtTlf = new TextBox();
            cmbEstudiantes = new ComboBox();
            lblMatricula = new Label();
            cmbSexo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 377);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(366, 417);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(360, 337);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 2;
            label3.Text = "Matricula:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(374, 497);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 3;
            label4.Text = "Cedula:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(383, 537);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(364, 577);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 5;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(386, 457);
            label7.Name = "label7";
            label7.Size = new Size(39, 17);
            label7.TabIndex = 6;
            label7.Text = "Sexo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(431, 377);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(431, 417);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(151, 23);
            txtApellido.TabIndex = 9;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(431, 497);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(151, 23);
            txtCedula.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(431, 537);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(151, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtTlf
            // 
            txtTlf.Location = new Point(431, 577);
            txtTlf.Name = "txtTlf";
            txtTlf.Size = new Size(151, 23);
            txtTlf.TabIndex = 13;
            // 
            // cmbEstudiantes
            // 
            cmbEstudiantes.FormattingEnabled = true;
            cmbEstudiantes.Location = new Point(318, 22);
            cmbEstudiantes.Name = "cmbEstudiantes";
            cmbEstudiantes.Size = new Size(347, 23);
            cmbEstudiantes.TabIndex = 14;
            cmbEstudiantes.SelectedIndexChanged += cmbEstudiantes_SelectedIndexChanged;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatricula.Location = new Point(430, 337);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(0, 17);
            lblMatricula.TabIndex = 15;
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(430, 457);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(152, 23);
            cmbSexo.TabIndex = 16;
            // 
            // Estudiantes
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1024, 720);
            Controls.Add(cmbSexo);
            Controls.Add(lblMatricula);
            Controls.Add(cmbEstudiantes);
            Controls.Add(txtTlf);
            Controls.Add(txtEmail);
            Controls.Add(txtCedula);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Estudiantes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            Load += Estudiantes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCedula;
        private TextBox txtEmail;
        private TextBox txtTlf;
        private ComboBox cmbEstudiantes;
        private Label lblMatricula;
        private ComboBox cmbSexo;
    }
}