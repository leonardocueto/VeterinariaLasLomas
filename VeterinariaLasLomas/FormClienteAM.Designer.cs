namespace VeterinariaLasLomas
{
    partial class FormClienteAM
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
            txtApellido = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            label2 = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            txtDni = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(217, 58);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(157, 23);
            txtApellido.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(181, 314);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 34);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 30);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(289, 314);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 34);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(12, 139);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(152, 23);
            txtDni.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "DNI";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(217, 139);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(157, 23);
            txtTelefono.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 111);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 8;
            label4.Text = "Telefono";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(362, 23);
            txtEmail.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 192);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // FormClienteAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 360);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(txtApellido);
            Name = "FormClienteAM";
            Text = "Nuevo cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApellido;
        private Label label1;
        private Button btnCancelar;
        private Label label2;
        private TextBox txtNombre;
        private Button btnGuardar;
        private TextBox txtDni;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
    }
}