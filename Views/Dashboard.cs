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

namespace RoomBox___DataPortal
{
    public partial class Dashboard : Form
    {
        readonly ListadoArticulos _listadoArticulosForm;
        readonly InitialDashboardView _initialDashboardView;
        readonly anadirusuario _anadirusuario;
        public Dashboard(LoginResponse loginInfo)
        {
            InitializeComponent();

            _listadoArticulosForm = new ListadoArticulos() { Dock = DockStyle.Fill };
            _initialDashboardView = new InitialDashboardView() { Dock = DockStyle.Fill };
            _anadirusuario = new anadirusuario() { Dock = DockStyle.Fill };
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("¿Desea salir de la aplicación?", "Esto cerrará su sesión y se perderán los cambios no guardados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.DialogResult = confirm;
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
    }
}
