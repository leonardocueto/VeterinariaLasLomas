using BE;
using BE.DTO;
using BLL;
using System.Linq;


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

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            FormMascotaAM formulario = new FormMascotaAM();

            formulario.ShowDialog();

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
                List<DTOMascota> mascotas =
                    bllMascota.GetAllDTO();

                if (cbMascotas.Checked)
                {
                    mascotas = mascotas
                        .Where(m => m.Activo)
                        .ToList();
                }

                dgvMascotas.DataSource = null;
                dgvMascotas.DataSource = mascotas;
                dgvMascotas.Columns["Id"].Visible = false;
                dgvMascotas.Columns["Activo"].Visible = false;

                if (dgvMascotas.Columns["Id"] != null)
                {
                    dgvMascotas.Columns["Id"].HeaderText = "Id";
                }

                if (dgvMascotas.Columns["FechaNacimiento"] != null)
                {
                    dgvMascotas.Columns["FechaNacimiento"].HeaderText =
                        "Fecha de nacimiento";
                }

                if (dgvMascotas.Columns["Dueño"] != null)
                {
                    dgvMascotas.Columns["Dueño"].HeaderText = "Dueño";
                }
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

        private void btnBajaMascota_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow == null)
            {
                MessageBox.Show(
                    "Debe seleccionar una mascota para dar de baja."
                );

                return;
            }

            try
            {
                // Obtiene el DTO de la fila
                DTOMascota dto =
                    dgvMascotas.CurrentRow.DataBoundItem as DTOMascota;

                if (dto == null)
                {
                    MessageBox.Show(
                        "No se pudo obtener la mascota seleccionada."
                    );

                    return;
                }

                // Busca la mascota completa
                BEMascota mascota =
                    bllMascota.GetById(dto.Id);

                if (mascota == null)
                {
                    MessageBox.Show(
                        "No se encontró la mascota seleccionada."
                    );

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está segura de que desea dar de baja a " +
                    mascota.Nombre + "?",
                    "Confirmar baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    bllMascota.DarDeBaja(mascota);

                    MessageBox.Show(
                        "Mascota dada de baja correctamente."
                    );

                    ActualizarGridMascota();
                }
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

        private void dgvMascotas_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            // Este evento no carga la grilla.
        }

        private void btnModificarMascota_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow == null)
            {
                MessageBox.Show(
                    "Debe seleccionar una mascota para modificar."
                );

                return;
            }

            try
            {
                // Obtiene el DTO que está guardado en la fila seleccionada
                DTOMascota dto =
                    dgvMascotas.CurrentRow.DataBoundItem as DTOMascota;

                if (dto == null)
                {
                    MessageBox.Show(
                        "No se pudo obtener la mascota seleccionada."
                    );

                    return;
                }

                // Busca la entidad completa mediante el ID del DTO
                BEMascota mascota =
                    bllMascota.GetById(dto.Id);

                if (mascota == null)
                {
                    MessageBox.Show(
                        "No se encontró la mascota seleccionada."
                    );

                    return;
                }

                FormMascotaAM formulario =
                    new FormMascotaAM(mascota);

                formulario.ShowDialog();

                ActualizarGridMascota();
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

        private void cbMascotas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarGridMascota();
        }
    }
}