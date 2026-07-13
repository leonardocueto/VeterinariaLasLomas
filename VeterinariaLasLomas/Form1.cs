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
        private BLLTurno bllTurno = new BLLTurno();
        private BLLVeterinario bllVeterinario = new BLLVeterinario();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarGridCliente();
            ActualizarGridTurno();
            ActualizarGridMascota();
            CargarDuenios();
            ActualizarGridVeterinario();
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

        private void CargarDuenios()
        {
            try
            {
                List<BECliente> clientes = bllCliente.GetAll().Where(c => c.Activo).ToList();

                cbDuenio.DataSource = null;
                cbDuenio.DisplayMember = "NombreCompleto";
                cbDuenio.ValueMember = "IdCliente";
                cbDuenio.DataSource = clientes;
                cbDuenio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarMascotasDelDuenio()
        {
            cbMascota.DataSource = null;

            BECliente duenioSeleccionado =
                cbDuenio.SelectedItem as BECliente;

            if (duenioSeleccionado == null)
            {
                cbMascota.SelectedIndex = -1;
                return;
            }

            List<BEMascota> mascotasDelDuenio =
                bllMascota
                    .GetAll()
                    .Where(m =>
                        m.Cliente != null &&
                        m.Cliente.IdCliente ==
                            duenioSeleccionado.IdCliente)
                    .ToList();

            cbMascota.DataSource = mascotasDelDuenio;
            cbMascota.DisplayMember = "Nombre";
            cbMascota.ValueMember = "IdMascota";
            cbMascota.SelectedIndex = -1;
        }

        private void CargarHistorial(int idMascota)
        {
            try
            {
                List<DTOHistorial> historial = bllTurno.GetHistorialPorMascota(idMascota);

                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = historial;

                if (dgvHistorial.Columns["Duenio"] != null)
                    dgvHistorial.Columns["Duenio"].HeaderText = "Dueño";

                if (dgvHistorial.Columns["Fecha"] != null)
                    dgvHistorial.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";

                if (dgvHistorial.Columns["Diagnostico"] != null)
                    dgvHistorial.Columns["Diagnostico"].HeaderText = "Diagnóstico";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cbMascotas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarGridMascota();
        }


        private void cbDuenio_SelectedIndexChanged(
        object sender,
        EventArgs e)
        {
            CargarMascotasDelDuenio();
        }

        private void cbMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            BEMascota mascota = cbMascota.SelectedItem as BEMascota;

            if (mascota == null)
            {
                dgvHistorial.DataSource = null;
                return;
            }

            List<DTOHistorial> historial = bllTurno.GetHistorialPorMascota(mascota.IdMascota);

            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = historial;
        }

        // -------------------- Especialidades --------------------
        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            FormEspecialidades formEspecialidades = new FormEspecialidades();
            formEspecialidades.ShowDialog();
        }
        // -------------------- Veterinarios --------------------
        private void ActualizarGridVeterinario()
        {
            try
            {
                List<DTOVeterinario> veterinarios = bllVeterinario.GetAllDTO();

                if (chkActivosVet.Checked)
                {
                    veterinarios = veterinarios.Where(v => v.Activo).ToList();
                }

                dgvVeterinarios.DataSource = null;
                dgvVeterinarios.DataSource = veterinarios;

                dgvVeterinarios.Columns["Id"].Visible = false;
                dgvVeterinarios.Columns["Activo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevoVet_Click(object sender, EventArgs e)
        {
            try
            {
                FormVeterinarioAM form = new FormVeterinarioAM();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGridVeterinario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBajaVet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVeterinarios.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un veterinario.");
                    return;
                }

                DTOVeterinario dto = (DTOVeterinario)dgvVeterinarios.CurrentRow.DataBoundItem;

                DialogResult confirma = MessageBox.Show(
                    $"¿Dar de baja al veterinario {dto.Apellido}, {dto.Nombre}?",
                    "Confirmar baja",
                    MessageBoxButtons.YesNo);

                if (confirma == DialogResult.Yes)
                {
                    bllVeterinario.DarDeBaja(dto.Id);
                    MessageBox.Show("Veterinario dado de baja correctamente.");
                    ActualizarGridVeterinario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarVet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVeterinarios.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un veterinario.");
                    return;
                }

                DTOVeterinario dto = (DTOVeterinario)dgvVeterinarios.CurrentRow.DataBoundItem;
                BEVeterinario seleccionado = bllVeterinario.GetById(dto.Id);

                FormVeterinarioAM form = new FormVeterinarioAM(seleccionado);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGridVeterinario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnActualizarVet_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarGridVeterinario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkActivosVet_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarGridVeterinario();
        }
        // -------------------- Turnos --------------------

        private void ActualizarGridTurno()
        {
            try
            {
                dgvTurnos.DataSource = null;
                dgvTurnos.DataSource = bllTurno.GetAllDTO();

                dgvTurnos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            try
            {
                FormTurnoAM form = new FormTurnoAM();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGridTurno();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTurnos.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un turno.");
                    return;
                }

                DTOTurno dto = (DTOTurno)dgvTurnos.CurrentRow.DataBoundItem;
                BETurno seleccionado = bllTurno.GetById(dto.Id);

                FormTurnoAM form = new FormTurnoAM(seleccionado);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGridTurno();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTurnos.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un turno.");
                    return;
                }

                DTOTurno dto = (DTOTurno)dgvTurnos.CurrentRow.DataBoundItem;

                DialogResult confirma = MessageBox.Show(
                    $"¿Cancelar el turno de {dto.Mascota} ({dto.FechaHora})?",
                    "Confirmar cancelación",
                    MessageBoxButtons.YesNo);

                if (confirma == DialogResult.Yes)
                {
                    bllTurno.Cancelar(dto.Id);
                    MessageBox.Show("Turno cancelado correctamente.");
                    ActualizarGridTurno();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMarcarAtendido_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTurnos.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un turno.");
                    return;
                }

                DTOTurno dto = (DTOTurno)dgvTurnos.CurrentRow.DataBoundItem;
                BETurno seleccionado = bllTurno.GetById(dto.Id);

                FormCerrarAtencion form = new FormCerrarAtencion(seleccionado);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ActualizarGridTurno();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizarTurnos_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarGridTurno();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}