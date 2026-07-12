namespace VeterinariaLasLomas
{
    partial class FormEspecialidades
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
            txtNombreEsp = new TextBox();
            btnAgregar = new Button();
            dgvEspecialidades = new DataGridView();
            btnRenombrar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            lblEspecialidad = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            SuspendLayout();
            // 
            // txtNombreEsp
            // 
            txtNombreEsp.Location = new Point(34, 30);
            txtNombreEsp.Name = "txtNombreEsp";
            txtNombreEsp.Size = new Size(246, 23);
            txtNombreEsp.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(290, 22);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 31);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.AllowUserToAddRows = false;
            dgvEspecialidades.AllowUserToDeleteRows = false;
            dgvEspecialidades.AllowUserToResizeRows = false;
            dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Location = new Point(34, 77);
            dgvEspecialidades.MultiSelect = false;
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidades.Size = new Size(375, 150);
            dgvEspecialidades.TabIndex = 2;
            // 
            // btnRenombrar
            // 
            btnRenombrar.Location = new Point(34, 255);
            btnRenombrar.Name = "btnRenombrar";
            btnRenombrar.Size = new Size(119, 31);
            btnRenombrar.TabIndex = 3;
            btnRenombrar.Text = "Renombrar";
            btnRenombrar.UseVisualStyleBackColor = true;
            btnRenombrar.Click += btnRenombrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(161, 255);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 31);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(290, 299);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(119, 36);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(34, 9);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(72, 15);
            lblEspecialidad.TabIndex = 6;
            lblEspecialidad.Text = "Especialidad";
            // 
            // FormEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 360);
            Controls.Add(lblEspecialidad);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnRenombrar);
            Controls.Add(dgvEspecialidades);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombreEsp);
            Name = "FormEspecialidades";
            Text = "FormEspecialidades";
            Load += FormEspecialidades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreEsp;
        private Button btnAgregar;
        private DataGridView dgvEspecialidades;
        private Button btnRenombrar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label lblEspecialidad;
    }
}