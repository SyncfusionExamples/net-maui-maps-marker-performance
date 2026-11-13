using System.Collections.ObjectModel;
using Syncfusion.Maui.Maps;

namespace TileLayerPerformanceSample;

public sealed class CountryLocation
{
    public CountryLocation(string countryName, double latitude, double longitude)
    {
        CountryName = countryName;
        Latitude = latitude;
        Longitude = longitude;
    }

    public string CountryName { get; }

    public double Latitude { get; }

    public double Longitude { get; }
}

public static class CountryLocationData
{
    public static IReadOnlyList<CountryLocation> Countries { get; } =
Enumerable.Range(0, 150)
    .Select(i => new CountryLocation(
        $"Marker {i + 1}",
        20 + (i % 15) * 0.3,      // Latitude range: 20.0 - 24.2
        70 + (i / 15) * 0.6))     // Longitude range: 70.0 - 75.4
    .ToList();
}

public static class PolylineData
{
    public const int PolylineCount = 200;

    /// <summary>
    /// Creates a MapPolylineLayer with 200 polylines, some with up to 4,000 points.
    /// </summary>
    public static MapPolylineLayer CreatePolylineLayer()
    {
        Random random = new(42);
        MapPolylineLayer layer = new();

        for (int i = 0; i < PolylineCount; i++)
        {
            // Polylines at indices divisible by 10 have 4,000 points;
            // the remaining polylines have between 50 and 500 points.
            int pointCount = (i % 10 == 0) ? 4000 : random.Next(50, 501);

            double latitude = 20.0 + random.NextDouble() * 4.2;
            double longitude = 70.0 + random.NextDouble() * 5.4;

            ObservableCollection<MapLatLng> points = new();
            for (int p = 0; p < pointCount; p++)
            {
                points.Add(new MapLatLng(latitude, longitude));
                latitude = Math.Clamp(latitude + (random.NextDouble() - 0.5) * 0.02, -80.0, 80.0);
                longitude += (random.NextDouble() - 0.5) * 0.02;
            }

            layer.Polylines.Add(new MapPolyline
            {
                Points = points,
                Stroke = new SolidColorBrush(Color.FromHsla((float)(i / (double)PolylineCount), 0.7f, 0.45f)),
                StrokeThickness = 2
            });
        }

        return layer;
    }
}
