using C1.Chart;
using C1.Win.Chart;
using RoomBox___DataPortal.Dtos;
using RoomBox___DataPortal.Dtos.ArticleFrequency;
using RoomBox___DataPortal.Dtos.MonthlySales;
using RoomBox___DataPortal.Dtos.Orders;
using RoomBox___DataPortal.Service;
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
        private List<ArticleFrequencyResponse> _frequencies = new List<ArticleFrequencyResponse>();
        private List<MonthlySales> _sales = new List<MonthlySales>();
        public InitialDashboardView()
        {
            InitializeComponent();

        }

        private async void loadFrequencies()
        {
            Api http = Api.getInstance();
            var frequencies = await http.tryGetFrequency(0);

            if (frequencies != null)
            {
                _frequencies = frequencies.OrderByDescending(f => f.TotalQuantityOrdered).ToList();
                monthlyRevenue.DataSource = frequencies;
                // Configure FlexChart
                monthlyRevenue.ChartType = ChartType.Bar; // Use vertical bar chart
                monthlyRevenue.DataSource = _frequencies; // Bind the data source
                monthlyRevenue.BindingX = "ArticleName"; // Bind X-axis to article names
                monthlyRevenue.Series.Clear();

                // Add a series to represent the total quantity ordered
                var series = new Series
                {
                    Name = "Orders",
                    Binding = "TotalQuantityOrdered" // Bind Y-axis to the total quantity
                };
                monthlyRevenue.Series.Add(series);
                monthlyRevenue.AxisY.Reversed = true;

                // Optional: Add title
                monthlyRevenue.Header.Content = $"Articulos mas vendidos ({_frequencies[0].TimePeriod})";
                monthlyRevenue.Header.Style.Font = new Font("Arial", 14, FontStyle.Bold);

                // Optional: Customize axis
                monthlyRevenue.AxisX.Title = "Cantidad vendida";
                monthlyRevenue.AxisY.Title = "Articulos";

                // Optional: Customize legend
                monthlyRevenue.Legend.Position = Position.Right;
                monthlyRevenue.Refresh();
            }
            else
            {
                MessageBox.Show("Por el momento no podemos procesar su transaccion", "Error en la integracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void loadMonthlySales()
        {
            Api http = Api.getInstance();
            var sales = await http.tryGetMonthlySales();

            if (sales != null)
            {
                _sales = sales.Where(f => f.Month != "Undefined").ToList();

                // Configure the FlexPie
                bestSellingChart.DataSource = _sales; // Bind the data
                bestSellingChart.Binding = "Total"; // Bind the value field (Total)
                bestSellingChart.BindingName = "Month"; // Bind the name field (Month)

                // Optional: Customize title
                bestSellingChart.Header.Content = "Ventas Mensuales"; // Chart title
                bestSellingChart.Header.Style.Font = new Font("Arial", 14, FontStyle.Bold);

                // Optional: Customize legend
                bestSellingChart.Legend.Position = C1.Chart.Position.Right; // Place legend to the right

                // Refresh the chart to apply changes
                bestSellingChart.Refresh();
            }
        }

        private void InitialDashboardView_Load(object sender, EventArgs e)
        {
            loadFrequencies();
            loadMonthlySales();
        }
    }
}
