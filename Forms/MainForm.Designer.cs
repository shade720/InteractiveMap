namespace InteractiveMap.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MapView = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // MapView
            // 
            this.MapView.Bearing = 0F;
            this.MapView.CanDragMap = true;
            this.MapView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapView.EmptyTileColor = System.Drawing.Color.Navy;
            this.MapView.GrayScaleMode = false;
            this.MapView.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MapView.LevelsKeepInMemmory = 5;
            this.MapView.Location = new System.Drawing.Point(0, 0);
            this.MapView.MarkersEnabled = true;
            this.MapView.MaxZoom = 2;
            this.MapView.MinZoom = 16;
            this.MapView.MouseWheelZoomEnabled = true;
            this.MapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MapView.Name = "MapView";
            this.MapView.NegativeMode = false;
            this.MapView.PolygonsEnabled = true;
            this.MapView.RetryLoadTile = 0;
            this.MapView.RoutesEnabled = true;
            this.MapView.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MapView.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MapView.ShowTileGridLines = false;
            this.MapView.Size = new System.Drawing.Size(1382, 953);
            this.MapView.TabIndex = 1;
            this.MapView.Zoom = 0D;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 953);
            this.Controls.Add(this.MapView);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "InteractiveMap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl MapView;
    }
}

