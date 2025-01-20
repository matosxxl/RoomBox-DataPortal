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
    public partial class AnadirArticulo : UserControl
    {
        private String[] articleCategories = new String[] { "SOFA", "MESA", "SILLA", "CAMA", "ARMARIO", "ESTANTERIA", "ESCRITORIO", "COMODA", "LAMPARA", "ESPEJO", "ALFOMBRA", "DECORACION" };

        public AnadirArticulo()
        {
            InitializeComponent();
        }

        private void AnadirArticulo_Load(object sender, EventArgs e)
        {
            cboCategoria.Items.Clear();
            cboCategoria.DataSource = articleCategories;
            cboCategoria.Text = "";
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNombreArticulo.Text = "";
            txtDescripcion.Text = "";
            nudStock.Value = 0;
            cboCategoria.Text = "";
            txtUnitPrice.Text = "";
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

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            pbImagenArticulo.ImageLocation = null;
        }

        private bool checkUnitPrice()
        {
            try
            {
                var price = Convert.ToDecimal(txtUnitPrice.Text);
                if (price < 1)
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

        private async void btnCrearArticulo_Click(object sender, EventArgs e)
        {
            bool result = false;

            if (!isFormComplete())
            {
                MessageBox.Show("Por favor complete todos los campos para actualizar el articulo", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Article nuevoArticulo = new Article();
            nuevoArticulo.ArticleName = txtNombreArticulo.Text;
            nuevoArticulo.ArticleUnitPrice = txtUnitPrice.Text;
            nuevoArticulo.ArticleDescription = txtDescripcion.Text;
            nuevoArticulo.ArticleType = cboCategoria.Text;
            nuevoArticulo.ArticleStock = Convert.ToInt32(nudStock.Value);
            nuevoArticulo.ArticleStatus = true;

            Api http = Api.getInstance();

            if (File.Exists(pbImagenArticulo.ImageLocation))
            {
                result = await http.tryCreateArticle(nuevoArticulo, pbImagenArticulo.ImageLocation);

            }
            else
            {
                result = await http.tryCreateArticle(nuevoArticulo, null);
            }

            if (result != false)
            {
                MessageBox.Show($"Se ha creado el artículo con exito!", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se ha podido crear el articulo, por favor intentelo nuevamente", "Operacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
