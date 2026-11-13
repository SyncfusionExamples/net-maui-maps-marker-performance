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
    /// <summary>
    /// 150 real-world cities and landmarks distributed across all inhabited continents.
    /// </summary>
    public static IReadOnlyList<CountryLocation> Countries { get; } = new CountryLocation[]
    {
        new("Tokyo, Japan", 35.6762, 139.6503),
        new("Osaka, Japan", 34.6937, 135.5023),
        new("Nagoya, Japan", 35.1815, 136.9066),
        new("Fukuoka, Japan", 33.5904, 130.4017),
        new("Sapporo, Japan", 43.0618, 141.3545),
        new("Seoul, South Korea", 37.5665, 126.978),
        new("Busan, South Korea", 35.1796, 129.0756),
        new("Beijing, China", 39.9042, 116.4074),
        new("Shanghai, China", 31.2304, 121.4737),
        new("Guangzhou, China", 23.1291, 113.2644),
        new("Shenzhen, China", 22.5431, 114.0579),
        new("Hong Kong, China", 22.3193, 114.1694),
        new("Taipei, Taiwan", 25.033, 121.5654),
        new("Chengdu, China", 30.5728, 104.0668),
        new("Chongqing, China", 29.563, 106.5516),
        new("Xi'an, China", 34.3416, 108.9398),
        new("Wuhan, China", 30.5928, 114.3055),
        new("Hangzhou, China", 30.2741, 120.1551),
        new("Ulaanbaatar, Mongolia", 47.8864, 106.9057),
        new("Delhi, India", 28.6139, 77.209),
        new("Mumbai, India", 19.076, 72.8777),
        new("Kolkata, India", 22.5726, 88.3639),
        new("Bengaluru, India", 12.9716, 77.5946),
        new("Chennai, India", 13.0827, 80.2707),
        new("Hyderabad, India", 17.385, 78.4867),
        new("Ahmedabad, India", 23.0225, 72.5714),
        new("Karachi, Pakistan", 24.8607, 67.0011),
        new("Lahore, Pakistan", 31.5204, 74.3587),
        new("Islamabad, Pakistan", 33.6844, 73.0479),
        new("Dhaka, Bangladesh", 23.8103, 90.4125),
        new("Colombo, Sri Lanka", 6.9271, 79.8612),
        new("Kathmandu, Nepal", 27.7172, 85.324),
        new("Bangkok, Thailand", 13.7563, 100.5018),
        new("Chiang Mai, Thailand", 18.7883, 98.9853),
        new("Singapore, Singapore", 1.3521, 103.8198),
        new("Kuala Lumpur, Malaysia", 3.139, 101.6869),
        new("Jakarta, Indonesia", -6.2088, 106.8456),
        new("Surabaya, Indonesia", -7.2575, 112.7521),
        new("Manila, Philippines", 14.5995, 120.9842),
        new("Cebu, Philippines", 10.3157, 123.8854),
        new("Ho Chi Minh City, Vietnam", 10.8231, 106.6297),
        new("Hanoi, Vietnam", 21.0285, 105.8542),
        new("Yangon, Myanmar", 16.8661, 96.1951),
        new("Phnom Penh, Cambodia", 11.5564, 104.9282),
        new("Dubai, UAE", 25.2048, 55.2708),
        new("Abu Dhabi, UAE", 24.4539, 54.3773),
        new("Doha, Qatar", 25.2854, 51.531),
        new("Riyadh, Saudi Arabia", 24.7136, 46.6753),
        new("Jeddah, Saudi Arabia", 21.4858, 39.1925),
        new("Muscat, Oman", 23.588, 58.3829),
        new("Kuwait City, Kuwait", 29.3759, 47.9774),
        new("Tehran, Iran", 35.6892, 51.389),
        new("Baghdad, Iraq", 33.3152, 44.3661),
        new("Tel Aviv, Israel", 32.0853, 34.7818),
        new("Amman, Jordan", 31.9454, 35.9284),
        new("Beirut, Lebanon", 33.8938, 35.5018),
        new("Tashkent, Uzbekistan", 41.2995, 69.2401),
        new("Almaty, Kazakhstan", 43.222, 76.8512),
        new("Baku, Azerbaijan", 40.4093, 49.8671),
        new("Tbilisi, Georgia", 41.7151, 44.8271),
        new("London, UK", 51.5074, -0.1278),
        new("Edinburgh, UK", 55.9533, -3.1883),
        new("Manchester, UK", 53.4808, -2.2426),
        new("Dublin, Ireland", 53.3498, -6.2603),
        new("Paris, France", 48.8566, 2.3522),
        new("Marseille, France", 43.2965, 5.3698),
        new("Lyon, France", 45.764, 4.8357),
        new("Madrid, Spain", 40.4168, -3.7038),
        new("Barcelona, Spain", 41.3879, 2.1699),
        new("Lisbon, Portugal", 38.7223, -9.1393),
        new("Porto, Portugal", 41.1579, -8.6291),
        new("Rome, Italy", 41.9028, 12.4964),
        new("Milan, Italy", 45.4642, 9.19),
        new("Berlin, Germany", 52.52, 13.405),
        new("Munich, Germany", 48.1351, 11.582),
        new("Frankfurt, Germany", 50.1109, 8.6821),
        new("Hamburg, Germany", 53.5511, 9.9937),
        new("Amsterdam, Netherlands", 52.3676, 4.9041),
        new("Brussels, Belgium", 50.8503, 4.3517),
        new("Vienna, Austria", 48.2082, 16.3738),
        new("Zurich, Switzerland", 47.3769, 8.5417),
        new("Geneva, Switzerland", 46.2044, 6.1432),
        new("Stockholm, Sweden", 59.3293, 18.0686),
        new("Oslo, Norway", 59.9139, 10.7522),
        new("Copenhagen, Denmark", 55.6761, 12.5683),
        new("Helsinki, Finland", 60.1699, 24.9384),
        new("Warsaw, Poland", 52.2297, 21.0122),
        new("Prague, Czech Republic", 50.0755, 14.4378),
        new("Budapest, Hungary", 47.4979, 19.0402),
        new("Bucharest, Romania", 44.4268, 26.1025),
        new("Athens, Greece", 37.9838, 23.7275),
        new("Istanbul, Turkey", 41.0082, 28.9784),
        new("Ankara, Turkey", 39.9334, 32.8597),
        new("Kyiv, Ukraine", 50.4501, 30.5234),
        new("Reykjavik, Iceland", 64.1466, -21.9426),
        new("New York, USA", 40.7128, -74.006),
        new("Los Angeles, USA", 34.0522, -118.2437),
        new("Chicago, USA", 41.8781, -87.6298),
        new("Houston, USA", 29.7604, -95.3698),
        new("Phoenix, USA", 33.4484, -112.074),
        new("Philadelphia, USA", 39.9526, -75.1652),
        new("Dallas, USA", 32.7767, -96.797),
        new("San Francisco, USA", 37.7749, -122.4194),
        new("Seattle, USA", 47.6062, -122.3321),
        new("Denver, USA", 39.7392, -104.9903),
        new("Boston, USA", 42.3601, -71.0589),
        new("Atlanta, USA", 33.749, -84.388),
        new("Miami, USA", 25.7617, -80.1918),
        new("Washington D.C., USA", 38.9072, -77.0369),
        new("Honolulu, USA", 21.3069, -157.8583),
        new("Anchorage, USA", 61.2181, -149.9003),
        new("Toronto, Canada", 43.6532, -79.3832),
        new("Montreal, Canada", 45.5017, -73.5673),
        new("Vancouver, Canada", 49.2827, -123.1207),
        new("Calgary, Canada", 51.0447, -114.0719),
        new("Ottawa, Canada", 45.4215, -75.6972),
        new("Mexico City, Mexico", 19.4326, -99.1332),
        new("Guadalajara, Mexico", 20.6597, -103.3496),
        new("Monterrey, Mexico", 25.6866, -100.3161),
        new("Cancun, Mexico", 21.1619, -86.8515),
        new("Havana, Cuba", 23.1136, -82.3666),
        new("Santo Domingo, Dominican Republic", 18.4861, -69.9312),
        new("Panama City, Panama", 8.9824, -79.5199),
        new("San Jose, Costa Rica", 9.9281, -84.0907),
        new("Sao Paulo, Brazil", -23.5505, -46.6333),
        new("Rio de Janeiro, Brazil", -22.9068, -43.1729),
        new("Brasilia, Brazil", -15.7975, -47.8919),
        new("Salvador, Brazil", -12.9714, -38.5014),
        new("Fortaleza, Brazil", -3.7319, -38.5267),
        new("Belo Horizonte, Brazil", -19.9167, -43.9345),
        new("Manaus, Brazil", -3.119, -60.0217),
        new("Buenos Aires, Argentina", -34.6037, -58.3816),
        new("Cordoba, Argentina", -31.4201, -64.1888),
        new("Santiago, Chile", -33.4489, -70.6693),
        new("Lima, Peru", -12.0464, -77.0428),
        new("Cusco, Peru", -13.5319, -71.9675),
        new("Bogota, Colombia", 4.711, -74.0721),
        new("Medellin, Colombia", 6.2442, -75.5812),
        new("Caracas, Venezuela", 10.4806, -66.9036),
        new("Quito, Ecuador", -0.1807, -78.4678),
        new("Guayaquil, Ecuador", -2.1709, -79.9224),
        new("La Paz, Bolivia", -16.5, -68.15),
        new("Montevideo, Uruguay", -34.9011, -56.1645),
        new("Asuncion, Paraguay", -25.2637, -57.5759),
        new("Cairo, Egypt", 30.0444, 31.2357),
        new("Alexandria, Egypt", 31.2001, 29.9187),
        new("Johannesburg, South Africa", -26.2041, 28.0473),
        new("Cape Town, South Africa", -33.9249, 18.4241),
        new("Durban, South Africa", -29.8587, 31.0218),
        new("Nairobi, Kenya", -1.2921, 36.8219),
    };
}

