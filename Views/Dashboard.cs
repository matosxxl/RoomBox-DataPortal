using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers
using System.Windows.Forms;
using RoomBox___DataPortal.Dtos;
using C1.Win.Chart;
using RoomBox___DataPortal.Views;
using RoomBox___DataPortal.Service;

namespace RoomBox___DataPortal
{
    public partial class Dashboard : Form
    {
        readonly ListadoArticulos _listadoArticulosForm;
        readonly InitialDashboardView _initialDashboardView;
        readonly anadirusuario _anadirusuario;
        readonly anadirpersonal _anadirpersonal;
        readonly AnadirArticulo _anadirArticulo;
        readonly EstadisticasArticulos _estadisticasArticulos;
        public Dashboard(LoginResponse loginInfo)
        {
            InitializeComponent();

            _listadoArticulosForm = new ListadoArticulos() { Dock = DockStyle.Fill };
            _initialDashboardView = new InitialDashboardView() { Dock = DockStyle.Fill };
            _anadirusuario = new anadirusuario() { Dock = DockStyle.Fill };
            _anadirArticulo = new AnadirArticulo() { Dock = DockStyle.Fill };
            _anadirpersonal = new anadirpersonal() { Dock = DockStyle.Fill };
            _estadisticasArticulos = new EstadisticasArticulos() { Dock =DockStyle.Fill };

        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("¿Desea salir de la aplicación?", "Esto cerrará su sesión y se perderán los cambios no guardados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                this.DialogResult = confirm;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SwapView(_initialDashboardView);
        }
        private void SwapView(UserControl view)
        {
            this.Controls.OfType<UserControl>().ToList().ForEach(x => this.Controls.Remove(x));
            this.Controls.Add(view);
        }

        private void catalogoArticulosMenuItem_Click(object sender, EventArgs e)
        {
            SwapView(_listadoArticulosForm);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwapView(_initialDashboardView);
        }

        private void usuariosAdministrativosMenuItem_Click(object sender, EventArgs e)
        {
            SwapView(_anadirusuario);
        }


        private void usuariosPersonalMenuItem_Click(object sender, EventArgs e)
        {
            SwapView(_anadirpersonal);
        }

        private void anadirArticulosMenuItem_Click(object sender, EventArgs e)
        {
            SwapView(_anadirArticulo);
        }

        private void cerrarSesionMenuItem_Click(object sender, EventArgs e)
        {
            Api http = Api.getInstance();
            http.clearToken();
            this.DialogResult = DialogResult.Continue;
        }

        private void productosMenuItem_Click(object sender, EventArgs e)
        {
            SwapView(_estadisticasArticulos);
        }
    }
}
