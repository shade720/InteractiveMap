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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HeightBar = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MapView
            // 
            this.MapView.Bearing = 0F;
            this.MapView.CanDragMap = true;
            this.MapView.EmptyTileColor = System.Drawing.Color.Navy;
            this.MapView.GrayScaleMode = false;
            this.MapView.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MapView.LevelsKeepInMemmory = 5;
            this.MapView.Location = new System.Drawing.Point(23, 31);
            this.MapView.MarkersEnabled = true;
            this.MapView.MaxZoom = 2;
            this.MapView.MinZoom = 2;
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
            this.MapView.Size = new System.Drawing.Size(979, 876);
            this.MapView.TabIndex = 0;
            this.MapView.Zoom = 0D;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MapView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 929);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HeightBar);
            this.groupBox2.Location = new System.Drawing.Point(1043, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 929);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // HeightBar
            // 
            this.HeightBar.Location = new System.Drawing.Point(20, 31);
            this.HeightBar.Maximum = 16;
            this.HeightBar.Minimum = 2;
            this.HeightBar.Name = "HeightBar";
            this.HeightBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.HeightBar.Size = new System.Drawing.Size(56, 892);
            this.HeightBar.TabIndex = 0;
            this.HeightBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.HeightBar.Value = 2;
            this.HeightBar.Scroll += new System.EventHandler(this.HeightBar_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 953);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "InteractiveMap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl MapView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar HeightBar;
    }
}

