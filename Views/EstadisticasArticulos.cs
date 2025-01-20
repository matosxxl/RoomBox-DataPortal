using C1.Chart;
using RoomBox___DataPortal.Dtos;
using RoomBox___DataPortal.Dtos.ArticleFrequency;
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
    public partial class EstadisticasArticulos : UserControl
    {
        private List<Article> _articles;
        private List<ArticleFrequencyResponse> _currentArticleFrequency = new List<ArticleFrequencyResponse>();
        public EstadisticasArticulos()
        {
            InitializeComponent();
        }

        private async void EstadisticasArticulos_Load(object sender, EventArgs e)
        {
            _articles = await getArticles();

            cboArticulos.Items.Clear();
            cboArticulos.DataSource = _articles;
            cboArticulos.ValueMember = "ArticleId";
            cboArticulos.DisplayMember = "ArticleName";
            cboArticulos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task<List<Article>> getArticles()
        {
            bool keepGoing = true;
            int counter = 1;
            ArticlesResponse response;
            List<Article> articles = new List<Article>();

            Api http = Api.getInstance();

            while (keepGoing)
            {
                response = await http.tryGetArticles(counter);
                if (response != null)
                {
                    foreach (Article art in response.Results)
                    {
                        articles.Add(art);
                    }
                    if (response.Next != null)
                    {
                        counter++;
                    }
                    else
                    {
                        keepGoing = false;
                    }
                }
                else
                {
                    MessageBox.Show("Por el momento no podemos procesar su transaccion", "Error en la integracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    keepGoing = false;
                }
            }

            return articles;
        }

        private async Task<List<ArticleFrequencyResponse>> getFrequency(int article_id)
        {
            Api http = Api.getInstance();
            var frequencies = await http.tryGetFrequency(article_id);

            if (frequencies != null)
            {
                return frequencies;
            }
            else
            {
                MessageBox.Show("Por el momento no podemos procesar su transaccion", "Error en la integracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private async void cboArticulos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboArticulos.SelectedValue.GetType() == typeof(int))
            {
                //MessageBox.Show($"{cboArticulos.SelectedValue}");

                var result = await getFrequency(Convert.ToInt32(cboArticulos.SelectedValue));

                if (result == null) { return; } 

                _currentArticleFrequency = result;

                // Set data source
                flexChart.DataSource = _currentArticleFrequency;

                // Configure axes and chart type
                flexChart.BindingX = "ArticleName"; // Use the ArticleName for X-axis labels
                flexChart.ChartType = C1.Chart.ChartType.Bar; // Bar chart

                // Clear previous
                flexChart.Series.Clear();

                // Add series for orders and quantities
                flexChart.Series.Add(new C1.Win.Chart.Series
                {
                    Name = "Ordenes",
                    Binding = "OrderCount" // Bind to OrderCount for Y-axis
                });

                flexChart.Series.Add(new C1.Win.Chart.Series
                {
                    Name = "Cantidad de articulos",
                    Binding = "TotalQuantityOrdered" // Bind to TotalQuantityOrdered for Y-axis
                });

                // Customize chart appearance
                flexChart.AxisX.Title = "Articulos"; // X-axis title
                flexChart.AxisY.Title = "Cantidad"; // Y-axis title
                flexChart.Header.Content = $"Cantidad vendida vs Ordenes recibidas para: {_currentArticleFrequency[0].ArticleName}"; // Chart title
                flexChart.Header.Style.Font = new Font("Arial", 14, FontStyle.Bold);

                // Optional: Customize legend position
                flexChart.Legend.Position = C1.Chart.Position.Right;
            }
        }
    }
}
