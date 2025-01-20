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
            button2 = new Button();
            txtcorreo = new TextBox();
            label9 = new Label();
            button1 = new Button();
            btnIniciarSesion = new Button();
            label6 = new Label();
            txttelefonos = new TextBox();
            label5 = new Label();
            txtdireccion = new TextBox();
            label4 = new Label();
            txtcedula = new TextBox();
            label3 = new Label();
            txtapellidos = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
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
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(987, 772);
            button2.Name = "button2";
            button2.Size = new Size(193, 53);
            button2.TabIndex = 41;
            button2.Text = "Eliminar Perfil";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(986, 600);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(530, 31);
            txtcorreo.TabIndex = 40;
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
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(1217, 662);
            button1.Name = "button1";
            button1.Size = new Size(193, 53);
            button1.TabIndex = 38;
            button1.Text = "Modificar Perfil";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(128, 255, 128);
            btnIniciarSesion.Location = new Point(986, 662);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(193, 53);
            btnIniciarSesion.TabIndex = 37;
            btnIniciarSesion.Text = "Registrar Perfil";
            btnIniciarSesion.UseVisualStyleBackColor = false;
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
            // txttelefonos
            // 
            txttelefonos.Location = new Point(1267, 413);
            txttelefonos.Name = "txttelefonos";
            txttelefonos.Size = new Size(250, 31);
            txttelefonos.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(986, 487);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 34;
            label5.Text = "Direccion:";
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(986, 515);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(530, 31);
            txtdireccion.TabIndex = 33;
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
            // txtcedula
            // 
            txtcedula.Location = new Point(987, 413);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(250, 31);
            txtcedula.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(987, 295);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 30;
            label3.Text = "Apellidos:";
            // 
            // txtapellidos
            // 
            txtapellidos.Location = new Point(987, 323);
            txtapellidos.Name = "txtapellidos";
            txtapellidos.Size = new Size(530, 31);
            txtapellidos.TabIndex = 29;
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
            // txtUsername
            // 
            txtUsername.Location = new Point(987, 218);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(530, 31);
            txtUsername.TabIndex = 27;
            // 
            // anadirpersonal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(txtcorreo);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(btnIniciarSesion);
            Controls.Add(label6);
            Controls.Add(txttelefonos);
            Controls.Add(label5);
            Controls.Add(txtdireccion);
            Controls.Add(label4);
            Controls.Add(txtcedula);
            Controls.Add(label3);
            Controls.Add(txtapellidos);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(tbl_Perfiles);
            Controls.Add(label8);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "anadirpersonal";
            Size = new Size(1657, 1045);
            Load += anadirpersonal_Load;
            ((System.ComponentModel.ISupportInitialize)tbl_Perfiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label8;
        private DataGridView tbl_Perfiles;
        private Button button2;
        private TextBox txtcorreo;
        private Label label9;
        private Button button1;
        private Button btnIniciarSesion;
        private Label label6;
        private TextBox txttelefonos;
        private Label label5;
        private TextBox txtdireccion;
        private Label label4;
        private TextBox txtcedula;
        private Label label3;
        private TextBox txtapellidos;
        private Label label2;
        private TextBox txtUsername;
    }
}
