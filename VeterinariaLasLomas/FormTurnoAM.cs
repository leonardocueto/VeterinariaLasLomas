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
    public partial class FormTurnoAM : Form
    {
        private BLLCliente bllCliente = new BLLCliente();
        private BLLMascota bllMascota = new BLLMascota();
        private BLLVeterinario bllVeterinario = new BLLVeterinario();
        private BLLTipoConsulta bllTipoConsulta = new BLLTipoConsulta();
        private BLLTurno bllTurno = new BLLTurno();
        private BETurno turnoEditar;
        public FormTurnoAM()
        {
            InitializeComponent();
            turnoEditar = null;
            this.Text = "Nuevo turno";
        }
        public FormTurnoAM(BETurno turno)
        {
            InitializeComponent();
            turnoEditar = turno;
            this.Text = "Modificar turno";
        }
        private void FormTurnoAM_Load(object sender, EventArgs e)
        {
            CargarCombos();

            if (turnoEditar == null)
            {
                CargarMascotasDelDueno();
            }
            else
            {
                PrecargarDatos();
                BloquearParaModificacion();
            }
        }
        private void CargarCombos()
        {
            List<BECliente> clientes = bllCliente.GetAll().Where(c => c.Activo).ToList();
            cmbDueno.DataSource = null;
            cmbDueno.DisplayMember = "NombreCompleto";
            cmbDueno.ValueMember = "IdCliente";
            cmbDueno.DataSource = clientes;

            List<BEVeterinario> veterinarios = bllVeterinario.GetAll().Where(v => v.Activo).ToList();
            cmbVeterinario.DataSource = null;
            cmbVeterinario.DisplayMember = "NombreCompleto";
            cmbVeterinario.ValueMember = "IdVeterinario";
            cmbVeterinario.DataSource = veterinarios;

            cmbTipoConsulta.DataSource = null;
            cmbTipoConsulta.DisplayMember = "NombreTipo";
            cmbTipoConsulta.ValueMember = "IdTipoConsulta";
            cmbTipoConsulta.DataSource = bllTipoConsulta.GetAll();
        }
        private DateTime ObtenerFechaHora()
        {
            return dtpFecha.Value.Date
                .AddHours(dtpHora.Value.Hour)
                .AddMinutes(dtpHora.Value.Minute);
        }

        private void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (turnoEditar == null)
                {
                    BEMascota mascota = cmbMascota.SelectedItem as BEMascota;
                    BEVeterinario veterinario = cmbVeterinario.SelectedItem as BEVeterinario;
                    BETipoConsulta tipo = cmbTipoConsulta.SelectedItem as BETipoConsulta;

                    if (mascota == null || veterinario == null || tipo == null)
                    {
                        MessageBox.Show("Debe completar todos los campos.");
                        return;
                    }

                    BETurno nuevo = new BETurno();
                    nuevo.FechaHora = ObtenerFechaHora();
                    nuevo.Mascota = mascota;
                    nuevo.Veterinario = veterinario;
                    nuevo.TipoConsulta = tipo;

                    bllTurno.Guardar(nuevo);
                    MessageBox.Show("Turno guardado correctamente.");
                }
                else
                {
                    turnoEditar.FechaHora = ObtenerFechaHora();

                    bllTurno.Modificar(turnoEditar);
                    MessageBox.Show("Turno modificado correctamente.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarMascotasDelDueno()
        {
            BECliente dueno = cmbDueno.SelectedItem as BECliente;
            if (dueno == null) return;

            List<BEMascota> mascotas = bllMascota.GetAll()
                .Where(m => m.Activo && m.Cliente.IdCliente == dueno.IdCliente)
                .ToList();

            cmbMascota.DataSource = mascotas;
            cmbMascota.DisplayMember = "Nombre";
            cmbMascota.ValueMember = "IdMascota";
        }


        private void cmbDueno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (turnoEditar == null)
            {
                CargarMascotasDelDueno();
            }
        }
        private void PrecargarDatos()
        {
            cmbDueno.SelectedValue = turnoEditar.Mascota.Cliente.IdCliente;

            List<BEMascota> soloEsta = new List<BEMascota> { turnoEditar.Mascota };
            cmbMascota.DataSource = soloEsta;
            cmbMascota.DisplayMember = "Nombre";
            cmbMascota.ValueMember = "IdMascota";

            cmbVeterinario.SelectedValue = turnoEditar.Veterinario.IdVeterinario;
            cmbTipoConsulta.SelectedValue = turnoEditar.TipoConsulta.IdTipoConsulta;

            dtpFecha.Value = turnoEditar.FechaHora;
            dtpHora.Value = turnoEditar.FechaHora;
        }
        private void BloquearParaModificacion()
        {
            cmbDueno.Enabled = false;
            cmbMascota.Enabled = false;
            cmbVeterinario.Enabled = false;
            cmbTipoConsulta.Enabled = false;
        }
    }
}
