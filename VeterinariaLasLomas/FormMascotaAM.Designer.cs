namespace VeterinariaLasLomas
{
    partial class FormMascotaAM
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
            lblDueno = new Label();
            cmbDueno = new ComboBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEspecie = new Label();
            txtEspecie = new TextBox();
            txtRaza = new TextBox();
            lblRaza = new Label();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            btnCancelar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblDueno
            // 
            lblDueno.AutoSize = true;
            lblDueno.Location = new Point(29, 21);
            lblDueno.Name = "lblDueno";
            lblDueno.Size = new Size(53, 20);
            lblDueno.TabIndex = 0;
            lblDueno.Text = "Dueño";
            // 
            // cmbDueno
            // 
            cmbDueno.FormattingEnabled = true;
            cmbDueno.Location = new Point(189, 18);
            cmbDueno.Name = "cmbDueno";
            cmbDueno.Size = new Size(250, 28);
            cmbDueno.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(29, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(189, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(27, 126);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(59, 20);
            lblEspecie.TabIndex = 4;
            lblEspecie.Text = "Especie";
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(189, 123);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(250, 27);
            txtEspecie.TabIndex = 5;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(189, 180);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(250, 27);
            txtRaza.TabIndex = 6;
            // 
            // lblRaza
            // 
            lblRaza.AutoSize = true;
            lblRaza.Location = new Point(32, 183);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(41, 20);
            lblRaza.TabIndex = 7;
            lblRaza.Text = "Raza";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(12, 236);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(146, 20);
            lblFechaNacimiento.TabIndex = 8;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(189, 231);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 27);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(252, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(127, 312);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormMascotaAM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 370);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblRaza);
            Controls.Add(txtRaza);
            Controls.Add(txtEspecie);
            Controls.Add(lblEspecie);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(cmbDueno);
            Controls.Add(lblDueno);
            Name = "FormMascotaAM";
            Text = "Nueva Mascota :)";
            Load += FormMascotaAM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDueno;
        private ComboBox cmbDueno;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEspecie;
        private TextBox txtEspecie;
        private TextBox txtRaza;
        private Label lblRaza;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}