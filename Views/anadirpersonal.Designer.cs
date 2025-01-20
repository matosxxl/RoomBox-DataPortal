namespace RoomBox___DataPortal.Views
{
    partial class anadirpersonal
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
            label8 = new Label();
            tbl_Perfiles = new DataGridView();
            btnCambiarEstado = new Button();
            txtCorreo = new TextBox();
            label9 = new Label();
            btnModificar = new Button();
            btnRegistrar = new Button();
            label6 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtCedula = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label7 = new Label();
            txtEmployeeNo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tbl_Perfiles).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(51, 82);
            label1.Name = "label1";
            label1.Size = new Size(367, 38);
            label1.TabIndex = 2;
            label1.Text = "Gestion de Perfiles: Personal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(51, 142);
            label8.Name = "label8";
            label8.Size = new Size(156, 28);
            label8.TabIndex = 23;
            label8.Text = "Lista de Personal";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbl_Perfiles
            // 
            tbl_Perfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_Perfiles.Location = new Point(51, 190);
            tbl_Perfiles.Name = "tbl_Perfiles";
            tbl_Perfiles.RowHeadersWidth = 62;
            tbl_Perfiles.Size = new Size(897, 700);
            tbl_Perfiles.TabIndex = 24;
            tbl_Perfiles.SelectionChanged += tbl_Perfiles_SelectionChanged;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.BackColor = Color.IndianRed;
            btnCambiarEstado.ForeColor = SystemColors.Desktop;
            btnCambiarEstado.Location = new Point(1267, 793);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(250, 63);
            btnCambiarEstado.TabIndex = 41;
            btnCambiarEstado.Text = "Habilitar / Deshabilitar";
            btnCambiarEstado.UseVisualStyleBackColor = false;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(986, 600);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(530, 31);
            txtCorreo.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(986, 572);
            label9.Name = "label9";
            label9.Size = new Size(70, 25);
            label9.TabIndex = 39;
            label9.Text = "Correo:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ActiveCaption;
            btnModificar.Location = new Point(988, 793);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(250, 63);
            btnModificar.TabIndex = 38;
            btnModificar.Text = "Modificar Perfil";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(128, 255, 128);
            btnRegistrar.Location = new Point(986, 670);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(530, 62);
            btnRegistrar.TabIndex = 37;
            btnRegistrar.Text = "Registrar Perfil";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1267, 385);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 36;
            label6.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(1267, 413);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 31);
            txtTelefono.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(986, 478);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 34;
            label5.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(986, 515);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(530, 31);
            txtDireccion.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(987, 385);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 32;
            label4.Text = "Cedula:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(987, 413);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(250, 31);
            txtCedula.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1260, 190);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 30;
            label3.Text = "Apellidos:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(1260, 218);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(257, 31);
            txtApellido.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(987, 190);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 28;
            label2.Text = "Nombre(s):";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(987, 218);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 31);
            txtNombre.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(988, 281);
            label7.Name = "label7";
            label7.Size = new Size(185, 25);
            label7.TabIndex = 43;
            label7.Text = "Codigo de empleado:";
            // 
            // txtEmployeeNo
            // 
            txtEmployeeNo.Location = new Point(988, 318);
            txtEmployeeNo.Name = "txtEmployeeNo";
            txtEmployeeNo.Size = new Size(530, 31);
            txtEmployeeNo.TabIndex = 42;
            // 
            // anadirpersonal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(txtEmployeeNo);
            Controls.Add(btnCambiarEstado);
            Controls.Add(txtCorreo);
            Controls.Add(label9);
            Controls.Add(btnModificar);
            Controls.Add(btnRegistrar);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtCedula);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(tbl_Perfiles);
            Controls.Add(label8);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "anadirpersonal";
            Size = new Size(1657, 1045);
            Load += anadirpersonal_Load;
            Enter += anadirpersonal_Enter;
            ((System.ComponentModel.ISupportInitialize)tbl_Perfiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label8;
        private DataGridView tbl_Perfiles;
        private Button btnCambiarEstado;
        private TextBox txtCorreo;
        private Label label9;
        private Button btnModificar;
        private Button btnRegistrar;
        private Label label6;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtCedula;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label label7;
        private TextBox txtEmployeeNo;
    }
}
