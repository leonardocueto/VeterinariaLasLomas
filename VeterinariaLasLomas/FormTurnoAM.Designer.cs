namespace VeterinariaLasLomas
{
    partial class FormTurnoAM
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
            cmbDueno = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbMascota = new ComboBox();
            label3 = new Label();
            cmbVeterinario = new ComboBox();
            label4 = new Label();
            cmbTipoConsulta = new ComboBox();
            label5 = new Label();
            dtpHora = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            label6 = new Label();
            btnGuardarTurno = new Button();
            btnCancelarTurno = new Button();
            SuspendLayout();
            // 
            // cmbDueno
            // 
            cmbDueno.FormattingEnabled = true;
            cmbDueno.Location = new Point(22, 54);
            cmbDueno.Name = "cmbDueno";
            cmbDueno.Size = new Size(276, 23);
            cmbDueno.TabIndex = 0;
            cmbDueno.SelectedIndexChanged += cmbDueno_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Dueño";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 92);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Mascota";
            // 
            // cmbMascota
            // 
            cmbMascota.FormattingEnabled = true;
            cmbMascota.Location = new Point(22, 121);
            cmbMascota.Name = "cmbMascota";
            cmbMascota.Size = new Size(276, 23);
            cmbMascota.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 156);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Veterinario";
            // 
            // cmbVeterinario
            // 
            cmbVeterinario.FormattingEnabled = true;
            cmbVeterinario.Location = new Point(22, 185);
            cmbVeterinario.Name = "cmbVeterinario";
            cmbVeterinario.Size = new Size(276, 23);
            cmbVeterinario.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 224);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 7;
            label4.Text = "Tipo de consulta";
            // 
            // cmbTipoConsulta
            // 
            cmbTipoConsulta.FormattingEnabled = true;
            cmbTipoConsulta.Location = new Point(22, 253);
            cmbTipoConsulta.Name = "cmbTipoConsulta";
            cmbTipoConsulta.Size = new Size(276, 23);
            cmbTipoConsulta.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 295);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "Fecha";
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(182, 324);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(116, 23);
            dtpHora.TabIndex = 9;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(22, 324);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(144, 23);
            dtpFecha.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 295);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 11;
            label6.Text = "Hora";
            // 
            // btnGuardarTurno
            // 
            btnGuardarTurno.Location = new Point(223, 390);
            btnGuardarTurno.Name = "btnGuardarTurno";
            btnGuardarTurno.Size = new Size(75, 31);
            btnGuardarTurno.TabIndex = 12;
            btnGuardarTurno.Text = "Guardar";
            btnGuardarTurno.UseVisualStyleBackColor = true;
            btnGuardarTurno.Click += btnGuardarTurno_Click;
            // 
            // btnCancelarTurno
            // 
            btnCancelarTurno.Location = new Point(142, 390);
            btnCancelarTurno.Name = "btnCancelarTurno";
            btnCancelarTurno.Size = new Size(75, 31);
            btnCancelarTurno.TabIndex = 13;
            btnCancelarTurno.Text = "Cancelar";
            btnCancelarTurno.UseVisualStyleBackColor = true;
            btnCancelarTurno.Click += btnCancelarTurno_Click;
            // 
            // FormTurnoAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 433);
            Controls.Add(btnCancelarTurno);
            Controls.Add(btnGuardarTurno);
            Controls.Add(label6);
            Controls.Add(dtpFecha);
            Controls.Add(dtpHora);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbTipoConsulta);
            Controls.Add(label3);
            Controls.Add(cmbVeterinario);
            Controls.Add(label2);
            Controls.Add(cmbMascota);
            Controls.Add(label1);
            Controls.Add(cmbDueno);
            Name = "FormTurnoAM";
            Text = "FormTurnoAM";
            Load += FormTurnoAM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDueno;
        private Label label1;
        private Label label2;
        private ComboBox cmbMascota;
        private Label label3;
        private ComboBox cmbVeterinario;
        private Label label4;
        private ComboBox cmbTipoConsulta;
        private Label label5;
        private DateTimePicker dtpHora;
        private DateTimePicker dtpFecha;
        private Label label6;
        private Button btnGuardarTurno;
        private Button btnCancelarTurno;
    }
}