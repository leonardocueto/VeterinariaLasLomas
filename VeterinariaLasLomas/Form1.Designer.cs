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
            tabControl = new TabControl();
            tabTurnos = new TabPage();
            tabHistorial = new TabPage();
            tabClientes = new TabPage();
            tabMascotas = new TabPage();
            tabVeterinarios = new TabPage();
            dgvClientes = new DataGridView();
            btnNuevoCliente = new Button();
            btnBajaCliente = new Button();
            chkActivos = new CheckBox();
            btnModificarCliente = new Button();
            btnActualizarClientes = new Button();
            tabControl.SuspendLayout();
            tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
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
            tabHistorial.Location = new Point(4, 24);
            tabHistorial.Name = "tabHistorial";
            tabHistorial.Padding = new Padding(3);
            tabHistorial.Size = new Size(787, 419);
            tabHistorial.TabIndex = 1;
            tabHistorial.Text = "Historial";
            tabHistorial.UseVisualStyleBackColor = true;
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
            // tabMascotas
            // 
            tabMascotas.Location = new Point(4, 24);
            tabMascotas.Name = "tabMascotas";
            tabMascotas.Padding = new Padding(3);
            tabMascotas.Size = new Size(787, 419);
            tabMascotas.TabIndex = 3;
            tabMascotas.Text = "Mascotas";
            tabMascotas.UseVisualStyleBackColor = true;
            // 
            // tabVeterinarios
            // 
            tabVeterinarios.Location = new Point(4, 24);
            tabVeterinarios.Name = "tabVeterinarios";
            tabVeterinarios.Padding = new Padding(3);
            tabVeterinarios.Size = new Size(787, 419);
            tabVeterinarios.TabIndex = 4;
            tabVeterinarios.Text = "Veterinarios";
            tabVeterinarios.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Location = new Point(6, 82);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(778, 319);
            dgvClientes.TabIndex = 0;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.Transparent;
            btnNuevoCliente.Location = new Point(6, 19);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(113, 43);
            btnNuevoCliente.TabIndex = 1;
            btnNuevoCliente.Text = "Nuevo cliente";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // btnBajaCliente
            // 
            btnBajaCliente.Location = new Point(125, 19);
            btnBajaCliente.Name = "btnBajaCliente";
            btnBajaCliente.Size = new Size(113, 43);
            btnBajaCliente.TabIndex = 2;
            btnBajaCliente.Text = "Dar de baja";
            btnBajaCliente.UseVisualStyleBackColor = true;
            // 
            // chkActivos
            // 
            chkActivos.AutoSize = true;
            chkActivos.Location = new Point(696, 43);
            chkActivos.Name = "chkActivos";
            chkActivos.Size = new Size(89, 19);
            chkActivos.TabIndex = 3;
            chkActivos.Text = "Solo activos";
            chkActivos.UseVisualStyleBackColor = true;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.BackColor = Color.Transparent;
            btnModificarCliente.Location = new Point(244, 19);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(113, 43);
            btnModificarCliente.TabIndex = 4;
            btnModificarCliente.Text = "Modificar cliente";
            btnModificarCliente.UseVisualStyleBackColor = false;
            // 
            // btnActualizarClientes
            // 
            btnActualizarClientes.BackColor = Color.Transparent;
            btnActualizarClientes.Location = new Point(581, 34);
            btnActualizarClientes.Name = "btnActualizarClientes";
            btnActualizarClientes.Size = new Size(95, 28);
            btnActualizarClientes.TabIndex = 5;
            btnActualizarClientes.Text = "Actualizar";
            btnActualizarClientes.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabClientes.ResumeLayout(false);
            tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
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
    }
}
