using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VeterinariaLasLomas
{
    public partial class FormMascotaAM : Form
    {
        private BLLCliente bllCliente =
            new BLLCliente();

        private BLLMascota bllMascota =
            new BLLMascota();

        private BEMascota mascotaEditar;

        // Constructor para agregar
        public FormMascotaAM()
        {
            InitializeComponent();

            Load += FormMascotaAM_Load;

            Text = "Nueva mascota";
        }

        // Constructor para modificar
        public FormMascotaAM(BEMascota mascota)
            : this()
        {
            mascotaEditar = mascota;

            Text = "Modificar mascota";
        }

        private void FormMascotaAM_Load(
            object sender,
            EventArgs e)
        {
            dtpFechaNacimiento.MaxDate =
                DateTime.Today;

            CargarDuenos();

            if (mascotaEditar != null)
            {
                CargarDatosMascota();
            }
        }

        private void CargarDuenos()
        {
            try
            {
                List<BECliente> clientes =
                    bllCliente.GetAll();

                cmbDueno.DataSource = null;
                cmbDueno.DataSource = clientes;
                cmbDueno.DisplayMember = "Nombre";
                cmbDueno.ValueMember = "IdCliente";
                cmbDueno.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los dueños. " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CargarDatosMascota()
        {
            txtNombre.Text =
                mascotaEditar.Nombre;

            txtEspecie.Text =
                mascotaEditar.Especie;

            txtRaza.Text =
                mascotaEditar.Raza;

            dtpFechaNacimiento.Value =
                mascotaEditar.FechaNacimiento;

            if (mascotaEditar.Cliente != null)
            {
                cmbDueno.SelectedValue =
                    mascotaEditar.Cliente.IdCliente;
            }
        }

        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                BECliente clienteSeleccionado =
                    cmbDueno.SelectedItem as BECliente;

                if (clienteSeleccionado == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un dueño.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (mascotaEditar == null)
                {
                    GuardarMascotaNueva(
                        clienteSeleccionado
                    );
                }
                else
                {
                    ModificarMascota(
                        clienteSeleccionado
                    );
                }

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void GuardarMascotaNueva(
            BECliente clienteSeleccionado)
        {
            BEMascota mascota = new BEMascota();

            mascota.Nombre =
                txtNombre.Text.Trim();

            mascota.Especie =
                txtEspecie.Text.Trim();

            mascota.Raza =
                txtRaza.Text.Trim();

            mascota.FechaNacimiento =
                dtpFechaNacimiento.Value.Date;

            mascota.Cliente =
                clienteSeleccionado;

            bllMascota.Guardar(mascota);

            MessageBox.Show(
                "La mascota se guardó correctamente.",
                "Mascota guardada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ModificarMascota(
            BECliente clienteSeleccionado)
        {
            mascotaEditar.Nombre =
                txtNombre.Text.Trim();

            mascotaEditar.Especie =
                txtEspecie.Text.Trim();

            mascotaEditar.Raza =
                txtRaza.Text.Trim();

            mascotaEditar.FechaNacimiento =
                dtpFechaNacimiento.Value.Date;

            mascotaEditar.Cliente =
                clienteSeleccionado;

            bllMascota.Modificar(mascotaEditar);

            MessageBox.Show(
                "La mascota se modificó correctamente.",
                "Mascota modificada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            DialogResult resultado =
                MessageBox.Show(
                    "¿Desea cancelar la operación?",
                    "Cancelar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;

                Close();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}