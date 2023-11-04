using Business;
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
    public partial class Propietarios : Form
    {
        private PropietariosLogica propietariosLogica = new();

        public Propietarios()
        {
            InitializeComponent();
            GetPropietarios();

        }

        private void GetPropietarios()
        {
            DataTable searchResults = propietariosLogica.GetPropietarios();
            DGridViewPropietarios.DataSource = searchResults;
        }

        #region EVENTS
        private void btnAgregarPropietario_Click(object sender, EventArgs e)
        {
            AgregarPropietario agregarPropietario = new AgregarPropietario();
            agregarPropietario.FormClosed += AgregarPropietarioFormClosed; 
            agregarPropietario.ShowDialog();
        
        }
        #endregion

        #region PRIVADE METHODS

        #endregion


        private void AgregarPropietarioFormClosed(object sender, FormClosedEventArgs e)
        {
            GetPropietarios();
        }

        private void btnBuscarPropietario_Click(object sender, EventArgs e)
        {
            DataTable searchResults = propietariosLogica.GetPropietarios(txtSearchPropietario.Text);

            DGridViewPropietarios.DataSource = searchResults;

        }
    }


}
