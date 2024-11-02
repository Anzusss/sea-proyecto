namespace pruebaaa
{
    partial class FormAulas
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
            dgvAulas = new DataGridView();
            txtNombre = new TextBox();
            label1 = new Label();
            txtCapacidad = new TextBox();
            label2 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            txtId = new TextBox();
            label3 = new Label();
            cmbDisp = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAulas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAulas
            // 
            dgvAulas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAulas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAulas.BorderStyle = BorderStyle.Fixed3D;
            dgvAulas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAulas.Location = new Point(239, 0);
            dgvAulas.MultiSelect = false;
            dgvAulas.Name = "dgvAulas";
            dgvAulas.Size = new Size(474, 411);
            dgvAulas.TabIndex = 0;
            dgvAulas.CellDoubleClick += dgvAulas_CellDoubleClick;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtNombre.Location = new Point(82, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 23);
            txtNombre.TabIndex = 10;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 9;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtCapacidad.Location = new Point(82, 53);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(151, 23);
            txtCapacidad.TabIndex = 12;
            txtCapacidad.TextChanged += txtCapacidad_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 54);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 11;
            label2.Text = "Capacidad:";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnEliminar.Location = new Point(82, 270);
            btnEliminar.MaximumSize = new Size(75, 23);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnModificar.Location = new Point(26, 201);
            btnModificar.MaximumSize = new Size(189, 23);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(189, 23);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAgregar.Location = new Point(26, 163);
            btnAgregar.MaximumSize = new Size(189, 23);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(189, 23);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(50, 124);
            txtId.Name = "txtId";
            txtId.Size = new Size(151, 23);
            txtId.TabIndex = 24;
            txtId.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 84);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 25;
            label3.Text = "Disponible:";
            // 
            // cmbDisp
            // 
            cmbDisp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cmbDisp.FormattingEnabled = true;
            cmbDisp.Location = new Point(82, 84);
            cmbDisp.Name = "cmbDisp";
            cmbDisp.Size = new Size(151, 23);
            cmbDisp.TabIndex = 26;
            cmbDisp.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(cmbDisp);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCapacidad);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 411);
            panel1.TabIndex = 27;
            panel1.Paint += panel1_Paint;
            // 
            // FormAulas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 411);
            Controls.Add(panel1);
            Controls.Add(dgvAulas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAulas";
            Text = "FormAulas";
            ((System.ComponentModel.ISupportInitialize)dgvAulas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAulas;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtCapacidad;
        private Label label2;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtId;
        private Label label3;
        private ComboBox cmbDisp;
        private Panel panel1;
    }
}