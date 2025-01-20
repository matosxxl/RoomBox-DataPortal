namespace RoomBox___DataPortal.Views
{
    partial class AnadirArticulo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCrearArticulo = new Button();
            label6 = new Label();
            nudStock = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pbImagenArticulo = new PictureBox();
            txtUnitPrice = new TextBox();
            txtDescripcion = new TextBox();
            txtNombreArticulo = new TextBox();
            btnAdjuntarFoto = new Button();
            btnEliminarImagen = new Button();
            btnReset = new Button();
            cboCategoria = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagenArticulo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(723, 45);
            label1.Name = "label1";
            label1.Size = new Size(356, 38);
            label1.TabIndex = 2;
            label1.Text = "Registrar un nuevo artículo:";
            // 
            // btnCrearArticulo
            // 
            btnCrearArticulo.BackColor = Color.Lime;
            btnCrearArticulo.Location = new Point(723, 741);
            btnCrearArticulo.Name = "btnCrearArticulo";
            btnCrearArticulo.Size = new Size(356, 57);
            btnCrearArticulo.TabIndex = 24;
            btnCrearArticulo.Text = "Registrar artículo:";
            btnCrearArticulo.UseVisualStyleBackColor = false;
            btnCrearArticulo.Click += btnCrearArticulo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(980, 126);
            label6.Name = "label6";
            label6.Size = new Size(168, 25);
            label6.TabIndex = 23;
            label6.Text = "Imagen del artículo:";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(446, 438);
            nudStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(191, 31);
            nudStock.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(657, 401);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 21;
            label5.Text = "Precio unitario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 401);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 20;
            label4.Text = "Cantidad en existencia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 200);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 19;
            label3.Text = "Descripción del artículo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 123);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 18;
            label2.Text = "Nombre del artículo:";
            // 
            // pbImagenArticulo
            // 
            pbImagenArticulo.Location = new Point(980, 164);
            pbImagenArticulo.Name = "pbImagenArticulo";
            pbImagenArticulo.Size = new Size(428, 395);
            pbImagenArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagenArticulo.TabIndex = 17;
            pbImagenArticulo.TabStop = false;
            pbImagenArticulo.LocationChanged += pbImagenArticulo_LocationChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(657, 437);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(190, 31);
            txtUnitPrice.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(446, 228);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(401, 160);
            txtDescripcion.TabIndex = 15;
            // 
            // txtNombreArticulo
            // 
            txtNombreArticulo.Location = new Point(446, 151);
            txtNombreArticulo.Name = "txtNombreArticulo";
            txtNombreArticulo.Size = new Size(401, 31);
            txtNombreArticulo.TabIndex = 14;
            // 
            // btnAdjuntarFoto
            // 
            btnAdjuntarFoto.BackColor = SystemColors.ActiveCaption;
            btnAdjuntarFoto.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdjuntarFoto.Location = new Point(980, 584);
            btnAdjuntarFoto.Name = "btnAdjuntarFoto";
            btnAdjuntarFoto.Size = new Size(194, 53);
            btnAdjuntarFoto.TabIndex = 25;
            btnAdjuntarFoto.Text = "Modificar imagen";
            btnAdjuntarFoto.UseVisualStyleBackColor = false;
            btnAdjuntarFoto.Click += btnAdjuntarFoto_Click;
            // 
            // btnEliminarImagen
            // 
            btnEliminarImagen.BackColor = Color.IndianRed;
            btnEliminarImagen.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarImagen.Location = new Point(1212, 584);
            btnEliminarImagen.Name = "btnEliminarImagen";
            btnEliminarImagen.Size = new Size(196, 53);
            btnEliminarImagen.TabIndex = 26;
            btnEliminarImagen.Text = "Eliminar Imagen";
            btnEliminarImagen.UseVisualStyleBackColor = false;
            btnEliminarImagen.Click += btnEliminarImagen_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LightGray;
            btnReset.Location = new Point(446, 581);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(401, 57);
            btnReset.TabIndex = 27;
            btnReset.Text = "Reestablecer campos";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(446, 526);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(401, 33);
            cboCategoria.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 488);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 28;
            label7.Text = "Categoría:";
            // 
            // AnadirArticulo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cboCategoria);
            Controls.Add(label7);
            Controls.Add(btnReset);
            Controls.Add(btnEliminarImagen);
            Controls.Add(btnAdjuntarFoto);
            Controls.Add(btnCrearArticulo);
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
            Name = "AnadirArticulo";
            Size = new Size(1824, 911);
            Load += AnadirArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagenArticulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCrearArticulo;
        private Label label6;
        private NumericUpDown nudStock;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pbImagenArticulo;
        private TextBox txtUnitPrice;
        private TextBox txtDescripcion;
        private TextBox txtNombreArticulo;
        private Button btnAdjuntarFoto;
        private Button btnEliminarImagen;
        private Button btnReset;
        private ComboBox cboCategoria;
        private Label label7;
    }
}
