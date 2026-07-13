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
    public partial class FormCerrarAtencion : Form
    {
        private BLLTurno bllTurno = new BLLTurno();
        private BETurno turno;

        public FormCerrarAtencion()
        {
            InitializeComponent();
        }
        public FormCerrarAtencion(BETurno turnoSeleccionado)
        {
            InitializeComponent();
            turno = turnoSeleccionado;
        }

        private void FormCerrarAtencion_Load(object sender, EventArgs e)
        {
            this.Text = "Cerrar atencion — turno #" + turno.IdTurno;

            lblMascota.Text = turno.Mascota.Nombre + " (" + turno.Mascota.Cliente.Apellido + ", " + turno.Mascota.Cliente.Nombre + ")";
            lblVeterinario.Text = turno.Veterinario.Apellido + ", " + turno.Veterinario.Nombre;
            lblTipo.Text = turno.TipoConsulta.NombreTipo;
            lblFecha.Text = turno.FechaHora.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                bllTurno.CerrarAtencion(turno.IdTurno, txtDiagnostico.Text);
                MessageBox.Show("Atencion cerrada correctamente.");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
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