public static class PolylineData
{
    public const int PolylineCount = 200;

    private readonly record struct RouteInfo(
        string Name,
        double StartLat,
        double StartLon,
        double EndLat,
        double EndLon,
        double MidLat,
        double MidLon);

    private static readonly RouteInfo[] Routes = new RouteInfo[]
    {
        new("London to New York (North Atlantic Corridor)", 51.5074, -0.1278, 40.7128, -74.006, 56.0, -35.0),
        new("Paris to Tokyo (Eurasian Transcontinental)", 48.8566, 2.3522, 35.6762, 139.6503, 62.0, 75.0),
        new("Los Angeles to Sydney (Trans-Pacific Southern)", 34.0522, -118.2437, -33.8688, 151.2093, -5.0, -170.0),
        new("San Francisco to Tokyo (Trans-Pacific Northern)", 37.7749, -122.4194, 35.6762, 139.6503, 50.0, -175.0),
        new("Cairo to Cape Town (Pan-African Highway)", 30.0444, 31.2357, -33.9249, 18.4241, -2.0, 35.0),
        new("Buenos Aires to New York (Pan-American East)", -34.6037, -58.3816, 40.7128, -74.006, 5.0, -60.0),
        new("Santiago to Anchorage (Pan-American West Spine)", -33.4489, -70.6693, 61.2181, -149.9003, 15.0, -95.0),
        new("Lisbon to Vladivostok (Great Eurasian Route)", 38.7223, -9.1393, 43.1155, 131.8855, 58.0, 60.0),
        new("Singapore to London (Kangaroo Route West)", 1.3521, 103.8198, 51.5074, -0.1278, 28.0, 50.0),
        new("Sydney to Singapore (Oceania-Asia Corridor)", -33.8688, 151.2093, 1.3521, 103.8198, -15.0, 125.0),
        new("Dubai to New York (Middle East - North America)", 25.2048, 55.2708, 40.7128, -74.006, 60.0, -10.0),
        new("Rio de Janeiro to Lisbon (South Atlantic Route)", -22.9068, -43.1729, 38.7223, -9.1393, 8.0, -25.0),
        new("Mumbai to London (Indian Ocean - Europe)", 19.076, 72.8777, 51.5074, -0.1278, 38.0, 35.0),
        new("Johannesburg to Mumbai (Indian Ocean Transverse)", -26.2041, 28.0473, 19.076, 72.8777, -5.0, 55.0),
        new("Hong Kong to Vancouver (Pacific Rim North)", 22.3193, 114.1694, 49.2827, -123.1207, 48.0, 175.0),
        new("Miami to Buenos Aires (Inter-American Corridor)", 25.7617, -80.1918, -34.6037, -58.3816, -6.0, -50.0),
        new("Seoul to Los Angeles (North Pacific Airway)", 37.5665, 126.978, 34.0522, -118.2437, 47.0, -170.0),
        new("Frankfurt to Singapore (Silk Skyway)", 50.1109, 8.6821, 1.3521, 103.8198, 30.0, 65.0),
        new("Auckland to Santiago (South Pacific Crossing)", -36.8485, 174.7633, -33.4489, -70.6693, -48.0, -130.0),
        new("Cape Town to Sydney (Southern Ocean Arc)", -33.9249, 18.4241, -33.8688, 151.2093, -44.0, 85.0),
        new("New York to Los Angeles (Route 66 / I-80 corridor)", 40.7128, -74.006, 34.0522, -118.2437, 39.0, -96.0),
        new("Seattle to Miami (Diagonal Trans-US)", 47.6062, -122.3321, 25.7617, -80.1918, 37.0, -97.0),
        new("Boston to San Francisco (I-90 / I-80 Route)", 42.3601, -71.0589, 37.7749, -122.4194, 42.5, -96.5),
        new("Vancouver to Toronto (Trans-Canada Highway West-East)", 49.2827, -123.1207, 43.6532, -79.3832, 51.5, -102.0),
        new("Montreal to Vancouver (Canadian Pacific Corridor)", 45.5017, -73.5673, 49.2827, -123.1207, 52.0, -98.0),
        new("Anchorage to Seattle (Alaska Highway & Marine Highway)", 61.2181, -149.9003, 47.6062, -122.3321, 55.0, -132.0),
        new("San Diego to Vancouver (Pacific Coast Highway)", 32.7157, -117.1611, 49.2827, -123.1207, 41.0, -124.0),
        new("Miami to Boston (US East Coast Corridor I-95)", 25.7617, -80.1918, 42.3601, -71.0589, 34.5, -78.0),
        new("Chicago to New Orleans (Mississippi River Valley)", 41.8781, -87.6298, 29.9511, -90.0715, 36.0, -89.5),
        new("Houston to Denver (Rocky Mountain Plains Corridor)", 29.7604, -95.3698, 39.7392, -104.9903, 35.0, -101.5),
        new("Dallas to Atlanta (I-20 Southern Corridor)", 32.7767, -96.797, 33.749, -84.388, 32.5, -90.5),
        new("Mexico City to Monterrey (Mexican Central Spine)", 19.4326, -99.1332, 25.6866, -100.3161, 22.0, -100.5),
        new("Guadalajara to Cancun (Trans-Mexican Highway)", 20.6597, -103.3496, 21.1619, -86.8515, 19.5, -95.0),
        new("Mexico City to Tijuana (Pacific Baja Corridor)", 19.4326, -99.1332, 32.5149, -117.0382, 26.5, -109.0),
        new("Denver to Seattle (Northwest Corridor)", 39.7392, -104.9903, 47.6062, -122.3321, 44.5, -114.5),
        new("Minneapolis to Dallas (I-35 Heartland Corridor)", 44.9778, -93.265, 32.7767, -96.797, 39.0, -94.5),
        new("Toronto to Montreal (St. Lawrence Corridor)", 43.6532, -79.3832, 45.5017, -73.5673, 44.5, -76.5),
        new("Calgary to Edmonton (Alberta Energy Corridor)", 51.0447, -114.0719, 53.5461, -113.4938, 52.3, -113.8),
        new("Halifax to Toronto (Atlantic Canada Route)", 44.6488, -63.5752, 43.6532, -79.3832, 46.0, -71.5),
        new("Miami to Havana (Florida Straits Maritime)", 25.7617, -80.1918, 23.1136, -82.3666, 24.5, -81.5),
        new("Havana to Santo Domingo (Greater Antilles Route)", 23.1136, -82.3666, 18.4861, -69.9312, 21.0, -75.5),
        new("San Jose to Panama City (Central American Highway)", 9.9281, -84.0907, 8.9824, -79.5199, 8.8, -82.0),
        new("Guatemala City to San Jose (Central America Spine)", 14.6349, -90.5069, 9.9281, -84.0907, 12.5, -87.0),
        new("Honolulu to Kahului (Hawaiian Inter-Island Route)", 21.3069, -157.8583, 20.8893, -156.4729, 21.1, -157.1),
        new("Phoenix to Salt Lake City (Desert Plateau Route)", 33.4484, -112.074, 40.7608, -111.891, 37.0, -112.0),
        new("Bogota to Quito (Northern Andes Corridor)", 4.711, -74.0721, -0.1807, -78.4678, 2.0, -76.5),
        new("Quito to Lima (Pacific Equatorial Route)", -0.1807, -78.4678, -12.0464, -77.0428, -6.0, -79.0),
        new("Lima to Santiago (Pacific Coast / Atacama Route)", -12.0464, -77.0428, -33.4489, -70.6693, -23.0, -71.0),
        new("Santiago to Buenos Aires (Trans-Andean Highway)", -33.4489, -70.6693, -34.6037, -58.3816, -33.0, -65.0),
        new("Buenos Aires to Montevideo (Rio de la Plata Crossing)", -34.6037, -58.3816, -34.9011, -56.1645, -34.8, -57.2),
        new("Buenos Aires to Asuncion (Parana River Basin Route)", -34.6037, -58.3816, -25.2637, -57.5759, -30.0, -59.5),
        new("Sao Paulo to Rio de Janeiro (Dutra Highway)", -23.5505, -46.6333, -22.9068, -43.1729, -23.0, -45.0),
        new("Rio de Janeiro to Salvador (Atlantic Brazilian Coast)", -22.9068, -43.1729, -12.9714, -38.5014, -17.5, -39.5),
        new("Salvador to Fortaleza (Nordeste Coastal Highway)", -12.9714, -38.5014, -3.7319, -38.5267, -8.0, -37.0),
        new("Sao Paulo to Brasilia (Planalto Central Route)", -23.5505, -46.6333, -15.7975, -47.8919, -19.5, -48.0),
        new("Brasilia to Manaus (Amazon Trans-Highway)", -15.7975, -47.8919, -3.119, -60.0217, -9.0, -55.0),
        new("Manaus to Belem (Amazon River Main Course)", -3.119, -60.0217, -1.4558, -48.5044, -2.5, -54.0),
        new("Cali to Medellin (Cauca Valley Route)", 3.4516, -76.532, 6.2442, -75.5812, 4.8, -76.0),
        new("Medellin to Cartagena (Caribbean Colombia Highway)", 6.2442, -75.5812, 10.391, -75.4794, 8.5, -75.8),
        new("Caracas to Bogota (Cordillera Oriental Corridor)", 10.4806, -66.9036, 4.711, -74.0721, 7.5, -72.0),
        new("La Paz to Cusco (Lake Titicaca & Altiplano Route)", -16.5, -68.15, -13.5319, -71.9675, -15.5, -70.0),
        new("La Paz to Buenos Aires (Gran Chaco Corridor)", -16.5, -68.15, -34.6037, -58.3816, -26.0, -64.0),
        new("Santiago to Punta Arenas (Patagonia Southern Spine)", -33.4489, -70.6693, -53.1638, -70.9171, -43.0, -72.0),
        new("Buenos Aires to Ushuaia (Ruta 40 Patagonian Highway)", -34.6037, -58.3816, -54.8019, -68.303, -45.0, -67.0),
        new("Cordoba to Mendoza (Argentine Cuyo Route)", -31.4201, -64.1888, -32.8895, -68.8458, -32.0, -66.5),
        new("Montevideo to Porto Alegre (Southern Cone Coastal)", -34.9011, -56.1645, -30.0346, -51.2177, -32.5, -53.0),
        new("Porto Alegre to Sao Paulo (BR-116 Southern Route)", -30.0346, -51.2177, -23.5505, -46.6333, -26.5, -49.5),
        new("Belo Horizonte to Salvador (Minas to Bahia Route)", -19.9167, -43.9345, -12.9714, -38.5014, -16.0, -41.0),
        new("Georgetown to Paramaribo to Cayenne (Guianas Coastal)", 6.8013, -58.1551, 4.9372, -52.326, 5.8, -55.0),
        new("Guayaquil to Cuenca (Ecuadorian Sierra Loop)", -2.1709, -79.9224, -2.9001, -79.0059, -2.5, -79.4),
        new("London to Edinburgh (Great North Road / East Coast Line)", 51.5074, -0.1278, 55.9533, -3.1883, 53.8, -1.5),
        new("London to Paris (Eurostar / Channel Tunnel)", 51.5074, -0.1278, 48.8566, 2.3522, 50.5, 1.5),
        new("Paris to Madrid (Pyrenees Transit Corridor)", 48.8566, 2.3522, 40.4168, -3.7038, 43.5, -1.0),
        new("Madrid to Lisbon (Iberian Trans-Peninsular Route)", 40.4168, -3.7038, 38.7223, -9.1393, 39.5, -6.5),
        new("Paris to Amsterdam (Thalys High Speed Corridor)", 48.8566, 2.3522, 52.3676, 4.9041, 50.8, 3.5),
        new("Amsterdam to Berlin (North European Plain Route)", 52.3676, 4.9041, 52.52, 13.405, 52.4, 9.0),
        new("Berlin to Warsaw (E20 Trans-European Route)", 52.52, 13.405, 52.2297, 21.0122, 52.3, 17.0),
        new("Warsaw to Kyiv (Eastern European Gateway)", 52.2297, 21.0122, 50.4501, 30.5234, 51.2, 25.5),
        new("Berlin to Munich (German High-Speed ICE Spine)", 52.52, 13.405, 48.1351, 11.582, 50.5, 12.0),
        new("Munich to Rome (Brenner Pass Alpine Highway)", 48.1351, 11.582, 41.9028, 12.4964, 45.0, 11.5),
        new("Paris to Marseille (TGV Mediterranean Spine)", 48.8566, 2.3522, 43.2965, 5.3698, 45.8, 4.8),
        new("Marseille to Barcelona (Mediterranean Arc West)", 43.2965, 5.3698, 41.3879, 2.1699, 42.5, 3.5),
        new("Barcelona to Valencia to Seville (Andalusian Arc)", 41.3879, 2.1699, 37.3891, -5.9845, 38.5, -2.5),
        new("Rome to Athens (Adriatic & Ionian Transit)", 41.9028, 12.4964, 37.9838, 23.7275, 40.0, 18.0),
        new("Vienna to Budapest to Bucharest (Danube Corridor)", 48.2082, 16.3738, 44.4268, 26.1025, 46.5, 21.0),
        new("Budapest to Belgrade to Athens (Balkan Highway)", 47.4979, 19.0402, 37.9838, 23.7275, 42.5, 21.5),
        new("Zurich to Milan (Gotthard Alpine Corridor)", 47.3769, 8.5417, 45.4642, 9.19, 46.5, 8.8),
        new("Frankfurt to Vienna (Main-Danube Route)", 50.1109, 8.6821, 48.2082, 16.3738, 49.0, 12.5),
        new("Hamburg to Copenhagen (Fehmarn Belt Crossing)", 53.5511, 9.9937, 55.6761, 12.5683, 54.5, 11.5),
        new("Copenhagen to Stockholm (Oresund Bridge & Swedish Spine)", 55.6761, 12.5683, 59.3293, 18.0686, 57.5, 15.0),
        new("Stockholm to Oslo (Scandinavian East-West Link)", 59.3293, 18.0686, 59.9139, 10.7522, 59.5, 14.5),
        new("Stockholm to Helsinki (Baltic Sea Marine Route)", 59.3293, 18.0686, 60.1699, 24.9384, 59.8, 21.5),
        new("Helsinki to Tallinn (Gulf of Finland Crossing)", 60.1699, 24.9384, 59.437, 24.7536, 59.8, 24.8),
        new("Dublin to Cork (Irish North-South Corridor)", 53.3498, -6.2603, 51.8985, -8.4756, 52.6, -7.5),
        new("Dublin to Belfast (Irish Cross-Border Rail)", 53.3498, -6.2603, 54.5973, -5.9301, 54.0, -6.1),
        new("Lisbon to Porto (Portuguese Atlantic Coastal Link)", 38.7223, -9.1393, 41.1579, -8.6291, 40.0, -8.8),
        new("Prague to Vienna (Central European Rail Corridor)", 50.0755, 14.4378, 48.2082, 16.3738, 49.0, 15.5),
        new("Athens to Istanbul (Aegean & Thracian Transit)", 37.9838, 23.7275, 41.0082, 28.9784, 40.0, 26.0),
        new("Oslo to Bergen (Bergen Railway Scenic Mountain Pass)", 59.9139, 10.7522, 60.3913, 5.3221, 60.5, 8.0),
        new("Reykjavik Ring Road (Iceland Golden & Coastal Loop)", 64.1466, -21.9426, 65.6835, -18.1059, 65.0, -20.0),
        new("Beijing to Shanghai (Fuxing High Speed Rail Spine)", 39.9042, 116.4074, 31.2304, 121.4737, 35.5, 118.0),
        new("Shanghai to Guangzhou (Southeast China Coastal Rail)", 31.2304, 121.4737, 23.1291, 113.2644, 27.0, 117.0),
        new("Beijing to Guangzhou (China North-South Central Spine)", 39.9042, 116.4074, 23.1291, 113.2644, 31.5, 114.5),
        new("Guangzhou to Hong Kong (Pearl River Delta Network)", 23.1291, 113.2644, 22.3193, 114.1694, 22.7, 113.8),
        new("Shanghai to Chengdu (Yangtze River Corridor)", 31.2304, 121.4737, 30.5728, 104.0668, 30.8, 112.5),
        new("Beijing to Xi'an (Ancient Capitals Corridor)", 39.9042, 116.4074, 34.3416, 108.9398, 37.0, 112.5),
        new("Xi'an to Urumqi (Silk Road Hexi Corridor)", 34.3416, 108.9398, 43.8256, 87.6168, 39.0, 97.0),
        new("Tokyo to Osaka (Tokaido Shinkansen Route)", 35.6762, 139.6503, 34.6937, 135.5023, 35.0, 137.5),
        new("Osaka to Fukuoka (Sanyo Shinkansen Route)", 34.6937, 135.5023, 33.5904, 130.4017, 34.2, 132.8),
        new("Tokyo to Sapporo (Tohoku & Hokkaido Shinkansen)", 35.6762, 139.6503, 43.0618, 141.3545, 39.5, 141.0),
        new("Seoul to Busan (KTX Gyeongbu Axis)", 37.5665, 126.978, 35.1796, 129.0756, 36.3, 128.0),
        new("Delhi to Mumbai (Western Dedicated Freight / Express)", 28.6139, 77.209, 19.076, 72.8777, 24.0, 74.5),
        new("Mumbai to Chennai (Deccan Plateau Transit)", 19.076, 72.8777, 13.0827, 80.2707, 16.0, 76.5),
        new("Chennai to Kolkata (Eastern Coastal Highway India)", 13.0827, 80.2707, 22.5726, 88.3639, 18.0, 83.5),
        new("Kolkata to Delhi (Grand Trunk Road India)", 22.5726, 88.3639, 28.6139, 77.209, 25.5, 82.5),
        new("Delhi to Bengaluru (North-South Subcontinent Axis)", 28.6139, 77.209, 12.9716, 77.5946, 20.5, 78.5),
        new("Bengaluru to Chennai (Southern Tech Corridor)", 12.9716, 77.5946, 13.0827, 80.2707, 13.0, 79.0),
        new("Karachi to Lahore to Islamabad (Indus Valley Highway)", 24.8607, 67.0011, 33.6844, 73.0479, 29.5, 71.0),
        new("Dhaka to Chittagong (Bangladesh Economic Corridor)", 23.8103, 90.4125, 22.3569, 91.7832, 23.0, 91.1),
        new("Bangkok to Chiang Mai (Northern Thailand Transit)", 13.7563, 100.5018, 18.7883, 98.9853, 16.0, 100.0),
        new("Bangkok to Kuala Lumpur to Singapore (Malay Peninsula)", 13.7563, 100.5018, 1.3521, 103.8198, 7.5, 101.5),
        new("Hanoi to Ho Chi Minh City (North-South Vietnam Axis)", 21.0285, 105.8542, 10.8231, 106.6297, 16.0, 107.5),
        new("Jakarta to Surabaya (Trans-Java Tollway Spine)", -6.2088, 106.8456, -7.2575, 112.7521, -6.8, 109.8),
        new("Manila to Davao (Pan-Philippine Highway Maharlika)", 14.5995, 120.9842, 7.1907, 125.4553, 11.0, 123.5),
        new("Taipei to Kaohsiung (Taiwan High Speed Rail)", 25.033, 121.5654, 22.6273, 120.3014, 23.8, 120.8),
        new("Dubai to Riyadh (Arabian Gulf - Nejd Corridor)", 25.2048, 55.2708, 24.7136, 46.6753, 24.8, 51.0),
        new("Riyadh to Jeddah (Haramain & Trans-Arabian Route)", 24.7136, 46.6753, 21.4858, 39.1925, 23.0, 42.5),
        new("Dubai to Muscat (Oman Coastal Highway)", 25.2048, 55.2708, 23.588, 58.3829, 24.5, 56.5),
        new("Tehran to Isfahan to Shiraz (Persian Historic Spine)", 35.6892, 51.389, 29.5918, 52.5837, 32.5, 51.8),
        new("Baghdad to Basra (Tigris-Euphrates Corridor)", 33.3152, 44.3661, 30.5081, 47.7835, 31.8, 46.0),
        new("Tashkent to Samarkand to Bukhara (Silk Oasis Route)", 41.2995, 69.2401, 39.7681, 64.4556, 40.5, 66.8),
        new("Almaty to Astana (Kazakh Steppe Highway)", 43.222, 76.8512, 51.1694, 71.4491, 47.0, 74.0),
        new("Ulaanbaatar to Beijing (Trans-Mongolian Rail)", 47.8864, 106.9057, 39.9042, 116.4074, 44.0, 112.0),
        new("Kathmandu to Pokhara (Himalayan Valley Highway)", 27.7172, 85.324, 28.2096, 83.9856, 28.0, 84.6),
        new("Colombo to Kandy to Galle (Sri Lanka Island Loop)", 6.9271, 79.8612, 6.0535, 80.221, 6.5, 80.5),
        new("Cairo to Alexandria (Nile Delta Expressway)", 30.0444, 31.2357, 31.2001, 29.9187, 30.6, 30.5),
        new("Cairo to Luxor to Aswan (Nile Valley Highway)", 30.0444, 31.2357, 24.0889, 32.8998, 27.0, 31.8),
        new("Casablanca to Marrakech to Agadir (Moroccan Motorway)", 33.5731, -7.5898, 30.4278, -9.5981, 32.0, -8.5),
        new("Casablanca to Tangier to Algiers (Maghreb Coastal Route)", 33.5731, -7.5898, 36.7538, 3.0588, 35.8, -1.5),
        new("Algiers to Tunis (North African Mediterranean Highway)", 36.7538, 3.0588, 36.8065, 10.1815, 36.7, 6.5),
        new("Dakar to Bamako to Abidjan (West African Highway)", 14.7167, -17.4677, 5.36, -4.0083, 11.0, -9.0),
        new("Abidjan to Accra to Lagos (Gulf of Guinea Corridor)", 5.36, -4.0083, 6.5244, 3.3792, 5.8, -0.5),
        new("Lagos to Abuja to Kano (Nigerian North-South Axis)", 6.5244, 3.3792, 12.0022, 8.592, 9.2, 7.5),
        new("Addis Ababa to Djibouti (Ethio-Djibouti Corridor)", 9.03, 38.74, 11.5721, 43.1456, 10.2, 41.0),
        new("Nairobi to Mombasa (Standard Gauge Rail Corridor)", -1.2921, 36.8219, -4.0435, 39.6682, -2.6, 38.3),
        new("Nairobi to Kampala to Kigali (Northern Corridor)", -1.2921, 36.8219, -1.9706, 30.1044, 0.2, 33.5),
        new("Dar es Salaam to Dodoma to Mwanza (Central Corridor)", -6.7924, 39.2083, -2.5164, 32.9175, -5.0, 35.5),
        new("Johannesburg to Durban (N3 Freight Corridor)", -26.2041, 28.0473, -29.8587, 31.0218, -28.0, 29.5),
        new("Johannesburg to Cape Town (N1 Trans-Karoo Highway)", -26.2041, 28.0473, -33.9249, 18.4241, -30.0, 23.5),
        new("Cape Town to Port Elizabeth to Durban (Garden Route)", -33.9249, 18.4241, -29.8587, 31.0218, -34.0, 25.5),
        new("Windhoek to Walvis Bay (Namib Desert Gateway)", -22.5609, 17.0658, -22.9575, 14.5053, -22.7, 15.8),
        new("Gaborone to Francistown to Victoria Falls (Botswana Spine)", -24.6282, 25.9231, -17.9243, 25.856, -21.0, 26.5),
        new("Luanda to Benguela to Lubango (Angolan Atlantic Spine)", -8.839, 13.2894, -14.9172, 13.4925, -12.0, 13.5),
        new("Kinshasa to Matadi (Congo River Lower Gateway)", -4.4419, 15.2663, -5.8167, 13.45, -5.2, 14.3),
        new("Maputo to Beira (Mozambique Coastal Highway)", -25.9692, 32.5732, -19.8436, 34.8389, -23.0, 34.0),
        new("Antananarivo to Toamasina (Madagascar RN2 Highway)", -18.8792, 47.5079, -18.1492, 49.4023, -18.5, 48.5),
        new("Dakar to Nouakchott (Sahel Coastal Link)", 14.7167, -17.4677, 18.0735, -15.9582, 16.5, -16.5),
        new("Khartoum to Port Sudan (Red Sea Freight Spine)", 15.5007, 32.5599, 19.6158, 37.2164, 17.8, 35.0),
        new("Algiers to Tamanrasset (Trans-Sahara Highway South)", 36.7538, 3.0588, 22.785, 5.5228, 29.0, 4.0),
        new("Addis Ababa to Nairobi (Moyale Trans-East Africa Highway)", 9.03, 38.74, -1.2921, 36.8219, 3.5, 37.8),
        new("Sydney to Melbourne (Hume Highway / High Speed Rail)", -33.8688, 151.2093, -37.8136, 144.9631, -35.5, 147.5),
        new("Melbourne to Adelaide (Great Ocean Road & Western Hwy)", -37.8136, 144.9631, -34.9285, 138.6007, -37.0, 141.0),
        new("Sydney to Brisbane (Pacific Highway East Coast)", -33.8688, 151.2093, -27.4698, 153.0251, -30.5, 152.8),
        new("Adelaide to Perth (Eyre Highway across Nullarbor Plain)", -34.9285, 138.6007, -31.9505, 115.8605, -31.5, 126.0),
        new("Adelaide to Alice Springs to Darwin (Stuart Highway Spine)", -34.9285, 138.6007, -12.4634, 130.8456, -23.7, 133.8),
        new("Perth to Geraldton to Broome (Western Australia Coast)", -31.9505, 115.8605, -17.9614, 122.2359, -25.0, 116.0),
        new("Brisbane to Cairns (Bruce Highway Queensland Coast)", -27.4698, 153.0251, -16.9186, 145.7781, -22.0, 149.5),
        new("Darwin to Cairns (Savannah Way North Australia)", -12.4634, 130.8456, -16.9186, 145.7781, -15.0, 138.0),
        new("Melbourne to Hobart (Bass Strait & Tasmanian Spine)", -37.8136, 144.9631, -42.8821, 147.3272, -40.5, 146.5),
        new("Sydney to Broken Hill (Outback Explorer Highway)", -33.8688, 151.2093, -31.9559, 141.4678, -32.5, 146.0),
        new("Auckland to Wellington (New Zealand State Highway 1 North)", -36.8485, 174.7633, -41.2865, 174.7762, -39.0, 175.5),
        new("Wellington to Christchurch (Cook Strait & South Island)", -41.2865, 174.7762, -43.5321, 172.6362, -42.5, 173.8),
        new("Christchurch to Queenstown (Southern Alps Scenic Route)", -43.5321, 172.6362, -45.0312, 168.6626, -44.2, 170.5),
        new("Auckland to Bay of Islands (Northland Scenic Loop)", -36.8485, 174.7633, -35.2818, 174.0908, -36.0, 174.5),
        new("Port Moresby to Lae (Papua New Guinea Highlands Link)", -9.4438, 147.1803, -6.7282, 146.993, -8.0, 147.2),
        new("Suva to Nadi (Fiji Queens Road Island Arc)", -18.1416, 178.4419, -17.7765, 177.4356, -18.1, 177.8),
        new("Noumea to Hienghene (New Caledonia Grand Terre)", -22.2558, 166.4505, -20.6833, 164.9333, -21.5, 165.5),
        new("Tahiti to Bora Bora (French Polynesia Island Hop)", -17.6509, -149.426, -16.5004, -151.7415, -17.0, -150.5),
        new("Honolulu to Hilo (Hawaiian Maritime Skyway)", 21.3069, -157.8583, 19.7297, -155.09, 20.5, -156.5),
        new("Guam to Saipan (Mariana Islands Link)", 13.4443, 144.7937, 15.1909, 145.7467, 14.3, 145.2),
        new("Strait of Gibraltar Crossing", 36.1408, -5.3536, 35.7595, -5.834, 35.9, -5.6),
        new("English Channel Shipping Lane", 51.1279, 1.3134, 49.4944, 0.1079, 50.3, 0.8),
        new("Suez Canal Maritime Corridor", 31.2653, 32.3019, 29.9668, 32.5498, 30.6, 32.35),
        new("Strait of Malacca Super-Highway", 5.4141, 100.3288, 1.3521, 103.8198, 3.2, 101.8),
        new("Panama Canal Transit", 9.3598, -79.9015, 8.95, -79.5667, 9.15, -79.7),
        new("Strait of Hormuz Oil Route", 26.5667, 56.25, 25.2048, 55.2708, 26.0, 56.0),
        new("Bosporus & Dardanelles Black Sea Passage", 41.2, 29.1, 40.05, 26.2, 40.6, 27.5),
        new("Bab-el-Mandeb Red Sea Gate", 12.5833, 43.3333, 11.588, 43.145, 12.1, 43.2),
        new("Strait of Magellan Passage", -52.4, -68.4, -53.5, -73.5, -53.2, -71.0),
        new("Cape of Good Hope Shipping Loop", -34.3568, 18.474, -34.0, 22.0, -34.8, 20.2),
        new("North Sea Offshore Energy Line", 56.0, 3.0, 60.5, 2.0, 58.2, 2.5),
        new("Baltic Sea Shipping Lane", 54.5, 12.0, 59.5, 24.0, 57.0, 18.0),
        new("Caribbean Sea Cruise & Freight Arc", 18.0, -66.0, 10.0, -79.0, 14.0, -72.0),
        new("South China Sea Main Sea Lane", 22.0, 118.0, 3.0, 106.0, 12.0, 112.0),
        new("Sea of Japan / East Sea Corridor", 35.0, 130.0, 43.0, 138.0, 39.0, 134.0),
        new("Bering Strait Arctic Channel", 65.5, -168.0, 66.5, -169.0, 66.0, -168.5),
        new("Tasman Sea Airway", -37.0, 145.0, -37.0, 175.0, -38.5, 160.0),
        new("Trans-Indian Ocean Maritime Corridor", -5.0, 55.0, 5.0, 95.0, 0.0, 75.0),
        new("Cape Horn to Antarctic Peninsula", -55.98, -67.27, -64.0, -61.0, -60.0, -64.0),
        new("Greenland Sea to Svalbard Route", 70.0, -20.0, 78.22, 15.63, 74.0, -2.0),
    };

