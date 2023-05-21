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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CursorLatitude = new System.Windows.Forms.Label();
            this.CursorLongitude = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.MapView.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.MapView_OnMarkerEnter);
            this.MapView.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.MapView_OnMarkerLeave);
            this.MapView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MapView_MouseDown);
            this.MapView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapView_MouseMove);
            this.MapView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MapView_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CursorLongitude);
            this.groupBox1.Controls.Add(this.CursorLatitude);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 176);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Longitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Latitude:";
            // 
            // CursorLatitude
            // 
            this.CursorLatitude.AutoSize = true;
            this.CursorLatitude.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CursorLatitude.Location = new System.Drawing.Point(109, 69);
            this.CursorLatitude.Name = "CursorLatitude";
            this.CursorLatitude.Size = new System.Drawing.Size(96, 25);
            this.CursorLatitude.TabIndex = 7;
            this.CursorLatitude.Text = "53,063463";
            // 
            // CursorLongitude
            // 
            this.CursorLongitude.AutoSize = true;
            this.CursorLongitude.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CursorLongitude.Location = new System.Drawing.Point(109, 105);
            this.CursorLongitude.Name = "CursorLongitude";
            this.CursorLongitude.Size = new System.Drawing.Size(96, 25);
            this.CursorLongitude.TabIndex = 8;
            this.CursorLongitude.Text = "53,063463";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 953);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MapView);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "InteractiveMap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl MapView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CursorLongitude;
        private System.Windows.Forms.Label CursorLatitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

