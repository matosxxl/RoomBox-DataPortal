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

namespace RoomBox___DataPortal
{
    public partial class Dashboard : Form
    {
        public Dashboard( string access_token, string refresh_token, string user_type)
        {
            InitializeComponent();

            var salesData = new List<SalesDto>();
            salesData.Add(new SalesDto() { Mes = "Enero", Ventas = 2500, Gastos = 1200 });
            salesData.Add(new SalesDto() { Mes = "Febrero", Ventas = 2750, Gastos = 850 });
            salesData.Add(new SalesDto() { Mes = "Marzo", Ventas = 3185, Gastos = 643 });
            salesData.Add(new SalesDto() { Mes = "Abril", Ventas = 3444, Gastos = 601 });

            monthlyRevenue.DataSource = salesData;
            monthlyRevenue.Binding = "Ventas";
            monthlyRevenue.BindingX = "Mes";
            monthlyRevenue.Refresh();

        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("¿Desea salir de la aplicación?", "Esto cerrará su sesión y se perderán los cambios no guardados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.DialogResult = confirm;
        }
    }
}
