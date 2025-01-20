namespace RoomBox___DataPortal.Views
{
    partial class EstadisticasArticulos
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
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            label1 = new Label();
            label2 = new Label();
            cboArticulos = new ComboBox();
            flexChart = new C1.Win.Chart.FlexChart();
            ((System.ComponentModel.ISupportInitialize)flexChart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(642, 52);
            label1.Name = "label1";
            label1.Size = new Size(501, 45);
            label1.TabIndex = 0;
            label1.Text = "Estadisticas de ventas de artículos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(642, 142);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 1;
            label2.Text = "Artículo:";
            // 
            // cboArticulos
            // 
            cboArticulos.FormattingEnabled = true;
            cboArticulos.Location = new Point(749, 141);
            cboArticulos.Name = "cboArticulos";
            cboArticulos.Size = new Size(394, 33);
            cboArticulos.TabIndex = 2;
            cboArticulos.SelectedValueChanged += cboArticulos_SelectedValueChanged;
            // 
            // flexChart
            // 
            flexChart.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            flexChart.AnimationLoad.Duration = 400;
            flexChart.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexChart.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexChart.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexChart.AnimationUpdate.Duration = 400;
            flexChart.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexChart.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexChart.AxisX.AxisLine = true;
            flexChart.AxisX.Chart = flexChart;
            flexChart.AxisX.DataSource = null;
            flexChart.AxisX.Formatter = null;
            flexChart.AxisX.GroupProvider = null;
            flexChart.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart.AxisX.GroupVisibilityLevel = 0;
            flexChart.AxisX.PlotAreaName = null;
            flexChart.AxisX.Position = C1.Chart.Position.Bottom;
            flexChart.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart.AxisY.AxisLine = false;
            flexChart.AxisY.Chart = flexChart;
            flexChart.AxisY.DataSource = null;
            flexChart.AxisY.Formatter = null;
            flexChart.AxisY.GroupProvider = null;
            flexChart.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart.AxisY.GroupVisibilityLevel = 0;
            flexChart.AxisY.MajorGrid = true;
            flexChart.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            flexChart.AxisY.PlotAreaName = null;
            flexChart.AxisY.Position = C1.Chart.Position.Left;
            flexChart.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart.ChartType = C1.Chart.ChartType.Scatter;
            flexChart.DataLabel.Angle = 0;
            flexChart.DataLabel.Border = false;
            flexChart.DataLabel.ConnectingLine = false;
            flexChart.DataLabel.Content = null;
            flexChart.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            flexChart.DataLabel.MaxAutoLabels = 100;
            flexChart.DataLabel.MaxLines = 0;
            flexChart.DataLabel.MaxWidth = 0;
            flexChart.DataLabel.Offset = 0;
            flexChart.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            flexChart.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            flexChart.DataLabel.Position = C1.Chart.LabelPosition.None;
            flexChart.Legend.ItemMaxWidth = 0;
            flexChart.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexChart.Legend.Position = C1.Chart.Position.Right;
            flexChart.Legend.Reversed = false;
            flexChart.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexChart.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexChart.Legend.Title = null;
            flexChart.Location = new Point(304, 207);
            flexChart.Margin = new Padding(10);
            flexChart.Name = "flexChart";
            flexChart.Options.Chart = flexChart;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            flexChart.Options.ClusterSize = elementSize1;
            flexChart.PlotMargin = new Padding(0);
            flexChart.SelectedSeries = null;
            flexChart.SelectionStyle.StrokeColor = Color.Red;
            series1.DataLabel = null;
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            series1.Tooltip = null;
            flexChart.Series.Add(series1);
            flexChart.Size = new Size(1252, 635);
            flexChart.TabIndex = 3;
            flexChart.Text = "flexChart1";
            // 
            // 
            // 
            flexChart.ToolTip.Content = "";
            // 
            // EstadisticasArticulos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flexChart);
            Controls.Add(cboArticulos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EstadisticasArticulos";
            Size = new Size(1852, 879);
            Load += EstadisticasArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)flexChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboArticulos;
        private C1.Win.Chart.FlexChart flexChart;
    }
}
