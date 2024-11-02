namespace pruebaaa
{
    partial class formMaterias
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
            cmbMaterias = new ComboBox();
            txtNombre = new TextBox();
            txtDesc = new TextBox();
            cmbCategorias = new ComboBox();
            btnDel = new Button();
            btnAdd = new Button();
            btnMod = new Button();
            txtId = new TextBox();
            lblMatricula = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbMaterias
            // 
            cmbMaterias.Anchor = AnchorStyles.Top;
            cmbMaterias.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMaterias.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(101, 12);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(347, 23);
            cmbMaterias.TabIndex = 0;
            cmbMaterias.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtNombre.Location = new Point(250, 263);
            txtNombre.MaximumSize = new Size(100, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtDesc
            // 
            txtDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDesc.Location = new Point(199, 391);
            txtDesc.MaximumSize = new Size(199, 23);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(199, 23);
            txtDesc.TabIndex = 4;
            // 
            // cmbCategorias
            // 
            cmbCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(241, 305);
            cmbCategorias.MaximumSize = new Size(121, 0);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(121, 23);
            cmbCategorias.TabIndex = 6;
            cmbCategorias.SelectedIndexChanged += cmbCategorias_SelectedIndexChanged;
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDel.Location = new Point(12, 417);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 7;
            btnDel.Text = "Eliminar";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom;
            btnAdd.Location = new Point(249, 417);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMod
            // 
            btnMod.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMod.Location = new Point(473, 417);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 23);
            btnMod.TabIndex = 9;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(241, 171);
            txtId.Name = "txtId";
            txtId.Size = new Size(121, 23);
            txtId.TabIndex = 10;
            txtId.Visible = false;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // lblMatricula
            // 
            lblMatricula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(259, 223);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(0, 15);
            lblMatricula.TabIndex = 12;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(171, 221);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 15;
            label6.Text = "Matricula:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(114, 391);
            label7.Name = "label7";
            label7.Size = new Size(79, 17);
            label7.TabIndex = 19;
            label7.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(159, 306);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 17;
            label2.Text = "Categoria:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 263);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 16;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // formMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 452);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(lblMatricula);
            Controls.Add(txtId);
            Controls.Add(btnMod);
            Controls.Add(btnAdd);
            Controls.Add(btnDel);
            Controls.Add(cmbCategorias);
            Controls.Add(txtDesc);
            Controls.Add(txtNombre);
            Controls.Add(cmbMaterias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formMaterias";
            Text = "Materias";
            Load += formMaterias_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMaterias;
        private TextBox txtNombre;
        private TextBox txtDesc;
        private ComboBox cmbCategorias;
        private Button btnDel;
        private Button btnAdd;
        private Button btnMod;
        private TextBox txtId;
        private Label lblMatricula;
        private Label label6;
        private Label label7;
        private Label label2;
        private Label label1;
    }
}