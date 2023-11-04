using CapaVisual;

namespace Proyecto.Final.Apec
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inmueblesButton_Click(object sender, EventArgs e)
        {
            var inmuebles = new Inmuebles();
            inmuebles.ShowDialog();
        }

        private void clientesButton_Click(object sender, EventArgs e)
        {
            var clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void propietariosBtn_Click(object sender, EventArgs e)
        {
            var propietarios= new Propietarios();
            propietarios.ShowDialog();
        }
    }
}