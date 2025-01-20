using RoomBox___DataPortal.Dtos;
using RoomBox___DataPortal.Dtos.Orders;
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
        private List<Order> orders = new List<Order>();
        public InitialDashboardView()
        {
            InitializeComponent();

            // Begin Mock
            orders.Add(new Order() { Customer = 1, OrderAmount = "7999.99", OrderDatePlaced = DateTime.Now.AddDays(-58), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-58)});
            orders.Add(new Order() { Customer = 1, OrderAmount = "6999.99", OrderDatePlaced = DateTime.Now.AddDays(-97), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-97) });
            orders.Add(new Order() { Customer = 1, OrderAmount = "1999.99", OrderDatePlaced = DateTime.Now.AddDays(-22), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-22) });
            orders.Add(new Order() { Customer = 1, OrderAmount = "765.99", OrderDatePlaced = DateTime.Now.AddDays(-105), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-105) });
            orders.Add(new Order() { Customer = 1, OrderAmount = "8499.99", OrderDatePlaced = DateTime.Now.AddDays(-34), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-34) });
            orders.Add(new Order() { Customer = 1, OrderAmount = "12349.99", OrderDatePlaced = DateTime.Now.AddDays(-76), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-76) });
            orders.Add(new Order() { Customer = 1, OrderAmount = "10000.99", OrderDatePlaced = DateTime.Now.AddDays(-15), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-15) });
            orders.Add(new Order() { Customer = 1, OrderAmount = "459.99", OrderDatePlaced = DateTime.Now.AddDays(-88), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-88) });
            orders.Add(new Order() { Customer = 2, OrderAmount = "3516.53", OrderDatePlaced = DateTime.Now.AddDays(-49), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-49) });
            orders.Add(new Order() { Customer = 2, OrderAmount = "18916.69", OrderDatePlaced = DateTime.Now.AddDays(-68), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-68) });
            orders.Add(new Order() { Customer = 2, OrderAmount = "18307.38", OrderDatePlaced = DateTime.Now.AddDays(-3), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-3) });
            orders.Add(new Order() { Customer = 2, OrderAmount = "16358.03", OrderDatePlaced = DateTime.Now.AddDays(-117), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-117) });
            orders.Add(new Order() { Customer = 2, OrderAmount = "2612.98", OrderDatePlaced = DateTime.Now.AddDays(-43), OrderStatus = "Placed", CreatedAt = DateTime.Now.AddDays(-43) });
            orders.Add(new Order() { Customer = 2, OrderAmount = "16500.33", OrderDatePlaced = DateTime.Now, OrderStatus = "Placed", CreatedAt = DateTime.Now });
            orders.Add(new Order() { Customer = 2, OrderAmount = "10171.81", OrderDatePlaced = DateTime.Now, OrderStatus = "Placed", CreatedAt = DateTime.Now });
            orders.Add(new Order() { Customer = 2, OrderAmount = "3227.16", OrderDatePlaced = DateTime.Now, OrderStatus = "Placed", CreatedAt = DateTime.Now });
            orders.Add(new Order() { Customer = 2, OrderAmount = "7520.18", OrderDatePlaced = DateTime.Now, OrderStatus = "Placed", CreatedAt = DateTime.Now });


            var salesData = new List<SalesDto>();
            salesData.Add(new SalesDto() { Mes = "Enero", Ventas = 2500, Gastos = 1200 });
            salesData.Add(new SalesDto() { Mes = "Febrero", Ventas = 2750, Gastos = 850 });
            salesData.Add(new SalesDto() { Mes = "Marzo", Ventas = 3185, Gastos = 643 });
            salesData.Add(new SalesDto() { Mes = "Abril", Ventas = 3444, Gastos = 601 });

            monthlyRevenue.DataSource = orders;
            monthlyRevenue.Binding = "OrderAmount";
            monthlyRevenue.BindingX = "OrderDatePlaced";
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