    private static readonly Brush[] RouteBrushes = new Brush[]
    {
        Brush.Crimson,
        Brush.DodgerBlue,
        Brush.SeaGreen,
        Brush.DarkOrange,
        Brush.DarkMagenta,
        Brush.Teal,
        Brush.RoyalBlue,
        Brush.Coral,
        Brush.Gold,
        Brush.IndianRed,
        Brush.MediumPurple,
        Brush.DeepSkyBlue,
        Brush.ForestGreen,
        Brush.Firebrick,
        Brush.DarkTurquoise,
        Brush.DarkSalmon,
        Brush.SteelBlue,
        Brush.Tomato,
        Brush.MediumVioletRed,
        Brush.CadetBlue
    };

    /// <summary>
    /// Creates a MapPolylineLayer with 200 geographic routes across all world regions.
    /// 20 prominent intercontinental routes contain 4,000 points each; the other routes contain 120-480 points.
    /// </summary>
    public static MapPolylineLayer CreatePolylineLayer()
    {
        MapPolylineLayer layer = new();

        for (int i = 0; i < Routes.Length; i++)
        {
            RouteInfo route = Routes[i];

            // 20 prominent routes across the globe have 4,000 points each;
            // the remaining routes have between 120 and 480 points.
            bool isDense = (i % 10 == 0);
            int pointCount = isDense ? 4000 : 120 + ((i * 37) % 360);

            // Handle Pacific longitude crossing if needed
            double endLon = route.EndLon;
            double midLon = route.MidLon;
            if (route.EndLon - route.StartLon > 180.0 && route.MidLon < 0)
            {
                endLon -= 360.0;
            }
            else if (route.StartLon - route.EndLon > 180.0 && route.MidLon > 0)
            {
                endLon += 360.0;
            }

            double waveFreq = 2.0 + (i % 5);
            double waveAmp = isDense ? 0.35 : 0.20;
            ObservableCollection<MapLatLng> points = new();

            for (int p = 0; p < pointCount; p++)
            {
                double t = p / (double)(pointCount - 1);
                double omt = 1.0 - t;

                // Quadratic Bézier curve through start, control point, and destination
                double lat = (omt * omt * route.StartLat) +
                             (2.0 * omt * t * route.MidLat) +
                             (t * t * route.EndLat);

                double lon = (omt * omt * route.StartLon) +
                             (2.0 * omt * t * midLon) +
                             (t * t * endLon);

                // Smooth natural undulating curvature along the corridor
                double sinOffset = Math.Sin(t * Math.PI * waveFreq) * waveAmp;
                lat = Math.Clamp(lat + sinOffset, -80.0, 80.0);

                // Normalize longitude to [-180, 180]
                lon = ((lon + 180.0) % 360.0 + 360.0) % 360.0 - 180.0;

                points.Add(new MapLatLng(lat, lon));
            }

            layer.Polylines.Add(new MapPolyline
            {
                Points = points,
                Stroke = RouteBrushes[i % RouteBrushes.Length],
                StrokeThickness = isDense ? 2.5 : 2.0
            });
        }

        return layer;
    }
}
