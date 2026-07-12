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
    public partial class FormEspecialidades : Form
    {
        private BLLEspecialidad bllEspecialidad = new BLLEspecialidad();
        public FormEspecialidades()
        {
            InitializeComponent();
        }

        private void FormEspecialidades_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            try
            {
                dgvEspecialidades.DataSource = null;
                dgvEspecialidades.DataSource = bllEspecialidad.GetAll();
                dgvEspecialidades.Columns["IdEspecialidad"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BEEspecialidad nueva = new BEEspecialidad();
                nueva.NombreEspecialidad = txtNombreEsp.Text;

                bllEspecialidad.Guardar(nueva);
                MessageBox.Show("Especialidad agregada correctamente.");
                txtNombreEsp.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ActualizarGrilla();
            }
        }

        private void btnRenombrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEspecialidades.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una especialidad.");
                    return;
                }

                BEEspecialidad seleccionada = (BEEspecialidad)dgvEspecialidades.CurrentRow.DataBoundItem;
                seleccionada.NombreEspecialidad = txtNombreEsp.Text;

                bllEspecialidad.Modificar(seleccionada);
                MessageBox.Show("Especialidad renombrada correctamente.");
                txtNombreEsp.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ActualizarGrilla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEspecialidades.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una especialidad.");
                    return;
                }

                BEEspecialidad seleccionada = (BEEspecialidad)dgvEspecialidades.CurrentRow.DataBoundItem;

                DialogResult confirma = MessageBox.Show(
                    $"¿Eliminar la especialidad {seleccionada.NombreEspecialidad}?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

                if (confirma == DialogResult.Yes)
                {
                    bllEspecialidad.Eliminar(seleccionada.IdEspecialidad);
                    MessageBox.Show("Especialidad eliminada correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ActualizarGrilla();
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
