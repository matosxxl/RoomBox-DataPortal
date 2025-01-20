namespace RoomBox___DataPortal
{
    partial class anadirusuario
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
            txtUsername = new TextBox();
            label2 = new Label();
            txtapellidos = new TextBox();
            label3 = new Label();
            txtcedula = new TextBox();
            label4 = new Label();
            txtdireccion = new TextBox();
            label5 = new Label();
            txttelefonos = new TextBox();
            label6 = new Label();
            btnIniciarSesion = new Button();
            button1 = new Button();
            label8 = new Label();
            tbl_Perfiles = new DataGridView();
            label9 = new Label();
            txtcorreo = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)tbl_Perfiles).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(40, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 25);
            label1.TabIndex = 1;
            label1.Text = "Gestion de Perfiles: Personal Administrativo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(701, 127);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(372, 23);
            txtUsername.TabIndex = 4;
            txtUsername.ModifiedChanged += txtUsername_ModifiedChanged;
            txtUsername.MultilineChanged += txtUsername_MultilineChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(701, 110);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre(s):";
            // 
            // txtapellidos
            // 
            txtapellidos.Location = new Point(701, 190);
            txtapellidos.Margin = new Padding(2);
            txtapellidos.Name = "txtapellidos";
            txtapellidos.Size = new Size(372, 23);
            txtapellidos.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(701, 173);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 10;
            label3.Text = "Apellidos:";
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(701, 244);
            txtcedula.Margin = new Padding(2);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(176, 23);
            txtcedula.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(701, 227);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 12;
            label4.Text = "Cedula:";
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(700, 305);
            txtdireccion.Margin = new Padding(2);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(372, 23);
            txtdireccion.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(700, 288);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 14;
            label5.Text = "Direccion:";
            // 
            // txttelefonos
            // 
            txttelefonos.Location = new Point(897, 244);
            txttelefonos.Margin = new Padding(2);
            txttelefonos.Name = "txttelefonos";
            txttelefonos.Size = new Size(176, 23);
            txttelefonos.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(897, 227);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 17;
            label6.Text = "Telefono:";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(128, 255, 128);
            btnIniciarSesion.Location = new Point(700, 393);
            btnIniciarSesion.Margin = new Padding(2);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(135, 32);
            btnIniciarSesion.TabIndex = 18;
            btnIniciarSesion.Text = "Registrar Perfil";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(862, 393);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(135, 32);
            button1.TabIndex = 21;
            button1.Text = "Modificar Perfil";
            button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(40, 76);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(204, 19);
            label8.TabIndex = 22;
            label8.Text = "Lista de Personal Administrativo";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbl_Perfiles
            // 
            tbl_Perfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_Perfiles.Location = new Point(40, 97);
            tbl_Perfiles.Margin = new Padding(2);
            tbl_Perfiles.Name = "tbl_Perfiles";
            tbl_Perfiles.RowHeadersWidth = 62;
            tbl_Perfiles.Size = new Size(628, 513);
            tbl_Perfiles.TabIndex = 23;
            tbl_Perfiles.CellContentClick += tbl_Articulos_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(700, 339);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 24;
            label9.Text = "Correo:";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(700, 356);
            txtcorreo.Margin = new Padding(2);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(372, 23);
            txtcorreo.TabIndex = 25;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(701, 459);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(135, 32);
            button2.TabIndex = 26;
            button2.Text = "Eliminar Perfil";
            button2.UseVisualStyleBackColor = false;
            // 
            // anadirusuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(txtcorreo);
            Controls.Add(label9);
            Controls.Add(tbl_Perfiles);
            Controls.Add(label8);
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
            Controls.Add(label1);
            Name = "anadirusuario";
            Size = new Size(1188, 643);
            ((System.ComponentModel.ISupportInitialize)tbl_Perfiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtapellidos;
        private Label label3;
        private TextBox txtcedula;
        private Label label4;
        private TextBox txtdireccion;
        private Label label5;
        private TextBox txttelefonos;
        private Label label6;
        private Button btnIniciarSesion;
        private Button button1;
        private Label label8;
        private DataGridView tbl_Perfiles;
        private Label label9;
        private TextBox txtcorreo;
        private Button button2;
    }
}
