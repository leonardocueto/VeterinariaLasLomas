namespace VeterinariaLasLomas
{
    partial class FormVeterinarioAM
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
            txtNombreVet = new TextBox();
            txtApellidoVet = new TextBox();
            txtMatricula = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCancelarVet = new Button();
            btnGuardarVet = new Button();
            clbEspecialidades = new CheckedListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNombreVet
            // 
            txtNombreVet.Location = new Point(12, 39);
            txtNombreVet.Name = "txtNombreVet";
            txtNombreVet.Size = new Size(146, 23);
            txtNombreVet.TabIndex = 0;
            // 
            // txtApellidoVet
            // 
            txtApellidoVet.Location = new Point(180, 39);
            txtApellidoVet.Name = "txtApellidoVet";
            txtApellidoVet.Size = new Size(146, 23);
            txtApellidoVet.TabIndex = 1;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(12, 105);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(314, 23);
            txtMatricula.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 21);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Matricula";
            // 
            // btnCancelarVet
            // 
            btnCancelarVet.Location = new Point(160, 264);
            btnCancelarVet.Name = "btnCancelarVet";
            btnCancelarVet.Size = new Size(75, 23);
            btnCancelarVet.TabIndex = 6;
            btnCancelarVet.Text = "Cancelar";
            btnCancelarVet.UseVisualStyleBackColor = true;
            btnCancelarVet.Click += btnCancelarVet_Click;
            // 
            // btnGuardarVet
            // 
            btnGuardarVet.Location = new Point(251, 264);
            btnGuardarVet.Name = "btnGuardarVet";
            btnGuardarVet.Size = new Size(75, 23);
            btnGuardarVet.TabIndex = 7;
            btnGuardarVet.Text = "Guardar";
            btnGuardarVet.UseVisualStyleBackColor = true;
            btnGuardarVet.Click += btnGuardarVet_Click;
            // 
            // clbEspecialidades
            // 
            clbEspecialidades.CheckOnClick = true;
            clbEspecialidades.FormattingEnabled = true;
            clbEspecialidades.Location = new Point(12, 164);
            clbEspecialidades.Name = "clbEspecialidades";
            clbEspecialidades.Size = new Size(314, 94);
            clbEspecialidades.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 9;
            label4.Text = "Especialidades";
            // 
            // FormVeterinarioAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 299);
            Controls.Add(label4);
            Controls.Add(clbEspecialidades);
            Controls.Add(btnGuardarVet);
            Controls.Add(btnCancelarVet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMatricula);
            Controls.Add(txtApellidoVet);
            Controls.Add(txtNombreVet);
            Name = "FormVeterinarioAM";
            Text = "FormVeterinarioAM";
            Load += FormVeterinarioAM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreVet;
        private TextBox txtApellidoVet;
        private TextBox txtMatricula;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCancelarVet;
        private Button btnGuardarVet;
        private CheckedListBox clbEspecialidades;
        private Label label4;
    }
}