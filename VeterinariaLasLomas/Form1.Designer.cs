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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            tabTurnos = new TabPage();
            dgvTurnos = new DataGridView();
            btnActualizarTurnos = new Button();
            btnMarcarAtendido = new Button();
            btnModificarTurno = new Button();
            btnCancelarTurno = new Button();
            btnNuevoTurno = new Button();
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
            btnActualizarMascota = new Button();
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
            tabTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
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
            tabControl.Location = new Point(6, 3);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(909, 596);
            tabControl.TabIndex = 0;
            // 
            // tabTurnos
            // 
            tabTurnos.Controls.Add(dgvTurnos);
            tabTurnos.Controls.Add(btnActualizarTurnos);
            tabTurnos.Controls.Add(btnMarcarAtendido);
            tabTurnos.Controls.Add(btnModificarTurno);
            tabTurnos.Controls.Add(btnCancelarTurno);
            tabTurnos.Controls.Add(btnNuevoTurno);
            tabTurnos.Location = new Point(4, 29);
            tabTurnos.Margin = new Padding(3, 4, 3, 4);
            tabTurnos.Name = "tabTurnos";
            tabTurnos.Padding = new Padding(3, 4, 3, 4);
            tabTurnos.Size = new Size(901, 563);
            tabTurnos.TabIndex = 0;
            tabTurnos.Text = "Turnos";
            tabTurnos.UseVisualStyleBackColor = true;
            // 
            // dgvTurnos
            // 
            dgvTurnos.AllowUserToAddRows = false;
            dgvTurnos.AllowUserToDeleteRows = false;
            dgvTurnos.AllowUserToResizeColumns = false;
            dgvTurnos.AllowUserToResizeRows = false;
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTurnos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTurnos.Location = new Point(7, 112);
            dgvTurnos.Margin = new Padding(3, 4, 3, 4);
            dgvTurnos.MultiSelect = false;
            dgvTurnos.Name = "dgvTurnos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTurnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTurnos.RowHeadersWidth = 51;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnos.Size = new Size(889, 437);
            dgvTurnos.TabIndex = 9;
            // 
            // btnActualizarTurnos
            // 
            btnActualizarTurnos.BackColor = Color.Transparent;
            btnActualizarTurnos.Cursor = Cursors.Hand;
            btnActualizarTurnos.Location = new Point(765, 44);
            btnActualizarTurnos.Margin = new Padding(3, 4, 3, 4);
            btnActualizarTurnos.Name = "btnActualizarTurnos";
            btnActualizarTurnos.Size = new Size(109, 37);
            btnActualizarTurnos.TabIndex = 8;
            btnActualizarTurnos.Text = "Actualizar";
            btnActualizarTurnos.UseVisualStyleBackColor = false;
            btnActualizarTurnos.Click += btnActualizarTurnos_Click;
            // 
            // btnMarcarAtendido
            // 
            btnMarcarAtendido.BackColor = Color.Transparent;
            btnMarcarAtendido.Cursor = Cursors.Hand;
            btnMarcarAtendido.Location = new Point(415, 24);
            btnMarcarAtendido.Margin = new Padding(3, 4, 3, 4);
            btnMarcarAtendido.Name = "btnMarcarAtendido";
            btnMarcarAtendido.Size = new Size(129, 57);
            btnMarcarAtendido.TabIndex = 5;
            btnMarcarAtendido.Text = "Marcar atendido";
            btnMarcarAtendido.UseVisualStyleBackColor = false;
            btnMarcarAtendido.Click += btnMarcarAtendido_Click;
            // 
            // btnModificarTurno
            // 
            btnModificarTurno.BackColor = Color.Transparent;
            btnModificarTurno.Cursor = Cursors.Hand;
            btnModificarTurno.Location = new Point(279, 24);
            btnModificarTurno.Margin = new Padding(3, 4, 3, 4);
            btnModificarTurno.Name = "btnModificarTurno";
            btnModificarTurno.Size = new Size(129, 57);
            btnModificarTurno.TabIndex = 4;
            btnModificarTurno.Text = "Modificar turno";
            btnModificarTurno.UseVisualStyleBackColor = false;
            btnModificarTurno.Click += btnModificarTurno_Click;
            // 
            // btnCancelarTurno
            // 
            btnCancelarTurno.BackColor = Color.Transparent;
            btnCancelarTurno.Cursor = Cursors.Hand;
            btnCancelarTurno.Location = new Point(143, 24);
            btnCancelarTurno.Margin = new Padding(3, 4, 3, 4);
            btnCancelarTurno.Name = "btnCancelarTurno";
            btnCancelarTurno.Size = new Size(129, 57);
            btnCancelarTurno.TabIndex = 3;
            btnCancelarTurno.Text = "Cancelar turno";
            btnCancelarTurno.UseVisualStyleBackColor = false;
            btnCancelarTurno.Click += btnCancelarTurno_Click;
            // 
            // btnNuevoTurno
            // 
            btnNuevoTurno.BackColor = Color.Transparent;
            btnNuevoTurno.Cursor = Cursors.Hand;
            btnNuevoTurno.Location = new Point(7, 24);
            btnNuevoTurno.Margin = new Padding(3, 4, 3, 4);
            btnNuevoTurno.Name = "btnNuevoTurno";
            btnNuevoTurno.Size = new Size(129, 57);
            btnNuevoTurno.TabIndex = 2;
            btnNuevoTurno.Text = "+ Nuevo turno";
            btnNuevoTurno.UseVisualStyleBackColor = false;
            btnNuevoTurno.Click += btnNuevoTurno_Click;
            // 
            // tabHistorial
            // 
            tabHistorial.Controls.Add(dgvHistorial);
            tabHistorial.Controls.Add(cbMascota);
            tabHistorial.Controls.Add(cbDuenio);
            tabHistorial.Controls.Add(label2);
            tabHistorial.Controls.Add(label1);
            tabHistorial.Location = new Point(4, 29);
            tabHistorial.Margin = new Padding(3, 5, 3, 5);
            tabHistorial.Name = "tabHistorial";
            tabHistorial.Padding = new Padding(3, 4, 3, 4);
            tabHistorial.Size = new Size(901, 563);
            tabHistorial.TabIndex = 1;
            tabHistorial.Text = "Historial";
            tabHistorial.UseVisualStyleBackColor = true;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dataGridViewCellStyle5;
            dgvHistorial.Location = new Point(6, 86);
            dgvHistorial.Margin = new Padding(3, 4, 3, 4);
            dgvHistorial.Name = "dgvHistorial";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(889, 467);
            dgvHistorial.TabIndex = 4;
            // 
            // cbMascota
            // 
            cbMascota.FormattingEnabled = true;
            cbMascota.Location = new Point(554, 50);
            cbMascota.Margin = new Padding(3, 4, 3, 4);
            cbMascota.Name = "cbMascota";
            cbMascota.Size = new Size(267, 28);
            cbMascota.TabIndex = 3;
            cbMascota.SelectedIndexChanged += cbMascota_SelectedIndexChanged;
            // 
            // cbDuenio
            // 
            cbDuenio.FormattingEnabled = true;
            cbDuenio.Location = new Point(35, 50);
            cbDuenio.Margin = new Padding(3, 4, 3, 4);
            cbDuenio.Name = "cbDuenio";
            cbDuenio.Size = new Size(267, 28);
            cbDuenio.TabIndex = 2;
            cbDuenio.SelectedIndexChanged += cbDuenio_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(554, 26);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Mascota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 26);
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle8;
            dgvClientes.Location = new Point(8, 145);
            dgvClientes.Margin = new Padding(3, 5, 3, 5);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(889, 425);
            dgvClientes.TabIndex = 0;
            // 
            // tabMascotas
            // 
            tabMascotas.Controls.Add(btnActualizarMascota);
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
            // btnActualizarMascota
            // 
            btnActualizarMascota.Location = new Point(781, 86);
            btnActualizarMascota.Name = "btnActualizarMascota";
            btnActualizarMascota.Size = new Size(100, 28);
            btnActualizarMascota.TabIndex = 5;
            btnActualizarMascota.Text = "Actualizar";
            btnActualizarMascota.UseVisualStyleBackColor = true;
            btnActualizarMascota.Click += btnActualizarMascota_Click;
            // 
            // cbMascotas
            // 
            cbMascotas.AutoSize = true;
            cbMascotas.Location = new Point(781, 55);
            cbMascotas.Margin = new Padding(3, 4, 3, 4);
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
            dgvMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvMascotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvMascotas.DefaultCellStyle = dataGridViewCellStyle11;
            dgvMascotas.Location = new Point(15, 126);
            dgvMascotas.Name = "dgvMascotas";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvMascotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            tabVeterinarios.Controls.Add(dgvVeterinarios);
            tabVeterinarios.Controls.Add(btnActualizarVet);
            tabVeterinarios.Controls.Add(chkActivosVet);
            tabVeterinarios.Controls.Add(btnModificarVet);
            tabVeterinarios.Controls.Add(btnBajaVet);
            tabVeterinarios.Controls.Add(btnNuevoVet);
            tabVeterinarios.Controls.Add(btnEspecialidad);
            tabVeterinarios.Location = new Point(4, 29);
            tabVeterinarios.Margin = new Padding(3, 4, 3, 4);
            tabVeterinarios.Name = "tabVeterinarios";
            tabVeterinarios.Padding = new Padding(3, 4, 3, 4);
            tabVeterinarios.Size = new Size(901, 563);
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvVeterinarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvVeterinarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeterinarios.Cursor = Cursors.Hand;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvVeterinarios.DefaultCellStyle = dataGridViewCellStyle14;
            dgvVeterinarios.Location = new Point(7, 136);
            dgvVeterinarios.Margin = new Padding(3, 4, 3, 4);
            dgvVeterinarios.MultiSelect = false;
            dgvVeterinarios.Name = "dgvVeterinarios";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvVeterinarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvVeterinarios.RowHeadersWidth = 51;
            dgvVeterinarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeterinarios.Size = new Size(886, 413);
            dgvVeterinarios.TabIndex = 8;
            // 
            // btnActualizarVet
            // 
            btnActualizarVet.BackColor = Color.Transparent;
            btnActualizarVet.Cursor = Cursors.Hand;
            btnActualizarVet.Location = new Point(664, 47);
            btnActualizarVet.Margin = new Padding(3, 4, 3, 4);
            btnActualizarVet.Name = "btnActualizarVet";
            btnActualizarVet.Size = new Size(109, 37);
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
            chkActivosVet.Location = new Point(794, 59);
            chkActivosVet.Margin = new Padding(3, 4, 3, 4);
            chkActivosVet.Name = "chkActivosVet";
            chkActivosVet.Size = new Size(111, 24);
            chkActivosVet.TabIndex = 6;
            chkActivosVet.Text = "Solo activos";
            chkActivosVet.UseVisualStyleBackColor = true;
            chkActivosVet.CheckedChanged += chkActivosVet_CheckedChanged;
            // 
            // btnModificarVet
            // 
            btnModificarVet.BackColor = Color.Transparent;
            btnModificarVet.Cursor = Cursors.Hand;
            btnModificarVet.Location = new Point(294, 27);
            btnModificarVet.Margin = new Padding(3, 4, 3, 4);
            btnModificarVet.Name = "btnModificarVet";
            btnModificarVet.Size = new Size(151, 57);
            btnModificarVet.TabIndex = 5;
            btnModificarVet.Text = "Modificar veterinario";
            btnModificarVet.UseVisualStyleBackColor = false;
            btnModificarVet.Click += btnModificarVet_Click;
            // 
            // btnBajaVet
            // 
            btnBajaVet.BackColor = Color.Transparent;
            btnBajaVet.Cursor = Cursors.Hand;
            btnBajaVet.Location = new Point(158, 27);
            btnBajaVet.Margin = new Padding(3, 4, 3, 4);
            btnBajaVet.Name = "btnBajaVet";
            btnBajaVet.Size = new Size(129, 57);
            btnBajaVet.TabIndex = 4;
            btnBajaVet.Text = "Dar de baja";
            btnBajaVet.UseVisualStyleBackColor = false;
            btnBajaVet.Click += btnBajaVet_Click;
            // 
            // btnNuevoVet
            // 
            btnNuevoVet.BackColor = Color.Transparent;
            btnNuevoVet.Cursor = Cursors.Hand;
            btnNuevoVet.Location = new Point(7, 27);
            btnNuevoVet.Margin = new Padding(3, 4, 3, 4);
            btnNuevoVet.Name = "btnNuevoVet";
            btnNuevoVet.Size = new Size(144, 57);
            btnNuevoVet.TabIndex = 3;
            btnNuevoVet.Text = "+ Nuevo veterinario";
            btnNuevoVet.UseVisualStyleBackColor = false;
            btnNuevoVet.Click += btnNuevoVet_Click;
            // 
            // btnEspecialidad
            // 
            btnEspecialidad.BackColor = Color.Transparent;
            btnEspecialidad.Cursor = Cursors.Hand;
            btnEspecialidad.Location = new Point(470, 27);
            btnEspecialidad.Margin = new Padding(3, 4, 3, 4);
            btnEspecialidad.Name = "btnEspecialidad";
            btnEspecialidad.Size = new Size(129, 57);
            btnEspecialidad.TabIndex = 2;
            btnEspecialidad.Text = "Especialidades";
            btnEspecialidad.UseVisualStyleBackColor = false;
            btnEspecialidad.Click += btnEspecialidad_Click;
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
            tabTurnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
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
        private DataGridView dgvTurnos;
        private Button btnActualizarTurnos;
        private Button btnMarcarAtendido;
        private Button btnModificarTurno;
        private Button btnCancelarTurno;
        private Button btnNuevoTurno;
        private CheckBox cbMascotas;
        private Button btnActualizarMascota;
    }
}
