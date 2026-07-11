using BLL;

namespace VeterinariaLasLomas
{
    public partial class Form1 : Form
    {
        private BLLCliente bllCliente = new BLLCliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarGridCliente();

        }
        private void ActualizarGridCliente()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = bllCliente.GetAll();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FormClienteAM formClienteAM = new FormClienteAM();
            formClienteAM.ShowDialog();
        }
    }
}
