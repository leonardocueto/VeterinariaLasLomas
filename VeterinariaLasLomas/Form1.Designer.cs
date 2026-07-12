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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
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
            dgvVeterinarios = new DataGridView();
            btnActualizarVet = new Button();
            chkActivosVet = new CheckBox();
            btnModificarVet = new Button();
            btnBajaVet = new Button();
            btnNuevoVet = new Button();
            btnEspecialidad = new Button();
            tabControl.SuspendLayout();
            tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tabMascotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
            tabVeterinarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeterinarios).BeginInit();
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
            tabControl.Location = new Point(5, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(795, 447);
            tabControl.TabIndex = 0;
            // 
            // tabTurnos
            // 
            tabTurnos.Location = new Point(4, 24);
            tabTurnos.Name = "tabTurnos";
            tabTurnos.Padding = new Padding(3);
            tabTurnos.Size = new Size(787, 419);
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
            tabHistorial.Location = new Point(4, 24);
            tabHistorial.Margin = new Padding(3, 4, 3, 4);
            tabHistorial.Name = "tabHistorial";
            tabHistorial.Padding = new Padding(3);
            tabHistorial.Size = new Size(787, 419);
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
            cbMascota.Size = new Size(234, 23);
            cbMascota.TabIndex = 3;
            cbMascota.SelectedIndexChanged += cbMascota_SelectedIndexChanged;
            // 
            // cbDuenio
            // 
            cbDuenio.FormattingEnabled = true;
            cbDuenio.Location = new Point(55, 62);
            cbDuenio.Name = "cbDuenio";
            cbDuenio.Size = new Size(234, 23);
            cbDuenio.TabIndex = 2;
            cbDuenio.SelectedIndexChanged += cbDuenio_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(539, 29);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Mascota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
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
            tabClientes.Location = new Point(4, 24);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(3);
            tabClientes.Size = new Size(787, 419);
            tabClientes.TabIndex = 2;
            tabClientes.Text = "Clientes";
            tabClientes.UseVisualStyleBackColor = true;
            // 
            // btnActualizarClientes
            // 
            btnActualizarClientes.BackColor = Color.Transparent;
            btnActualizarClientes.Cursor = Cursors.Hand;
            btnActualizarClientes.Location = new Point(581, 34);
            btnActualizarClientes.Name = "btnActualizarClientes";
            btnActualizarClientes.Size = new Size(95, 28);
            btnActualizarClientes.TabIndex = 5;
            btnActualizarClientes.Text = "Actualizar";
            btnActualizarClientes.UseVisualStyleBackColor = false;
            btnActualizarClientes.Click += btnActualizarClientes_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.BackColor = Color.Transparent;
            btnModificarCliente.Cursor = Cursors.Hand;
            btnModificarCliente.Location = new Point(244, 19);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(113, 43);
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
            chkActivos.Location = new Point(696, 43);
            chkActivos.Name = "chkActivos";
            chkActivos.Size = new Size(89, 19);
            chkActivos.TabIndex = 3;
            chkActivos.Text = "Solo activos";
            chkActivos.UseVisualStyleBackColor = true;
            chkActivos.CheckedChanged += chkActivos_CheckedChanged;
            // 
            // btnBajaCliente
            // 
            btnBajaCliente.Cursor = Cursors.Hand;
            btnBajaCliente.Location = new Point(125, 19);
            btnBajaCliente.Name = "btnBajaCliente";
            btnBajaCliente.Size = new Size(113, 43);
            btnBajaCliente.TabIndex = 2;
            btnBajaCliente.Text = "Dar de baja";
            btnBajaCliente.UseVisualStyleBackColor = true;
            btnBajaCliente.Click += btnBajaCliente_Click;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.Transparent;
            btnNuevoCliente.Cursor = Cursors.Hand;
            btnNuevoCliente.Location = new Point(6, 19);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(113, 43);
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
            dgvClientes.Size = new Size(778, 319);
            dgvClientes.TabIndex = 0;
            // 
            // tabMascotas
            // 
            tabMascotas.Controls.Add(cbMascotas);
            tabMascotas.Controls.Add(btnModificarMascota);
            tabMascotas.Controls.Add(dgvMascotas);
            tabMascotas.Controls.Add(btnBajaMascota);
            tabMascotas.Controls.Add(btnNuevaMascota);
            tabMascotas.Location = new Point(4, 24);
            tabMascotas.Name = "tabMascotas";
            tabMascotas.Padding = new Padding(3);
            tabMascotas.Size = new Size(787, 419);
            tabMascotas.TabIndex = 3;
            tabMascotas.Text = "Mascotas";
            tabMascotas.UseVisualStyleBackColor = true;
            // 
            // cbMascotas
            // 
            cbMascotas.AutoSize = true;
            cbMascotas.Location = new Point(784, 55);
            cbMascotas.Name = "cbMascotas";
            cbMascotas.Size = new Size(89, 19);
            cbMascotas.TabIndex = 4;
            cbMascotas.Text = "Solo activos";
            cbMascotas.UseVisualStyleBackColor = true;
            cbMascotas.CheckedChanged += cbMascotas_CheckedChanged;
            // 
            // btnModificarMascota
            // 
            btnModificarMascota.Location = new Point(335, 31);
            btnModificarMascota.Name = "btnModificarMascota";
            btnModificarMascota.Size = new Size(167, 38);
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
            dgvMascotas.Margin = new Padding(3, 2, 3, 2);
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
            dgvMascotas.Size = new Size(767, 328);
            dgvMascotas.TabIndex = 2;
            dgvMascotas.CellContentClick += dgvMascotas_CellContentClick;
            // 
            // btnBajaMascota
            // 
            btnBajaMascota.Location = new Point(181, 31);
            btnBajaMascota.Margin = new Padding(3, 2, 3, 2);
            btnBajaMascota.Name = "btnBajaMascota";
            btnBajaMascota.Size = new Size(149, 38);
            btnBajaMascota.TabIndex = 1;
            btnBajaMascota.Text = "Dar de baja";
            btnBajaMascota.UseVisualStyleBackColor = true;
            btnBajaMascota.Click += btnBajaMascota_Click;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(13, 31);
            btnNuevaMascota.Margin = new Padding(3, 2, 3, 2);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(163, 38);
            btnNuevaMascota.TabIndex = 0;
            btnNuevaMascota.Text = "+ Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // tabVeterinarios
            // 
            tabVeterinarios.Controls.Add(dgvVeterinarios);
            tabVeterinarios.Controls.Add(btnActualizarVet);
            tabVeterinarios.Controls.Add(chkActivosVet);
            tabVeterinarios.Controls.Add(btnModificarVet);
            tabVeterinarios.Controls.Add(btnBajaVet);
            tabVeterinarios.Controls.Add(btnNuevoVet);
            tabVeterinarios.Controls.Add(btnEspecialidad);
            tabVeterinarios.Location = new Point(4, 24);
            tabVeterinarios.Name = "tabVeterinarios";
            tabVeterinarios.Padding = new Padding(3);
            tabVeterinarios.Size = new Size(787, 419);
            tabVeterinarios.TabIndex = 4;
            tabVeterinarios.Text = "Veterinarios";
            tabVeterinarios.UseVisualStyleBackColor = true;
            // 
            // dgvVeterinarios
            // 
            dgvVeterinarios.AllowUserToAddRows = false;
            dgvVeterinarios.AllowUserToDeleteRows = false;
            dgvVeterinarios.AllowUserToResizeColumns = false;
            dgvVeterinarios.AllowUserToResizeRows = false;
            dgvVeterinarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvVeterinarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvVeterinarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeterinarios.Cursor = Cursors.Hand;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvVeterinarios.DefaultCellStyle = dataGridViewCellStyle11;
            dgvVeterinarios.Location = new Point(6, 102);
            dgvVeterinarios.MultiSelect = false;
            dgvVeterinarios.Name = "dgvVeterinarios";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvVeterinarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvVeterinarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeterinarios.Size = new Size(775, 310);
            dgvVeterinarios.TabIndex = 8;
            // 
            // btnActualizarVet
            // 
            btnActualizarVet.BackColor = Color.Transparent;
            btnActualizarVet.Cursor = Cursors.Hand;
            btnActualizarVet.Location = new Point(581, 35);
            btnActualizarVet.Name = "btnActualizarVet";
            btnActualizarVet.Size = new Size(95, 28);
            btnActualizarVet.TabIndex = 7;
            btnActualizarVet.Text = "Actualizar";
            btnActualizarVet.UseVisualStyleBackColor = false;
            btnActualizarVet.Click += btnActualizarVet_Click;
            // 
            // chkActivosVet
            // 
            chkActivosVet.AutoSize = true;
            chkActivosVet.Checked = true;
            chkActivosVet.CheckState = CheckState.Checked;
            chkActivosVet.Cursor = Cursors.Hand;
            chkActivosVet.Location = new Point(695, 44);
            chkActivosVet.Name = "chkActivosVet";
            chkActivosVet.Size = new Size(89, 19);
            chkActivosVet.TabIndex = 6;
            chkActivosVet.Text = "Solo activos";
            chkActivosVet.UseVisualStyleBackColor = true;
            chkActivosVet.CheckedChanged += chkActivosVet_CheckedChanged;
            // 
            // btnModificarVet
            // 
            btnModificarVet.BackColor = Color.Transparent;
            btnModificarVet.Cursor = Cursors.Hand;
            btnModificarVet.Location = new Point(257, 20);
            btnModificarVet.Name = "btnModificarVet";
            btnModificarVet.Size = new Size(132, 43);
            btnModificarVet.TabIndex = 5;
            btnModificarVet.Text = "Modificar veterinario";
            btnModificarVet.UseVisualStyleBackColor = false;
            btnModificarVet.Click += btnModificarVet_Click;
            // 
            // btnBajaVet
            // 
            btnBajaVet.BackColor = Color.Transparent;
            btnBajaVet.Cursor = Cursors.Hand;
            btnBajaVet.Location = new Point(138, 20);
            btnBajaVet.Name = "btnBajaVet";
            btnBajaVet.Size = new Size(113, 43);
            btnBajaVet.TabIndex = 4;
            btnBajaVet.Text = "Dar de baja";
            btnBajaVet.UseVisualStyleBackColor = false;
            btnBajaVet.Click += btnBajaVet_Click;
            // 
            // btnNuevoVet
            // 
            btnNuevoVet.BackColor = Color.Transparent;
            btnNuevoVet.Cursor = Cursors.Hand;
            btnNuevoVet.Location = new Point(6, 20);
            btnNuevoVet.Name = "btnNuevoVet";
            btnNuevoVet.Size = new Size(126, 43);
            btnNuevoVet.TabIndex = 3;
            btnNuevoVet.Text = "+ Nuevo veterinario";
            btnNuevoVet.UseVisualStyleBackColor = false;
            btnNuevoVet.Click += btnNuevoVet_Click;
            // 
            // btnEspecialidad
            // 
            btnEspecialidad.BackColor = Color.Transparent;
            btnEspecialidad.Cursor = Cursors.Hand;
            btnEspecialidad.Location = new Point(411, 20);
            btnEspecialidad.Name = "btnEspecialidad";
            btnEspecialidad.Size = new Size(113, 43);
            btnEspecialidad.TabIndex = 2;
            btnEspecialidad.Text = "Especialidades";
            btnEspecialidad.UseVisualStyleBackColor = false;
            btnEspecialidad.Click += btnEspecialidad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
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
            tabVeterinarios.ResumeLayout(false);
            tabVeterinarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeterinarios).EndInit();
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
        private Button btnEspecialidad;
        private CheckBox cbMascotas;
        private DataGridView dgvHistorial;
        private ComboBox cbMascota;
        private ComboBox cbDuenio;
        private Label label2;
        private Label label1;
        private Button btnModificarVet;
        private Button btnBajaVet;
        private Button btnNuevoVet;
        private Button btnActualizarVet;
        private CheckBox chkActivosVet;
        private DataGridView dgvVeterinarios;
    }
}
