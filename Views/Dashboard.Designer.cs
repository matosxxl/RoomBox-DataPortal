namespace RoomBox___DataPortal
{
    partial class Dashboard
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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            metricasMenuItem = new ToolStripMenuItem();
            productosMenuItem = new ToolStripMenuItem();
            rendimientoAnualMenuItem = new ToolStripMenuItem();
            rendimientoMensualMenuItem = new ToolStripMenuItem();
            rendimientoSemanalMenuItem = new ToolStripMenuItem();
            rendimientoHistoricoMenuItem = new ToolStripMenuItem();
            articulosMenuItem = new ToolStripMenuItem();
            anadirArticulosMenuItem = new ToolStripMenuItem();
            catalogoArticulosMenuItem = new ToolStripMenuItem();
            usuariosMenuItem = new ToolStripMenuItem();
            usuariosAdministrativosMenuItem = new ToolStripMenuItem();
            usuariosPersonalMenuItem = new ToolStripMenuItem();
            cuentaMenuItem = new ToolStripMenuItem();
            actualizarDatosMenuItem = new ToolStripMenuItem();
            cerrarSesionMenuItem = new ToolStripMenuItem();
            aplicacionMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            salirMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, metricasMenuItem, articulosMenuItem, usuariosMenuItem, cuentaMenuItem, aplicacionMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1254, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(70, 29);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // metricasMenuItem
            // 
            metricasMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosMenuItem });
            metricasMenuItem.Name = "metricasMenuItem";
            metricasMenuItem.Size = new Size(118, 29);
            metricasMenuItem.Text = "Estadísticas";
            // 
            // productosMenuItem
            // 
            productosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rendimientoAnualMenuItem, rendimientoMensualMenuItem, rendimientoSemanalMenuItem, rendimientoHistoricoMenuItem });
            productosMenuItem.Name = "productosMenuItem";
            productosMenuItem.Size = new Size(195, 34);
            productosMenuItem.Text = "Productos";
            // 
            // rendimientoAnualMenuItem
            // 
            rendimientoAnualMenuItem.Name = "rendimientoAnualMenuItem";
            rendimientoAnualMenuItem.Size = new Size(290, 34);
            rendimientoAnualMenuItem.Text = "Rendimiento Anual";
            // 
            // rendimientoMensualMenuItem
            // 
            rendimientoMensualMenuItem.Name = "rendimientoMensualMenuItem";
            rendimientoMensualMenuItem.Size = new Size(290, 34);
            rendimientoMensualMenuItem.Text = "Rendimiento Mensual";
            // 
            // rendimientoSemanalMenuItem
            // 
            rendimientoSemanalMenuItem.Name = "rendimientoSemanalMenuItem";
            rendimientoSemanalMenuItem.Size = new Size(290, 34);
            rendimientoSemanalMenuItem.Text = "Rendimiento Semanal";
            // 
            // rendimientoHistoricoMenuItem
            // 
            rendimientoHistoricoMenuItem.Name = "rendimientoHistoricoMenuItem";
            rendimientoHistoricoMenuItem.Size = new Size(290, 34);
            rendimientoHistoricoMenuItem.Text = "Rendimiento Histórico";
            // 
            // articulosMenuItem
            // 
            articulosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { anadirArticulosMenuItem, catalogoArticulosMenuItem });
            articulosMenuItem.Name = "articulosMenuItem";
            articulosMenuItem.Size = new Size(97, 29);
            articulosMenuItem.Text = "Artículos";
            // 
            // anadirArticulosMenuItem
            // 
            anadirArticulosMenuItem.Name = "anadirArticulosMenuItem";
            anadirArticulosMenuItem.Size = new Size(285, 34);
            anadirArticulosMenuItem.Text = "Añadir Artículos";
            anadirArticulosMenuItem.Click += anadirArticulosMenuItem_Click;
            // 
            // catalogoArticulosMenuItem
            // 
            catalogoArticulosMenuItem.Name = "catalogoArticulosMenuItem";
            catalogoArticulosMenuItem.Size = new Size(285, 34);
            catalogoArticulosMenuItem.Text = "Catalogo de Artículos";
            catalogoArticulosMenuItem.Click += catalogoArticulosMenuItem_Click;
            // 
            // usuariosMenuItem
            // 
            usuariosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosAdministrativosMenuItem, usuariosPersonalMenuItem });
            usuariosMenuItem.Name = "usuariosMenuItem";
            usuariosMenuItem.Size = new Size(96, 29);
            usuariosMenuItem.Text = "Usuarios";
            // 
            // usuariosAdministrativosMenuItem
            // 
            usuariosAdministrativosMenuItem.Name = "usuariosAdministrativosMenuItem";
            usuariosAdministrativosMenuItem.Size = new Size(311, 34);
            usuariosAdministrativosMenuItem.Text = "Usuarios Administrativos";
            usuariosAdministrativosMenuItem.Click += usuariosAdministrativosMenuItem_Click;
            // 
            // usuariosPersonalMenuItem
            // 
            usuariosPersonalMenuItem.Name = "usuariosPersonalMenuItem";
            usuariosPersonalMenuItem.Size = new Size(311, 34);
            usuariosPersonalMenuItem.Text = "Usuarios Personal";
            // 
            // cuentaMenuItem
            // 
            cuentaMenuItem.DropDownItems.AddRange(new ToolStripItem[] { actualizarDatosMenuItem, cerrarSesionMenuItem });
            cuentaMenuItem.Name = "cuentaMenuItem";
            cuentaMenuItem.Size = new Size(83, 29);
            cuentaMenuItem.Text = "Cuenta";
            // 
            // actualizarDatosMenuItem
            // 
            actualizarDatosMenuItem.Name = "actualizarDatosMenuItem";
            actualizarDatosMenuItem.Size = new Size(270, 34);
            actualizarDatosMenuItem.Text = "Actualizar Datos";
            // 
            // cerrarSesionMenuItem
            // 
            cerrarSesionMenuItem.Name = "cerrarSesionMenuItem";
            cerrarSesionMenuItem.Size = new Size(270, 34);
            cerrarSesionMenuItem.Text = "Cerrar Sesión";
            // 
            // aplicacionMenuItem
            // 
            aplicacionMenuItem.DropDownItems.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem, salirMenuItem });
            aplicacionMenuItem.Name = "aplicacionMenuItem";
            aplicacionMenuItem.Size = new Size(109, 29);
            aplicacionMenuItem.Text = "Aplicación";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.Enabled = false;
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(189, 34);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // salirMenuItem
            // 
            salirMenuItem.Name = "salirMenuItem";
            salirMenuItem.Size = new Size(189, 34);
            salirMenuItem.Text = "Salir";
            salirMenuItem.Click += salirMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 737);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem metricasMenuItem;
        private ToolStripMenuItem cuentaMenuItem;
        private ToolStripMenuItem productosMenuItem;
        private ToolStripMenuItem rendimientoAnualMenuItem;
        private ToolStripMenuItem rendimientoMensualMenuItem;
        private ToolStripMenuItem rendimientoSemanalMenuItem;
        private ToolStripMenuItem rendimientoHistoricoMenuItem;
        private ToolStripMenuItem actualizarDatosMenuItem;
        private ToolStripMenuItem cerrarSesionMenuItem;
        private ToolStripMenuItem aplicacionMenuItem;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem salirMenuItem;
        private ToolStripMenuItem articulosMenuItem;
        private ToolStripMenuItem anadirArticulosMenuItem;
        private ToolStripMenuItem catalogoArticulosMenuItem;
        private ToolStripMenuItem usuariosMenuItem;
        private ToolStripMenuItem usuariosAdministrativosMenuItem;
        private ToolStripMenuItem usuariosPersonalMenuItem;
        private ToolStripMenuItem inicioToolStripMenuItem;
    }
}