using System;
using System.Device.Location;
using System.Windows.Forms;



namespace LocationApp
{
    public partial class Form1 : Form
    {
        GeoCoordinateWatcher watcher;

        public Form1()
        {
            InitializeComponent();
            InitializeGeoWatcher();
        }

        private void InitializeGeoWatcher()
        {
            watcher = new GeoCoordinateWatcher();
            watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(watcher_PositionChanged);
            watcher.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(watcher_StatusChanged);
            watcher.Start();
        }

        void watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            switch (e.Status)
            {
                case GeoPositionStatus.Ready:
                    // Location data is available
                    if (watcher.Position.Location.IsUnknown)
                    {
                        locationLabel.Text = "現在の位置: 不明";
                    }
                    else
                    {
                        GeoCoordinate co = watcher.Position.Location;
                        locationLabel.Text = $"現在の位置: 緯度 {co.Latitude}, 経度 {co.Longitude}";
                    }
                    break;
                case GeoPositionStatus.Initializing:
                    // Location is still initializing
                    locationLabel.Text = "現在の位置: 初期化中...";
                    break;
                case GeoPositionStatus.NoData:
                    // No location data available
                    locationLabel.Text = "現在の位置: データなし";
                    break;
                case GeoPositionStatus.Disabled:
                    // The location service is disabled
                    locationLabel.Text = "現在の位置: サービスが無効";
                    break;
            }
        }

        void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            GeoCoordinate co = e.Position.Location;
            if (!co.IsUnknown)
            {
                locationLabel.Text = $"現在の位置: 緯度 {co.Latitude}, 経度 {co.Longitude}";
            }
            else
            {
                locationLabel.Text = "現在の位置: 不明";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
