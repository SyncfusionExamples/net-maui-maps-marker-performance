using Syncfusion.Maui.Maps;
using System.Diagnostics;

namespace TileLayerPerformanceSample;

public partial class CustomMarkerPage : ContentPage
{
    private readonly Stopwatch customMarkerStopwatch = new();
    private readonly Stopwatch zoomStopwatch = new();
    private readonly Stopwatch panStopwatch = new();
    private bool isZooming;
    private bool isPanning;

    public CustomMarkerPage()
    {
        customMarkerStopwatch.Start();
        InitializeComponent();
        MapMarkerCollection markers = CreateCustomMarkers();
        titleLayer.Markers = markers;
        titleLayer.Sublayers.Add(PolylineData.CreatePolylineLayer());
        customMarkerStopwatch.Stop();
        CustomMarkerCountLabel.Text = $"Custom Markers: {markers.Count} | Polylines: {PolylineData.PolylineCount}";
        CustomMarkerTimeLabel.Text = $"Map Layer Setup Time: {customMarkerStopwatch.Elapsed.TotalMilliseconds:F0} ms";
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

    private static MapMarkerCollection CreateCustomMarkers()
    {
        MapMarkerCollection markers = new();

        foreach (CountryLocation country in CountryLocationData.Countries)
        {
            markers.Add(
                new MapMarker
                {
                    Latitude = country.Latitude,
                    Longitude = country.Longitude,

                    HorizontalAlignment =
                        MapAlignment.Center,

                    VerticalAlignment =
                        MapAlignment.Start
                });
        }

        return markers;
    }
}