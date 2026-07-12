using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VeterinariaLasLomas
{
    public partial class FormClienteAM : Form
    {
        private BLLCliente bllCliente = new BLLCliente();
        private BECliente clienteEditar;
        public FormClienteAM()
        {
            InitializeComponent();
            clienteEditar = null;
            this.Text = "Nuevo cliente";
        }
        public FormClienteAM(BECliente cliente)
        {
            InitializeComponent();
            clienteEditar = cliente;
            this.Text = "Modificar cliente";
            PrecargarDatos();
        }
        private void PrecargarDatos()
        {
            txtNombre.Text = clienteEditar.Nombre;
            txtApellido.Text = clienteEditar.Apellido;
            txtDni.Text = clienteEditar.Dni;
            txtTelefono.Text = clienteEditar.Telefono;
            txtEmail.Text = clienteEditar.Email;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteEditar == null)
                {
                    BECliente nuevo = new BECliente();
                    nuevo.Nombre = txtNombre.Text;
                    nuevo.Apellido = txtApellido.Text;
                    nuevo.Dni = txtDni.Text;
                    nuevo.Telefono = txtTelefono.Text;
                    nuevo.Email = txtEmail.Text;

                    bllCliente.Guardar(nuevo);
                    MessageBox.Show("Cliente guardado correctamente.");
                }
                else
                {
                    clienteEditar.Nombre = txtNombre.Text;
                    clienteEditar.Apellido = txtApellido.Text;
                    clienteEditar.Dni = txtDni.Text;
                    clienteEditar.Telefono = txtTelefono.Text;
                    clienteEditar.Email = txtEmail.Text;

                    bllCliente.Modificar(clienteEditar);
                    MessageBox.Show("Cliente modificado correctamente.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
