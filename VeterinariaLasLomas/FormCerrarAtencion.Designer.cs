namespace VeterinariaLasLomas
{
    partial class FormCerrarAtencion
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
            label1 = new Label();
            txtDiagnostico = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            lblMascota = new Label();
            label3 = new Label();
            lblVeterinario = new Label();
            label5 = new Label();
            lblTipo = new Label();
            label7 = new Label();
            lblFecha = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Mascota";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(12, 176);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(339, 124);
            txtDiagnostico.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(276, 306);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(195, 306);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblMascota
            // 
            lblMascota.AutoSize = true;
            lblMascota.Location = new Point(83, 18);
            lblMascota.Name = "lblMascota";
            lblMascota.Size = new Size(38, 15);
            lblMascota.TabIndex = 4;
            lblMascota.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 47);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Veterinario";
            // 
            // lblVeterinario
            // 
            lblVeterinario.AutoSize = true;
            lblVeterinario.Location = new Point(83, 47);
            lblVeterinario.Name = "lblVeterinario";
            lblVeterinario.Size = new Size(38, 15);
            lblVeterinario.TabIndex = 6;
            lblVeterinario.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 79);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 7;
            label5.Text = "Tipo";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(83, 79);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(38, 15);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 103);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 9;
            label7.Text = "Fecha";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(83, 103);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 10;
            lblFecha.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 148);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 11;
            label9.Text = "Diagnostico";
            // 
            // FormCerrarAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 341);
            Controls.Add(label9);
            Controls.Add(lblFecha);
            Controls.Add(label7);
            Controls.Add(lblTipo);
            Controls.Add(label5);
            Controls.Add(lblVeterinario);
            Controls.Add(label3);
            Controls.Add(lblMascota);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtDiagnostico);
            Controls.Add(label1);
            Name = "FormCerrarAtencion";
            Text = "FormCerrarAtencion";
            Load += FormCerrarAtencion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDiagnostico;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label lblMascota;
        private Label label3;
        private Label lblVeterinario;
        private Label label5;
        private Label lblTipo;
        private Label label7;
        private Label lblFecha;
        private Label label9;
    }
}