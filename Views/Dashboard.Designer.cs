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
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            menuStrip1 = new MenuStrip();
            metricasMenuItem = new ToolStripMenuItem();
            productosMenuItem = new ToolStripMenuItem();
            rendimientoAnualMenuItem = new ToolStripMenuItem();
            rendimientoMensualMenuItem = new ToolStripMenuItem();
            rendimientoSemanalMenuItem = new ToolStripMenuItem();
            rendimientoHistoricoMenuItem = new ToolStripMenuItem();
            cuentaMenuItem = new ToolStripMenuItem();
            actualizarDatosMenuItem = new ToolStripMenuItem();
            cerrarSesionMenuItem = new ToolStripMenuItem();
            aplicacionMenuItem = new ToolStripMenuItem();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            salirMenuItem = new ToolStripMenuItem();
            monthlyRevenue = new C1.Win.Chart.FlexChart();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)monthlyRevenue).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { metricasMenuItem, cuentaMenuItem, aplicacionMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1255, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
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
            actualizarDatosMenuItem.Size = new Size(242, 34);
            actualizarDatosMenuItem.Text = "Actualizar Datos";
            // 
            // cerrarSesionMenuItem
            // 
            cerrarSesionMenuItem.Name = "cerrarSesionMenuItem";
            cerrarSesionMenuItem.Size = new Size(242, 34);
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
            // monthlyRevenue
            // 
            monthlyRevenue.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            monthlyRevenue.AnimationLoad.Duration = 400;
            monthlyRevenue.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            monthlyRevenue.AnimationLoad.Type = C1.Chart.AnimationType.All;
            monthlyRevenue.AnimationSettings = C1.Chart.AnimationSettings.None;
            monthlyRevenue.AnimationUpdate.Duration = 400;
            monthlyRevenue.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            monthlyRevenue.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            monthlyRevenue.AxisX.AxisLine = true;
            monthlyRevenue.AxisX.Chart = monthlyRevenue;
            monthlyRevenue.AxisX.DataSource = null;
            monthlyRevenue.AxisX.Formatter = null;
            monthlyRevenue.AxisX.GroupProvider = null;
            monthlyRevenue.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            monthlyRevenue.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            monthlyRevenue.AxisX.GroupVisibilityLevel = 0;
            monthlyRevenue.AxisX.PlotAreaName = null;
            monthlyRevenue.AxisX.Position = C1.Chart.Position.Bottom;
            monthlyRevenue.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            monthlyRevenue.AxisY.AxisLine = false;
            monthlyRevenue.AxisY.Chart = monthlyRevenue;
            monthlyRevenue.AxisY.DataSource = null;
            monthlyRevenue.AxisY.Formatter = null;
            monthlyRevenue.AxisY.GroupProvider = null;
            monthlyRevenue.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            monthlyRevenue.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            monthlyRevenue.AxisY.GroupVisibilityLevel = 0;
            monthlyRevenue.AxisY.MajorGrid = true;
            monthlyRevenue.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            monthlyRevenue.AxisY.PlotAreaName = null;
            monthlyRevenue.AxisY.Position = C1.Chart.Position.Left;
            monthlyRevenue.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            monthlyRevenue.DataLabel.Angle = 0;
            monthlyRevenue.DataLabel.Border = false;
            monthlyRevenue.DataLabel.ConnectingLine = false;
            monthlyRevenue.DataLabel.Content = null;
            monthlyRevenue.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            monthlyRevenue.DataLabel.MaxAutoLabels = 100;
            monthlyRevenue.DataLabel.MaxLines = 0;
            monthlyRevenue.DataLabel.MaxWidth = 0;
            monthlyRevenue.DataLabel.Offset = 0;
            monthlyRevenue.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            monthlyRevenue.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            monthlyRevenue.DataLabel.Position = C1.Chart.LabelPosition.None;
            monthlyRevenue.Legend.ItemMaxWidth = 0;
            monthlyRevenue.Legend.Orientation = C1.Chart.Orientation.Auto;
            monthlyRevenue.Legend.Position = C1.Chart.Position.Right;
            monthlyRevenue.Legend.Reversed = false;
            monthlyRevenue.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            monthlyRevenue.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            monthlyRevenue.Legend.Title = "";
            monthlyRevenue.LegendToggle = true;
            monthlyRevenue.Location = new Point(42, 43);
            monthlyRevenue.Margin = new Padding(10);
            monthlyRevenue.Name = "monthlyRevenue";
            monthlyRevenue.Options.Chart = monthlyRevenue;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            monthlyRevenue.Options.ClusterSize = elementSize1;
            monthlyRevenue.Palette = C1.Chart.Palette.Cocoa;
            monthlyRevenue.PlotMargin = new Padding(0);
            monthlyRevenue.SelectedSeries = null;
            monthlyRevenue.SelectionStyle.StrokeColor = Color.Red;
            series1.DataLabel = null;
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            series1.Tooltip = null;
            monthlyRevenue.Series.Add(series1);
            monthlyRevenue.Size = new Size(600, 450);
            monthlyRevenue.TabIndex = 1;
            monthlyRevenue.Text = "flexChart1";
            // 
            // 
            // 
            monthlyRevenue.ToolTip.Content = "";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 737);
            Controls.Add(monthlyRevenue);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)monthlyRevenue).EndInit();
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
        private C1.Win.Chart.FlexChart monthlyRevenue;
    }
}