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

        private String[] articleCategories = new String[] { "SOFA", "MESA", "SILLA", "CAMA", "ARMARIO", "ESTANTERIA", "ESCRITORIO", "COMODA", "LAMPARA", "ESPEJO", "ALFOMBRA", "DECORACION" };

        public ListadoArticulos()
        {
            InitializeComponent();
            tbl_Articulos.Rows.Clear();
        }

        private async void ListadoArticulos_Load(object sender, EventArgs e)
        {
            cboCategoria.Items.Clear();
            cboCategoria.DataSource = articleCategories;
            cboCategoria.Text = "";
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

            Api http = Api.getInstance();
            _articles = await reloadArticles();

            tbl_Articulos.DataSource = _articles;
            tbl_Articulos.ReadOnly = true;
            tbl_Articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbl_Articulos.MultiSelect = false;
            tbl_Articulos.Refresh();
        }

        private async Task<List<Article>> reloadArticles()
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
                    } else
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

        private void refreshTable()
        {
            tbl_Articulos.DataSource = _articles;
            tbl_Articulos.ReadOnly = true;
            tbl_Articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbl_Articulos.MultiSelect = false;
            tbl_Articulos.Refresh();
        }

        private bool isFormComplete()
        {
            bool condition = !(String.IsNullOrWhiteSpace(txtNombreArticulo.Text) ||
                                String.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                                String.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                                cboCategoria.Text == "" ||
                                !checkUnitPrice());
            return condition;
        }

        private void tbl_Articulos_SelectionChanged(object sender, EventArgs e)
        {
            if (tbl_Articulos.SelectedRows.Count > 0)
            {
                _currentArticle = _articles[tbl_Articulos.SelectedRows[0].Index];

                // Textos
                txtNombreArticulo.Text = _currentArticle.ArticleName;
                //txtDescripcion.Text = _currentArticle.ArticleDescription;
                txtDescripcion.Text = _currentArticle.ArticleDescription;
                cboCategoria.Text = _currentArticle.ArticleType;

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
            if (!isFormComplete())
            {
                MessageBox.Show("Por favor complete todos los campos para actualizar el articulo", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                tmpArticle.ArticleName = txtNombreArticulo.Text;
                tmpArticle.ArticleUnitPrice = txtUnitPrice.Text;
                tmpArticle.ArticleStock = (int)nudStock.Value;
                tmpArticle.ArticleDescription = txtDescripcion.Text;
                tmpArticle.ArticleType = cboCategoria.Text;
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

            if (JsonConvert.SerializeObject(tmpArticle) == JsonConvert.SerializeObject(_currentArticle.Snapshot()))
            {
                MessageBox.Show("No ha modificado ningun campo en el formulario, por favor haga algun cambio y vuelva a intentarlo", "Articulo no ha sido modificado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            tmpArticle = await http.trySwitchStatusArticle(tmpArticle.ArticleId, tmpArticle.ArticleStatus);

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

        private async void ListadoArticulos_Enter(object sender, EventArgs e)
        {
            _articles = await reloadArticles();
            refreshTable();
        }

        private bool checkUnitPrice()
        {
            try
            {
                var price = Convert.ToDecimal(txtUnitPrice.Text);
                if (price < 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("El precio unitario debe ser un numero decimal positivo", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
