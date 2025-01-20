namespace RoomBox___DataPortal.Views
{
    partial class InitialDashboardView
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
            label3 = new Label();
            bestSellingChart = new C1.Win.Chart.FlexPie();
            monthlyRevenue = new C1.Win.Chart.FlexChart();
            ((System.ComponentModel.ISupportInitialize)monthlyRevenue).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(790, 61);
            label3.Name = "label3";
            label3.Size = new Size(291, 45);
            label3.TabIndex = 10;
            label3.Text = "Bienvenido, admin!";
            // 
            // bestSellingChart
            // 
            bestSellingChart.AnimationLoad.Attributes = C1.Chart.SliceAttribute.Radius;
            bestSellingChart.AnimationLoad.Duration = 400;
            bestSellingChart.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            bestSellingChart.AnimationLoad.Type = C1.Chart.AnimationType.All;
            bestSellingChart.AnimationSettings = C1.Chart.AnimationSettings.None;
            bestSellingChart.AnimationUpdate.Duration = 400;
            bestSellingChart.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            bestSellingChart.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            bestSellingChart.DataLabel.Border = false;
            bestSellingChart.DataLabel.ConnectingLine = false;
            bestSellingChart.DataLabel.Content = null;
            bestSellingChart.DataLabel.Offset = 0;
            bestSellingChart.DataLabel.Overlapping = C1.Chart.PieLabelOverlapping.Default;
            bestSellingChart.DataLabel.Position = C1.Chart.PieLabelPosition.None;
            bestSellingChart.Legend.ItemMaxWidth = 0;
            bestSellingChart.Legend.Orientation = C1.Chart.Orientation.Auto;
            bestSellingChart.Legend.Position = C1.Chart.Position.Right;
            bestSellingChart.Legend.Reversed = false;
            bestSellingChart.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            bestSellingChart.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            bestSellingChart.Legend.Title = null;
            bestSellingChart.Location = new Point(964, 134);
            bestSellingChart.Name = "bestSellingChart";
            bestSellingChart.SelectionStyle.StrokeColor = Color.Red;
            bestSellingChart.Size = new Size(820, 668);
            bestSellingChart.TabIndex = 8;
            bestSellingChart.Text = "flexPie1";
            bestSellingChart.Titles = null;
            // 
            // 
            // 
            bestSellingChart.ToolTip.Content = "";
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
            monthlyRevenue.Location = new Point(73, 142);
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
            monthlyRevenue.Size = new Size(840, 660);
            monthlyRevenue.TabIndex = 6;
            monthlyRevenue.Text = "flexChart1";
            // 
            // 
            // 
            monthlyRevenue.ToolTip.Content = "";
            // 
            // InitialDashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(bestSellingChart);
            Controls.Add(monthlyRevenue);
            Name = "InitialDashboardView";
            Size = new Size(1850, 871);
            Load += InitialDashboardView_Load;
            ((System.ComponentModel.ISupportInitialize)monthlyRevenue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private C1.Win.Chart.FlexPie bestSellingChart;
        private C1.Win.Chart.FlexChart monthlyRevenue;
    }
}
