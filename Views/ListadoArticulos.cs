using Newtonsoft.Json;
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
        private int currentArticleId { get; set; }
        private Article _currentArticle { get; set; }
        private Article tmpArticle { get; set; }

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
            }
            else
            {
                MessageBox.Show("Por el momento no podemos procesar su transaccion", "Error en la integracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbl_Articulos.DataSource = _articles;
            tbl_Articulos.ReadOnly = true;
            tbl_Articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbl_Articulos.MultiSelect = false;
            tbl_Articulos.Refresh();
        }

        private async void reloadArticles()
        {
            Api http = Api.getInstance();
            var articles = await http.tryGetArticles();
            if (articles != null)
            {
                _articles = articles.Results;
            }
            else
            {
                MessageBox.Show("Por el momento no podemos procesar su transaccion", "Error en la integracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshTable()
        {
            tbl_Articulos.DataSource = _articles;
            tbl_Articulos.ReadOnly = true;
            tbl_Articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbl_Articulos.MultiSelect = false;
            tbl_Articulos.Refresh();
        }

        private void tbl_Articulos_SelectionChanged(object sender, EventArgs e)
        {
            if (tbl_Articulos.SelectedRows.Count > 0)
            {
                _currentArticle = _articles[tbl_Articulos.SelectedRows[0].Index];

                // Textos
                txtNombreArticulo.Text = _currentArticle.ArticleName;
                //txtDescripcion.Text = _currentArticle.ArticleDescription;
                txtDescripcion.Text = "Placeholder";

                // Numeros
                txtUnitPrice.Text = _currentArticle.ArticleUnitPrice;
                nudStock.Value = _currentArticle.ArticleStock;

                // Imagen
                if (_currentArticle.ImageUrl != null)
                {
                    pbImagenArticulo.Visible = true;
                    pbImagenArticulo.ImageLocation = _currentArticle.ImageUrl.ToString();
                    //pbImagenArticulo.Refresh();
                }
                else
                {
                    pbImagenArticulo.Visible = false;
                    pbImagenArticulo.ImageLocation = null;
                }

                btnActualizarArticulo.Enabled = true;
                btnAdjuntarFoto.Enabled = true;
                btnSwitchEstado.Enabled = true;

            }
            else
            {
                _currentArticle = null;
                btnActualizarArticulo.Enabled = false;
                btnSwitchEstado.Enabled = false;
                btnAdjuntarFoto.Enabled = false;
                txtNombreArticulo.Clear();
                txtDescripcion.Clear();
                nudStock.Value = 0;
                txtUnitPrice.Clear();
                pbImagenArticulo.Visible = false;
            }
        }

        private async void btnActualizarArticulo_Click(object sender, EventArgs e)
        {
            tmpArticle = _currentArticle.Snapshot();
            Article updatedArticle = null;
            try
            {
                tmpArticle.ArticleName = txtNombreArticulo.Text;
                tmpArticle.ArticleUnitPrice = txtUnitPrice.Text;
                tmpArticle.ArticleStock = (int)nudStock.Value;
                if (pbImagenArticulo.ImageLocation != null)
                {
                    tmpArticle.ImageUrl = new Uri(pbImagenArticulo.ImageLocation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contacte con su administrador", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show((JsonConvert.SerializeObject(tmpArticle) == JsonConvert.SerializeObject(_currentArticle)) ? "Son iguales, no se presentan cambios" : "Hay discrepancias");

            Api http = Api.getInstance();

            if (File.Exists(pbImagenArticulo.ImageLocation))
            {
                updatedArticle = await http.tryUpdateArticle(tmpArticle, pbImagenArticulo.ImageLocation);

            }
            else
            {
                updatedArticle = await http.tryUpdateArticle(tmpArticle, null);
            }

            if (updatedArticle != null)
            {
                MessageBox.Show($"Se ha modificado el artículo '{updatedArticle.ArticleName}' con exito! ID:{updatedArticle.ArticleId}", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadArticles();
                refreshTable();
            }
            else
            {
                MessageBox.Show($"No se ha podido modificar el articulo, por favor intentelo nuevamente", "Modificacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdjuntarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.svg";
                dialog.Title = "Seleccione la imagen del articulo";
                dialog.CheckFileExists = true;


                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    pbImagenArticulo.ImageLocation = dialog.FileName;
                    pbImagenArticulo.Visible = true;
                    MessageBox.Show($"El archivo seleccionado esta ubicado en: {dialog.FileName}", "Carga de imagen exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pbImagenArticulo_LocationChanged(object sender, EventArgs e)
        {
            pbImagenArticulo.Refresh();
        }

        private async void btnSwitchEstado_Click(object sender, EventArgs e)
        {
            Article tmpArticle = _currentArticle.Snapshot();
            tmpArticle.ArticleStatus = !tmpArticle.ArticleStatus;
            Api http = Api.getInstance();
            tmpArticle = await http.tryUpdateArticle(tmpArticle, null);

            if (tmpArticle != null && tmpArticle.ArticleStatus != _currentArticle.Snapshot().ArticleStatus)
            {
                reloadArticles();
                if (tmpArticle.ArticleStatus)
                {
                    MessageBox.Show("Se ha habilitado el articulo con exito", "Habilitacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se ha deshabilitado el articulo con exito", "Deshabilitacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                refreshTable();
            }
            else
            {
                MessageBox.Show("No se pudo procesar su transaccion", "Modificacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ListadoArticulos_Enter(object sender, EventArgs e)
        {
            reloadArticles();
            refreshTable();
        }
    }
}
