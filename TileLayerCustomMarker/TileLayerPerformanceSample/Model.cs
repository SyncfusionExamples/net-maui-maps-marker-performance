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