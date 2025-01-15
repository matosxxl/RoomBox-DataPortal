using RoomBox___DataPortal.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomBox___DataPortal.Views
{
    public partial class InitialDashboardView : UserControl
    {
        public InitialDashboardView()
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

            bestSellingChart.DataSource = salesData;
            bestSellingChart.Binding = "Ventas";
            bestSellingChart.BindingName = "Articulos";
            bestSellingChart.DataLabel.Content = "{name} : {p:0}%";
            bestSellingChart.Header.Content = "Ejemplo de grafica a mostrar";
            bestSellingChart.Refresh();
        }
    }
}
