namespace RoomBox___DataPortal
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtClave = new TextBox();
            btnIniciarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(343, 209);
            label1.Name = "label1";
            label1.Size = new Size(193, 46);
            label1.TabIndex = 0;
            label1.Text = "RoomBox";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2024_11_27_at_20_15_06_f32f685a;
            pictureBox1.Location = new Point(343, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(339, 274);
            label2.Name = "label2";
            label2.Size = new Size(197, 28);
            label2.TabIndex = 2;
            label2.Text = "Portal Administrativo";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(343, 373);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(193, 31);
            txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(343, 349);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 4;
            label3.Text = "Nombre de usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(343, 430);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 6;
            label4.Text = "Contraseña:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(343, 454);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(193, 31);
            txtClave.TabIndex = 5;
            txtClave.UseSystemPasswordChar = true;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(343, 534);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(193, 54);
            btnIniciarSesion.TabIndex = 7;
            btnIniciarSesion.Text = "Iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 640);
            Controls.Add(btnIniciarSesion);
            Controls.Add(label4);
            Controls.Add(txtClave);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private Label label4;
        private TextBox txtClave;
        private Button btnIniciarSesion;
    }
}
