using RoomBox___DataPortal.Dtos;
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
    public partial class ListadoArticulos : UserControl
    {
        private List<Article> _articles { get; set; }
        public ListadoArticulos()
        {
            InitializeComponent();
            tbl_Articulos.Rows.Clear();
        }

        private async void ListadoArticulos_Load(object sender, EventArgs e)
        {
            Api http = Api.getInstance();
            var articles = await http.tryGetArticles();
            if (articles != null)
            {
                _articles = articles.Results;
            } else
            {
                MessageBox.Show("Por el momento no podemos procesar su transaccion", "Error en la integracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbl_Articulos.DataSource = _articles;
            tbl_Articulos.ReadOnly = true;
            tbl_Articulos.Refresh();
        }
    }
}
