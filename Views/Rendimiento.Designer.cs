namespace RoomBox___DataPortal.Views
{
    partial class Rendimiento
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
            flexPie1 = new C1.Win.Chart.FlexPie();
            SuspendLayout();
            // 
            // flexPie1
            // 
            flexPie1.AnimationLoad.Attributes = C1.Chart.SliceAttribute.Radius;
            flexPie1.AnimationLoad.Duration = 400;
            flexPie1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexPie1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexPie1.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexPie1.AnimationUpdate.Duration = 400;
            flexPie1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexPie1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexPie1.DataLabel.Border = false;
            flexPie1.DataLabel.ConnectingLine = false;
            flexPie1.DataLabel.Content = null;
            flexPie1.DataLabel.Offset = 0;
            flexPie1.DataLabel.Overlapping = C1.Chart.PieLabelOverlapping.Default;
            flexPie1.DataLabel.Position = C1.Chart.PieLabelPosition.None;
            flexPie1.Legend.ItemMaxWidth = 0;
            flexPie1.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexPie1.Legend.Position = C1.Chart.Position.Right;
            flexPie1.Legend.Reversed = false;
            flexPie1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexPie1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexPie1.Legend.Title = null;
            flexPie1.Location = new Point(91, 94);
            flexPie1.Name = "flexPie1";
            flexPie1.SelectionStyle.StrokeColor = Color.Red;
            flexPie1.Size = new Size(600, 450);
            flexPie1.TabIndex = 0;
            flexPie1.Text = "flexPie1";
            flexPie1.Titles = null;
            // 
            // 
            // 
            flexPie1.ToolTip.Content = "";
            // 
            // Rendimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 784);
            Controls.Add(flexPie1);
            Name = "Rendimiento";
            Text = "Rendimiento";
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.Chart.FlexPie flexPie1;
    }
}