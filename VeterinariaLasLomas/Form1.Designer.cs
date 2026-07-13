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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            tabTurnos = new TabPage();
            dgvTurnos = new DataGridView();
            btnActualizarTurnos = new Button();
            btnMarcarAtendido = new Button();
            btnModificarTurno = new Button();
            btnCancelarTurno = new Button();
            btnNuevoTurno = new Button();
            tabHistorial = new TabPage();
            btnConsultarHist = new Button();
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
            tabControl.Location = new Point(5, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(795, 447);
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
            tabTurnos.Location = new Point(4, 24);
            tabTurnos.Name = "tabTurnos";
            tabTurnos.Padding = new Padding(3);
            tabTurnos.Size = new Size(787, 419);
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
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Control;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.Window;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dgvTurnos.DefaultCellStyle = dataGridViewCellStyle17;
            dgvTurnos.Location = new Point(6, 84);
            dgvTurnos.MultiSelect = false;
            dgvTurnos.Name = "dgvTurnos";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Control;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dgvTurnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnos.Size = new Size(778, 328);
            dgvTurnos.TabIndex = 9;
            // 
            // btnActualizarTurnos
            // 
            btnActualizarTurnos.BackColor = Color.Transparent;
            btnActualizarTurnos.Cursor = Cursors.Hand;
            btnActualizarTurnos.Location = new Point(669, 33);
            btnActualizarTurnos.Name = "btnActualizarTurnos";
            btnActualizarTurnos.Size = new Size(95, 28);
            btnActualizarTurnos.TabIndex = 8;
            btnActualizarTurnos.Text = "Actualizar";
            btnActualizarTurnos.UseVisualStyleBackColor = false;
            btnActualizarTurnos.Click += btnActualizarTurnos_Click;
            // 
            // btnMarcarAtendido
            // 
            btnMarcarAtendido.BackColor = Color.Transparent;
            btnMarcarAtendido.Cursor = Cursors.Hand;
            btnMarcarAtendido.Location = new Point(363, 18);
            btnMarcarAtendido.Name = "btnMarcarAtendido";
            btnMarcarAtendido.Size = new Size(113, 43);
            btnMarcarAtendido.TabIndex = 5;
            btnMarcarAtendido.Text = "Marcar atendido";
            btnMarcarAtendido.UseVisualStyleBackColor = false;
            btnMarcarAtendido.Click += btnMarcarAtendido_Click;
            // 
            // btnModificarTurno
            // 
            btnModificarTurno.BackColor = Color.Transparent;
            btnModificarTurno.Cursor = Cursors.Hand;
            btnModificarTurno.Location = new Point(244, 18);
            btnModificarTurno.Name = "btnModificarTurno";
            btnModificarTurno.Size = new Size(113, 43);
            btnModificarTurno.TabIndex = 4;
            btnModificarTurno.Text = "Modificar turno";
            btnModificarTurno.UseVisualStyleBackColor = false;
            btnModificarTurno.Click += btnModificarTurno_Click;
            // 
            // btnCancelarTurno
            // 
            btnCancelarTurno.BackColor = Color.Transparent;
            btnCancelarTurno.Cursor = Cursors.Hand;
            btnCancelarTurno.Location = new Point(125, 18);
            btnCancelarTurno.Name = "btnCancelarTurno";
            btnCancelarTurno.Size = new Size(113, 43);
            btnCancelarTurno.TabIndex = 3;
            btnCancelarTurno.Text = "Cancelar turno";
            btnCancelarTurno.UseVisualStyleBackColor = false;
            btnCancelarTurno.Click += btnCancelarTurno_Click;
            // 
            // btnNuevoTurno
            // 
            btnNuevoTurno.BackColor = Color.Transparent;
            btnNuevoTurno.Cursor = Cursors.Hand;
            btnNuevoTurno.Location = new Point(6, 18);
            btnNuevoTurno.Name = "btnNuevoTurno";
            btnNuevoTurno.Size = new Size(113, 43);
            btnNuevoTurno.TabIndex = 2;
            btnNuevoTurno.Text = "+ Nuevo turno";
            btnNuevoTurno.UseVisualStyleBackColor = false;
            btnNuevoTurno.Click += btnNuevoTurno_Click;
            // 
            // tabHistorial
            // 
            tabHistorial.Controls.Add(btnConsultarHist);
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
            // btnConsultarHist
            // 
            btnConsultarHist.Location = new Point(601, 33);
            btnConsultarHist.Name = "btnConsultarHist";
            btnConsultarHist.Size = new Size(128, 52);
            btnConsultarHist.TabIndex = 5;
            btnConsultarHist.Text = "Consultar";
            btnConsultarHist.UseVisualStyleBackColor = true;
            // 
            // dgvHistorial
            // 
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = SystemColors.Control;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dataGridViewCellStyle20;
            dgvHistorial.Location = new Point(6, 125);
            dgvHistorial.Name = "dgvHistorial";
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = SystemColors.Control;
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle21.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dgvHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(775, 287);
            dgvHistorial.TabIndex = 4;
            // 
            // cbMascota
            // 
            cbMascota.FormattingEnabled = true;
            cbMascota.Location = new Point(341, 62);
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
            label2.Location = new Point(341, 29);
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
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.Control;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle22.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = SystemColors.Window;
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle23.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle23;
            dgvClientes.Location = new Point(7, 109);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = SystemColors.Control;
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
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
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = SystemColors.Control;
            dataGridViewCellStyle25.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle25.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            dgvMascotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = SystemColors.Window;
            dataGridViewCellStyle26.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle26.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.False;
            dgvMascotas.DefaultCellStyle = dataGridViewCellStyle26;
            dgvMascotas.Location = new Point(15, 117);
            dgvMascotas.Margin = new Padding(3, 2, 3, 2);
            dgvMascotas.Name = "dgvMascotas";
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = SystemColors.Control;
            dataGridViewCellStyle27.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle27.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
            dgvMascotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
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
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = SystemColors.Control;
            dataGridViewCellStyle28.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle28.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.True;
            dgvVeterinarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            dgvVeterinarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeterinarios.Cursor = Cursors.Hand;
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = SystemColors.Window;
            dataGridViewCellStyle29.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle29.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.False;
            dgvVeterinarios.DefaultCellStyle = dataGridViewCellStyle29;
            dgvVeterinarios.Location = new Point(6, 102);
            dgvVeterinarios.MultiSelect = false;
            dgvVeterinarios.Name = "dgvVeterinarios";
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = SystemColors.Control;
            dataGridViewCellStyle30.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle30.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = DataGridViewTriState.True;
            dgvVeterinarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
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
        private DataGridView dgvTurnos;
        private Button btnActualizarTurnos;
        private Button btnMarcarAtendido;
        private Button btnModificarTurno;
        private Button btnCancelarTurno;
        private Button btnNuevoTurno;
        private Button btnConsultarHist;
    }
}
