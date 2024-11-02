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
            btnAgregar = new Button();
            btnModificar = new Button();
            txtId = new TextBox();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 236);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 276);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(152, 196);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 2;
            label3.Text = "Matricula:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(166, 356);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 3;
            label4.Text = "Cedula:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(175, 396);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(156, 436);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 5;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(178, 316);
            label7.Name = "label7";
            label7.Size = new Size(39, 17);
            label7.TabIndex = 6;
            label7.Text = "Sexo:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtNombre.Location = new Point(223, 236);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 23);
            txtNombre.TabIndex = 8;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtApellido.Location = new Point(223, 276);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(151, 23);
            txtApellido.TabIndex = 9;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtCedula
            // 
            txtCedula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtCedula.Location = new Point(223, 356);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(151, 23);
            txtCedula.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtEmail.Location = new Point(223, 396);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(151, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtTlf
            // 
            txtTlf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtTlf.Location = new Point(223, 436);
            txtTlf.Name = "txtTlf";
            txtTlf.Size = new Size(151, 23);
            txtTlf.TabIndex = 13;
            // 
            // cmbEstudiantes
            // 
            cmbEstudiantes.Anchor = AnchorStyles.Top;
            cmbEstudiantes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbEstudiantes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbEstudiantes.FormattingEnabled = true;
            cmbEstudiantes.Location = new Point(95, 12);
            cmbEstudiantes.Name = "cmbEstudiantes";
            cmbEstudiantes.Size = new Size(372, 23);
            cmbEstudiantes.TabIndex = 14;
            cmbEstudiantes.SelectedIndexChanged += cmbEstudiantes_SelectedIndexChanged;
            cmbEstudiantes.TextChanged += cmbEstudiantes_TextChanged;
            // 
            // lblMatricula
            // 
            lblMatricula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatricula.Location = new Point(255, 196);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(26, 17);
            lblMatricula.TabIndex = 15;
            lblMatricula.Text = "ola";
            // 
            // cmbSexo
            // 
            cmbSexo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(222, 316);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(152, 23);
            cmbSexo.TabIndex = 16;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(476, 519);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom;
            btnModificar.Location = new Point(253, 519);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Window;
            txtId.Location = new Point(257, 166);
            txtId.Name = "txtId";
            txtId.Size = new Size(85, 23);
            txtId.TabIndex = 19;
            txtId.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Location = new Point(12, 519);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Estudiantes
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(572, 554);
            Controls.Add(btnEliminar);
            Controls.Add(txtId);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
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
        private Button btnAgregar;
        private Button btnModificar;
        private TextBox txtId;
        private Button btnEliminar;
    }
}