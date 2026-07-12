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
    public partial class FormVeterinarioAM : Form
    {
        private BLLVeterinario bllVeterinario = new BLLVeterinario();
        private BLLEspecialidad bllEspecialidad = new BLLEspecialidad();
        private BEVeterinario veterinarioEditar;
        public FormVeterinarioAM()
        {
            InitializeComponent();
            this.Text = "Nuevo veterinario";
            veterinarioEditar = null;
        }
        public FormVeterinarioAM(BEVeterinario veterinario)
        {
            InitializeComponent();
            veterinarioEditar = veterinario;
            this.Text = "Modificar veterinario";
        }
        private void FormVeterinarioAM_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();

            if (veterinarioEditar != null)
            {
                PrecargarDatos();
            }
        }

        private void CargarEspecialidades()
        {
            clbEspecialidades.DataSource = bllEspecialidad.GetAll();
            clbEspecialidades.ValueMember = "IdEspecialidad";
            clbEspecialidades.DisplayMember = "NombreEspecialidad";
        }

        private void PrecargarDatos()
        {
            txtNombreVet.Text = veterinarioEditar.Nombre;
            txtApellidoVet.Text = veterinarioEditar.Apellido;
            txtMatricula.Text = veterinarioEditar.Matricula;
            for (int i = 0; i < clbEspecialidades.Items.Count; i++)
            {
                BEEspecialidad esp = (BEEspecialidad)clbEspecialidades.Items[i];

                bool laTiene = false;
                foreach (BEEspecialidad e in veterinarioEditar.Especialidades)
                {
                    if (e.IdEspecialidad == esp.IdEspecialidad)
                    {
                        laTiene = true;
                        break;
                    }
                }

                clbEspecialidades.SetItemChecked(i, laTiene);
            }
        }
        private List<BEEspecialidad> ObtenerEspecialidadesSeleccionadas()
        {
            List<BEEspecialidad> seleccionadas = new List<BEEspecialidad>();
            foreach (var item in clbEspecialidades.CheckedItems)
            {
                seleccionadas.Add((BEEspecialidad)item);
            }
            return seleccionadas;
        }

        private void btnGuardarVet_Click(object sender, EventArgs e)
        {
            try
            {
                if (veterinarioEditar == null)
                {
                    BEVeterinario nuevo = new BEVeterinario();
                    nuevo.Nombre = txtNombreVet.Text;
                    nuevo.Apellido = txtApellidoVet.Text;
                    nuevo.Matricula = txtMatricula.Text;
                    nuevo.Especialidades = ObtenerEspecialidadesSeleccionadas();

                    bllVeterinario.Guardar(nuevo);
                    MessageBox.Show("Veterinario guardado correctamente.");
                }
                else
                {
                    veterinarioEditar.Nombre = txtNombreVet.Text;
                    veterinarioEditar.Apellido = txtApellidoVet.Text;
                    veterinarioEditar.Matricula = txtMatricula.Text;
                    veterinarioEditar.Especialidades = ObtenerEspecialidadesSeleccionadas();

                    bllVeterinario.Modificar(veterinarioEditar);
                    MessageBox.Show("Veterinario modificado correctamente.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarVet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
