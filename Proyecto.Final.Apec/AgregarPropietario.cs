using Business;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class AgregarPropietario : Form
    {
        private PropietariosLogica propietariosLogica = new();

        public AgregarPropietario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNamePropietario.Text.Trim();
            string cedula = txtCedPropietario.Text.Trim();
            string telefono = txtTelPropieatrio.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Agregar todos los campos", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                Propietario propetario = new Propietario()
                {
                    Nombre = nombre,
                    Cedula = cedula,
                    Telefono = telefono
                };

                propietariosLogica.CreatePropietario(propetario);

                // Clear the input fields
                txtNamePropietario.Text = "";
                txtCedPropietario.Text = "";
                txtTelPropieatrio.Text = "";

                MessageBox.Show("Propietario agregado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
         

    }
}
