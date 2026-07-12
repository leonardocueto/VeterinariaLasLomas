namespace VeterinariaLasLomas
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            tabTurnos = new TabPage();
            tabHistorial = new TabPage();
            dgvHistorial = new DataGridView();
            cbMascota = new ComboBox();
            cbDuenio = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            tabClientes = new TabPage();
            btnActualizarClientes = new Button();
            btnModificarCliente = new Button();
            chkActivos = new CheckBox();
            btnBajaCliente = new Button();
            btnNuevoCliente = new Button();
            dgvClientes = new DataGridView();
            tabMascotas = new TabPage();
            cbMascotas = new CheckBox();
            btnModificarMascota = new Button();
            dgvMascotas = new DataGridView();
            btnBajaMascota = new Button();
            btnNuevaMascota = new Button();
            tabVeterinarios = new TabPage();
            tabControl.SuspendLayout();
            tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tabMascotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabTurnos);
            tabControl.Controls.Add(tabHistorial);
            tabControl.Controls.Add(tabClientes);
            tabControl.Controls.Add(tabMascotas);
            tabControl.Controls.Add(tabVeterinarios);
            tabControl.Font = new Font("Segoe UI", 9F);
            tabControl.Location = new Point(6, 3);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(909, 596);
            tabControl.TabIndex = 0;
            // 
            // tabTurnos
            // 
            tabTurnos.Location = new Point(4, 29);
            tabTurnos.Margin = new Padding(3, 4, 3, 4);
            tabTurnos.Name = "tabTurnos";
            tabTurnos.Padding = new Padding(3, 4, 3, 4);
            tabTurnos.Size = new Size(901, 563);
            tabTurnos.TabIndex = 0;
            tabTurnos.Text = "Turnos";
            tabTurnos.UseVisualStyleBackColor = true;
            // 
            // tabHistorial
            // 
            tabHistorial.Controls.Add(dgvHistorial);
            tabHistorial.Controls.Add(cbMascota);
            tabHistorial.Controls.Add(cbDuenio);
            tabHistorial.Controls.Add(label2);
            tabHistorial.Controls.Add(label1);
            tabHistorial.Location = new Point(4, 29);
            tabHistorial.Margin = new Padding(3, 4, 3, 4);
            tabHistorial.Name = "tabHistorial";
            tabHistorial.Padding = new Padding(3, 4, 3, 4);
            tabHistorial.Size = new Size(901, 563);
            tabHistorial.TabIndex = 1;
            tabHistorial.Text = "Historial";
            tabHistorial.UseVisualStyleBackColor = true;
            // 
            // dgvHistorial
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorial.Location = new Point(6, 125);
            dgvHistorial.Name = "dgvHistorial";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(889, 431);
            dgvHistorial.TabIndex = 4;
            // 
            // cbMascota
            // 
            cbMascota.FormattingEnabled = true;
            cbMascota.Location = new Point(548, 62);
            cbMascota.Name = "cbMascota";
            cbMascota.Size = new Size(234, 28);
            cbMascota.TabIndex = 3;
            cbMascota.SelectedIndexChanged += cbMascota_SelectedIndexChanged;
            // 
            // cbDuenio
            // 
            cbDuenio.FormattingEnabled = true;
            cbDuenio.Location = new Point(55, 62);
            cbDuenio.Name = "cbDuenio";
            cbDuenio.Size = new Size(234, 28);
            cbDuenio.TabIndex = 2;
            cbDuenio.SelectedIndexChanged += cbDuenio_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(539, 29);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Mascota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 29);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Dueño";
            // 
            // tabClientes
            // 
            tabClientes.Controls.Add(btnActualizarClientes);
            tabClientes.Controls.Add(btnModificarCliente);
            tabClientes.Controls.Add(chkActivos);
            tabClientes.Controls.Add(btnBajaCliente);
            tabClientes.Controls.Add(btnNuevoCliente);
            tabClientes.Controls.Add(dgvClientes);
            tabClientes.Location = new Point(4, 29);
            tabClientes.Margin = new Padding(3, 4, 3, 4);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(3, 4, 3, 4);
            tabClientes.Size = new Size(901, 563);
            tabClientes.TabIndex = 2;
            tabClientes.Text = "Clientes";
            tabClientes.UseVisualStyleBackColor = true;
            // 
            // btnActualizarClientes
            // 
            btnActualizarClientes.BackColor = Color.Transparent;
            btnActualizarClientes.Cursor = Cursors.Hand;
            btnActualizarClientes.Location = new Point(664, 45);
            btnActualizarClientes.Margin = new Padding(3, 4, 3, 4);
            btnActualizarClientes.Name = "btnActualizarClientes";
            btnActualizarClientes.Size = new Size(109, 37);
            btnActualizarClientes.TabIndex = 5;
            btnActualizarClientes.Text = "Actualizar";
            btnActualizarClientes.UseVisualStyleBackColor = false;
            btnActualizarClientes.Click += btnActualizarClientes_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.BackColor = Color.Transparent;
            btnModificarCliente.Cursor = Cursors.Hand;
            btnModificarCliente.Location = new Point(279, 25);
            btnModificarCliente.Margin = new Padding(3, 4, 3, 4);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(129, 57);
            btnModificarCliente.TabIndex = 4;
            btnModificarCliente.Text = "Modificar cliente";
            btnModificarCliente.UseVisualStyleBackColor = false;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // chkActivos
            // 
            chkActivos.AutoSize = true;
            chkActivos.Checked = true;
            chkActivos.CheckState = CheckState.Checked;
            chkActivos.Cursor = Cursors.Hand;
            chkActivos.Location = new Point(795, 57);
            chkActivos.Margin = new Padding(3, 4, 3, 4);
            chkActivos.Name = "chkActivos";
            chkActivos.Size = new Size(111, 24);
            chkActivos.TabIndex = 3;
            chkActivos.Text = "Solo activos";
            chkActivos.UseVisualStyleBackColor = true;
            chkActivos.CheckedChanged += chkActivos_CheckedChanged;
            // 
            // btnBajaCliente
            // 
            btnBajaCliente.Cursor = Cursors.Hand;
            btnBajaCliente.Location = new Point(143, 25);
            btnBajaCliente.Margin = new Padding(3, 4, 3, 4);
            btnBajaCliente.Name = "btnBajaCliente";
            btnBajaCliente.Size = new Size(129, 57);
            btnBajaCliente.TabIndex = 2;
            btnBajaCliente.Text = "Dar de baja";
            btnBajaCliente.UseVisualStyleBackColor = true;
            btnBajaCliente.Click += btnBajaCliente_Click;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.Transparent;
            btnNuevoCliente.Cursor = Cursors.Hand;
            btnNuevoCliente.Location = new Point(7, 25);
            btnNuevoCliente.Margin = new Padding(3, 4, 3, 4);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(129, 57);
            btnNuevoCliente.TabIndex = 1;
            btnNuevoCliente.Text = "+ Nuevo cliente";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle5;
            dgvClientes.Location = new Point(7, 109);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(889, 425);
            dgvClientes.TabIndex = 0;
            // 
            // tabMascotas
            // 
            tabMascotas.Controls.Add(cbMascotas);
            tabMascotas.Controls.Add(btnModificarMascota);
            tabMascotas.Controls.Add(dgvMascotas);
            tabMascotas.Controls.Add(btnBajaMascota);
            tabMascotas.Controls.Add(btnNuevaMascota);
            tabMascotas.Location = new Point(4, 29);
            tabMascotas.Margin = new Padding(3, 4, 3, 4);
            tabMascotas.Name = "tabMascotas";
            tabMascotas.Padding = new Padding(3, 4, 3, 4);
            tabMascotas.Size = new Size(901, 563);
            tabMascotas.TabIndex = 3;
            tabMascotas.Text = "Mascotas";
            tabMascotas.UseVisualStyleBackColor = true;
            // 
            // cbMascotas
            // 
            cbMascotas.AutoSize = true;
            cbMascotas.Location = new Point(784, 55);
            cbMascotas.Name = "cbMascotas";
            cbMascotas.Size = new Size(111, 24);
            cbMascotas.TabIndex = 4;
            cbMascotas.Text = "Solo activos";
            cbMascotas.UseVisualStyleBackColor = true;
            cbMascotas.CheckedChanged += cbMascotas_CheckedChanged;
            // 
            // btnModificarMascota
            // 
            btnModificarMascota.Location = new Point(383, 41);
            btnModificarMascota.Margin = new Padding(3, 4, 3, 4);
            btnModificarMascota.Name = "btnModificarMascota";
            btnModificarMascota.Size = new Size(191, 51);
            btnModificarMascota.TabIndex = 3;
            btnModificarMascota.Text = "Modificar Mascota";
            btnModificarMascota.UseVisualStyleBackColor = true;
            btnModificarMascota.Click += btnModificarMascota_Click;
            // 
            // dgvMascotas
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvMascotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvMascotas.DefaultCellStyle = dataGridViewCellStyle8;
            dgvMascotas.Location = new Point(15, 117);
            dgvMascotas.Name = "dgvMascotas";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvMascotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvMascotas.RowHeadersWidth = 51;
            dgvMascotas.Size = new Size(877, 437);
            dgvMascotas.TabIndex = 2;
            dgvMascotas.CellContentClick += dgvMascotas_CellContentClick;
            // 
            // btnBajaMascota
            // 
            btnBajaMascota.Location = new Point(207, 41);
            btnBajaMascota.Name = "btnBajaMascota";
            btnBajaMascota.Size = new Size(170, 51);
            btnBajaMascota.TabIndex = 1;
            btnBajaMascota.Text = "Dar de baja";
            btnBajaMascota.UseVisualStyleBackColor = true;
            btnBajaMascota.Click += btnBajaMascota_Click;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(15, 41);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(186, 51);
            btnNuevaMascota.TabIndex = 0;
            btnNuevaMascota.Text = "+ Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // tabVeterinarios
            // 
            tabVeterinarios.Location = new Point(4, 29);
            tabVeterinarios.Margin = new Padding(3, 4, 3, 4);
            tabVeterinarios.Name = "tabVeterinarios";
            tabVeterinarios.Padding = new Padding(3, 4, 3, 4);
            tabVeterinarios.Size = new Size(901, 563);
            tabVeterinarios.TabIndex = 4;
            tabVeterinarios.Text = "Veterinarios";
            tabVeterinarios.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabHistorial.ResumeLayout(false);
            tabHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            tabClientes.ResumeLayout(false);
            tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tabMascotas.ResumeLayout(false);
            tabMascotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabTurnos;
        private TabPage tabHistorial;
        private TabPage tabClientes;
        private TabPage tabMascotas;
        private TabPage tabVeterinarios;
        private CheckBox chkActivos;
        private Button btnBajaCliente;
        private Button btnNuevoCliente;
        private DataGridView dgvClientes;
        private Button btnModificarCliente;
        private Button btnActualizarClientes;
        private Button btnNuevaMascota;
        private Button btnBajaMascota;
        private DataGridView dgvMascotas;
        private Button btnModificarMascota;
        private CheckBox cbMascotas;
        private DataGridView dgvHistorial;
        private ComboBox cbMascota;
        private ComboBox cbDuenio;
        private Label label2;
        private Label label1;
    }
}
