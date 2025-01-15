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
            this.txtNombreArticulo = new TextBox();
            this.txtDescripcion = new TextBox();
            txtUnitPrice = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nudStock = new NumericUpDown();
            label6 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)tbl_Articulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // tbl_Articulos
            // 
            tbl_Articulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_Articulos.Location = new Point(34, 90);
            tbl_Articulos.Name = "tbl_Articulos";
            tbl_Articulos.RowHeadersWidth = 62;
            tbl_Articulos.Size = new Size(858, 535);
            tbl_Articulos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 26);
            label1.Name = "label1";
            label1.Size = new Size(406, 38);
            label1.TabIndex = 1;
            label1.Text = "Listado de articulos registrados:";
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new Point(943, 118);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new Size(299, 31);
            this.txtNombreArticulo.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new Point(943, 195);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new Size(299, 31);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(943, 364);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(299, 31);
            txtUnitPrice.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(943, 471);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 154);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(943, 90);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 7;
            label2.Text = "Nombre del artículo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(943, 167);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 8;
            label3.Text = "Descripción del artículo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(943, 252);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 9;
            label4.Text = "Cantidad en existencia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(943, 336);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 10;
            label5.Text = "Precio unitario:";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(943, 289);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(180, 31);
            nudStock.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(943, 433);
            label6.Name = "label6";
            label6.Size = new Size(184, 25);
            label6.TabIndex = 12;
            label6.Text = "Imagen del producto:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ListadoArticulos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(nudStock);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(txtUnitPrice);
            Controls.Add(this.txtDescripcion);
            Controls.Add(this.txtNombreArticulo);
            Controls.Add(label1);
            Controls.Add(tbl_Articulos);
            Name = "ListadoArticulos";
            Size = new Size(1320, 679);
            Load += ListadoArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)tbl_Articulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nudStock;
        private Label label6;
        private OpenFileDialog openFileDialog1;
    }
}