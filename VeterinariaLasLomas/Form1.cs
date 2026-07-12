using BE;
using BE.DTO;
using BLL;

namespace VeterinariaLasLomas
{
    public partial class Form1 : Form
    {
        private BLLCliente bllCliente = new BLLCliente();
        private BLLMascota bllMascota = new BLLMascota();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarGridCliente();

            // MASCOTAS
            ActualizarGridMascota();
        }

        private void ActualizarGridCliente()
        {
            try
            {
                List<DTOCliente> clientes = bllCliente.GetAllDTO();

                if (chkActivos.Checked)
                {
                    clientes = clientes.Where(c => c.Activo).ToList();
                }
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = clientes;
                dgvClientes.Columns["Id"].Visible = false;
                dgvClientes.Columns["Activo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FormClienteAM formClienteAM = new FormClienteAM();
                if (formClienteAM.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGridCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente.");
                    return;
                }
                DTOCliente dto = (DTOCliente)dgvClientes.CurrentRow.DataBoundItem;
                BECliente seleccionado = bllCliente.GetById(dto.Id);

                FormClienteAM formClienteAM = new FormClienteAM(seleccionado);
                if (formClienteAM.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGridCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente.");
                    return;
                }

                DTOCliente dto = (DTOCliente)dgvClientes.CurrentRow.DataBoundItem;

                DialogResult confirma = MessageBox.Show(
                    $"¿Dar de baja al cliente {dto.Nombre} {dto.Apellido}?",
                    "Confirmar baja",
                    MessageBoxButtons.YesNo);

                if (confirma == DialogResult.Yes)
                {
                    bllCliente.DarDeBaja(dto.Id);
                    MessageBox.Show("Cliente dado de baja correctamente.");
                    ActualizarGridCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarGridCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void chkActivos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ActualizarGridCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // -------------------- MASCOTAS --------------------

        private void ActualizarGridMascota()
        {
            try
            {
                dgvMascotas.DataSource = null;
                dgvMascotas.DataSource = bllMascota.GetAll();

                if (dgvMascotas.Columns["IdMascota"] != null)
                {
                    dgvMascotas.Columns["IdMascota"].HeaderText = "Id";
                }

                if (dgvMascotas.Columns["FechaNacimiento"] != null)
                {
                    dgvMascotas.Columns["FechaNacimiento"].HeaderText =
                        "Fecha de nacimiento";
                }

                if (dgvMascotas.Columns["Cliente"] != null)
                {
                    dgvMascotas.Columns["Cliente"].HeaderText = "Dueño";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar las mascotas.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnNuevaMascota_Click(
            object sender,
            EventArgs e)
        {
            FormMascotaAM formMascotaAM = new FormMascotaAM();

            formMascotaAM.ShowDialog();

            // Actualiza la grilla cuando se cierra el formulario.
            ActualizarGridMascota();
        }

        private void btnBajaMascota_Click(
            object sender,
            EventArgs e)
        {
            if (dgvMascotas.CurrentRow == null)
            {
                MessageBox.Show(
                    "Debe seleccionar una mascota.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            BEMascota mascotaSeleccionada =
                dgvMascotas.CurrentRow.DataBoundItem as BEMascota;

            if (mascotaSeleccionada == null)
            {
                MessageBox.Show(
                    "No se pudo obtener la mascota seleccionada.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            if (!mascotaSeleccionada.Activo)
            {
                MessageBox.Show(
                    "La mascota seleccionada ya se encuentra inactiva.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Desea dar de baja a {mascotaSeleccionada.Nombre}?",
                "Confirmar baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bllMascota.DarDeBaja(mascotaSeleccionada);

                MessageBox.Show(
                    "La mascota fue dada de baja correctamente.",
                    "Baja realizada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ActualizarGridMascota();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo dar de baja la mascota.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvMascotas_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            // Este evento no carga la grilla.
        }

        private void btnModificarMascota_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvMascotas.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar una mascota.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                BEMascota mascotaSeleccionada =
                    dgvMascotas.CurrentRow.DataBoundItem as BEMascota;
                FormMascotaAM formMascotaAM = new FormMascotaAM(mascotaSeleccionada);
                if(formMascotaAM.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGridMascota();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al intentar modificar la mascota.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


    }
}
