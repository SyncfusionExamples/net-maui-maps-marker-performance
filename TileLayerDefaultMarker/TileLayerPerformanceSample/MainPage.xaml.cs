using Syncfusion.Maui.Maps;
using System.Diagnostics;

namespace TileLayerPerformanceSample
{
    public partial class MainPage : ContentPage
    {
        private readonly Stopwatch stopwatch = new();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            stopwatch.Start();
            mapTitleLayer.UrlTemplate = "https://tile.openstreetmap.org/{z}/{x}/{y}.png";
            stopwatch.Stop();

            InitialRenderTimeLabel.Text = $"Title Layer Render Time: " + $"{stopwatch.Elapsed.TotalMilliseconds:F0} ms";
        }
    }
}
