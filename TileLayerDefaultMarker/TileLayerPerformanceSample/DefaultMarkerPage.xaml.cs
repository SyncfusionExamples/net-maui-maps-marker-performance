using System.Diagnostics;
using Syncfusion.Maui.Maps;

namespace TileLayerPerformanceSample;

public partial class DefaultMarkerPage : ContentPage
{
    private readonly Stopwatch defaultMarkerStopwatch = new();

    private readonly Stopwatch zoomStopwatch = new();
    private readonly Stopwatch panStopwatch = new();

    private bool isZooming;
    private bool isPanning;

    public DefaultMarkerPage()
    {
        defaultMarkerStopwatch.Start();

        InitializeComponent();

        MapMarkerCollection markers = CreateDefaultMarkers();
        titleLayer.Markers = markers;
        defaultMarkerStopwatch.Stop();
        DefaultMarkerCountLabel.Text = $"Default Marker Count: {markers.Count}";
        DefaultMarkerTimeLabel.Text = $"Default Marker Render Time: " + $"{defaultMarkerStopwatch.Elapsed.TotalMilliseconds:F0} ms";
    }

    private void TitleLayer_ZoomLevelChanging(object sender, ZoomLevelChangingEventArgs e)
    {
        if (!isZooming)
        {
            isZooming = true;
            zoomStopwatch.Restart();
        }

        ZoomTimeLabel.Text =
            $"Zoom Active: {zoomStopwatch.Elapsed.TotalMilliseconds:F0} ms";

        Dispatcher.DispatchDelayed(TimeSpan.FromMilliseconds(300), () =>
        {
            isZooming = false;
            zoomStopwatch.Stop();

            ZoomTimeLabel.Text =
                $"Last Zoom Duration: {zoomStopwatch.Elapsed.TotalMilliseconds:F0} ms";
        });
    }

    private void TitleLayer_Panning(object sender, PanningEventArgs e)
    {
        if (!isPanning)
        {
            isPanning = true;
            panStopwatch.Restart();
        }

        PanTimeLabel.Text =
            $"Pan Active: {panStopwatch.Elapsed.TotalMilliseconds:F0} ms";

        Dispatcher.DispatchDelayed(TimeSpan.FromMilliseconds(300), () =>
        {
            isPanning = false;
            panStopwatch.Stop();

            PanTimeLabel.Text =
                $"Last Pan Duration: {panStopwatch.Elapsed.TotalMilliseconds:F0} ms";
        });
    }

    private static MapMarkerCollection CreateDefaultMarkers()
    {
        MapMarkerCollection markers = new();

        foreach (CountryLocation country in CountryLocationData.Countries)
        {
            markers.Add(
                new MapMarker
                {
                    Latitude = country.Latitude,
                    Longitude = country.Longitude
                });
        }

        return markers;
    }

}
