namespace RoomBox___DataPortal.Views
{
    partial class ListadoArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbl_Articulos = new DataGridView();
            label1 = new Label();
            txtNombreArticulo = new TextBox();
            txtDescripcion = new TextBox();
            txtUnitPrice = new TextBox();
            pbImagenArticulo = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nudStock = new NumericUpDown();
            label6 = new Label();
            openFileDialog = new OpenFileDialog();
            btnActualizarArticulo = new Button();
            btnSwitchEstado = new Button();
            btnAdjuntarFoto = new Button();
            ((System.ComponentModel.ISupportInitialize)tbl_Articulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagenArticulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // tbl_Articulos
            // 
            tbl_Articulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_Articulos.Location = new Point(34, 90);
            tbl_Articulos.Name = "tbl_Articulos";
            tbl_Articulos.RowHeadersWidth = 62;
            tbl_Articulos.Size = new Size(1221, 823);
            tbl_Articulos.TabIndex = 0;
            tbl_Articulos.SelectionChanged += tbl_Articulos_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(276, 38);
            label1.TabIndex = 1;
            label1.Text = "Artículos registrados:";
            // 
            // txtNombreArticulo
            // 
            txtNombreArticulo.Location = new Point(1306, 114);
            txtNombreArticulo.Name = "txtNombreArticulo";
            txtNombreArticulo.Size = new Size(299, 31);
            txtNombreArticulo.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(1306, 191);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(299, 160);
            txtDescripcion.TabIndex = 3;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(1306, 476);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(299, 31);
            txtUnitPrice.TabIndex = 5;
            // 
            // pbImagenArticulo
            // 
            pbImagenArticulo.Location = new Point(1306, 583);
            pbImagenArticulo.Name = "pbImagenArticulo";
            pbImagenArticulo.Size = new Size(299, 254);
            pbImagenArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagenArticulo.TabIndex = 6;
            pbImagenArticulo.TabStop = false;
            pbImagenArticulo.LocationChanged += pbImagenArticulo_LocationChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1306, 86);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 7;
            label2.Text = "Nombre del artículo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1306, 163);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 8;
            label3.Text = "Descripción del artículo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1306, 364);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 9;
            label4.Text = "Cantidad en existencia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1306, 448);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 10;
            label5.Text = "Precio unitario:";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(1306, 401);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(180, 31);
            nudStock.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1306, 545);
            label6.Name = "label6";
            label6.Size = new Size(184, 25);
            label6.TabIndex = 12;
            label6.Text = "Imagen del producto:";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // btnActualizarArticulo
            // 
            btnActualizarArticulo.BackColor = Color.Lime;
            btnActualizarArticulo.Location = new Point(1306, 856);
            btnActualizarArticulo.Name = "btnActualizarArticulo";
            btnActualizarArticulo.Size = new Size(299, 57);
            btnActualizarArticulo.TabIndex = 13;
            btnActualizarArticulo.Text = "Actualizar artículo";
            btnActualizarArticulo.UseVisualStyleBackColor = false;
            btnActualizarArticulo.Click += btnActualizarArticulo_Click;
            // 
            // btnSwitchEstado
            // 
            btnSwitchEstado.BackColor = Color.FromArgb(255, 128, 128);
            btnSwitchEstado.ForeColor = SystemColors.ActiveCaptionText;
            btnSwitchEstado.Location = new Point(1631, 840);
            btnSwitchEstado.Name = "btnSwitchEstado";
            btnSwitchEstado.Size = new Size(148, 73);
            btnSwitchEstado.TabIndex = 14;
            btnSwitchEstado.Text = "Habilitar / Deshabilitar";
            btnSwitchEstado.UseVisualStyleBackColor = false;
            btnSwitchEstado.Click += btnSwitchEstado_Click;
            // 
            // btnAdjuntarFoto
            // 
            btnAdjuntarFoto.BackColor = SystemColors.ActiveCaption;
            btnAdjuntarFoto.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdjuntarFoto.Location = new Point(1631, 583);
            btnAdjuntarFoto.Name = "btnAdjuntarFoto";
            btnAdjuntarFoto.Size = new Size(148, 53);
            btnAdjuntarFoto.TabIndex = 15;
            btnAdjuntarFoto.Text = "Modificar imagen";
            btnAdjuntarFoto.UseVisualStyleBackColor = false;
            btnAdjuntarFoto.Click += btnAdjuntarFoto_Click;
            // 
            // ListadoArticulos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdjuntarFoto);
            Controls.Add(btnSwitchEstado);
            Controls.Add(btnActualizarArticulo);
            Controls.Add(label6);
            Controls.Add(nudStock);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pbImagenArticulo);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreArticulo);
            Controls.Add(label1);
            Controls.Add(tbl_Articulos);
            Name = "ListadoArticulos";
            Size = new Size(1811, 959);
            Load += ListadoArticulos_Load;
            Enter += ListadoArticulos_Enter;
            ((System.ComponentModel.ISupportInitialize)tbl_Articulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagenArticulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tbl_Articulos;
        private Label label1;
        private TextBox txtNombreArticulo;
        private TextBox txtDescripcion;
        private TextBox textBox3;
        private TextBox txtUnitPrice;
        private PictureBox pbImagenArticulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nudStock;
        private Label label6;
        private OpenFileDialog openFileDialog;
        private Button btnActualizarArticulo;
        private Button btnSwitchEstado;
        private Button btnAdjuntarFoto;
    }
}