# .NET MAUI Maps Marker Performance

This repository contains two .NET MAUI sample apps that compare Syncfusion Maps tile-layer performance with 150 markers: built-in map markers and custom image markers. Each app displays marker count and timing information for marker setup, zooming, and panning.

The samples use `Syncfusion.Maui.Maps` and OpenStreetMap tiles. They feature 150 real-world city marker locations across all inhabited continents, plus 200 geographic polyline routes spanning the globe.

For general Maps setup and control usage, see [Getting Started with .NET MAUI Maps](https://help.syncfusion.com/maui/maps/getting-started).

## Samples

| Sample | Description |
| --- | --- |
| [TileLayerDefaultMarker](./TileLayerDefaultMarker/TileLayerPerformanceSample/) | Displays 150 default `MapMarker` markers on a tile layer. |
| [TileLayerCustomMarker](./TileLayerCustomMarker/TileLayerPerformanceSample/) | Displays the same 150 marker locations using a custom template with a pin image. |

Both samples also add a polyline sublayer to the tile layer: 200 `MapPolyline` routes distributed worldwide (covering North America, South America, Europe, Asia, Africa, Oceania, and intercontinental corridors). 20 major routes contain 4,000 points each, and the other 180 routes contain 120–480 points each. Polyline creation is included in the layer setup timing.

Both apps launch directly into their marker page. Interact with the map to see the zoom and pan timing labels update. Each project also contains a separate `MainPage` tile-loading example; that page is not currently connected to the app shell and does not appear on launch.

### About the timing values

The timings are diagnostic measurements, not guaranteed benchmarks. Marker setup timing includes page initialization, creation of the marker collection, and assigning it to the map layer; it does not wait for final on-screen rendering. The zoom and pan labels report interaction durations. The separate tile-loading page measures setting the tile URL, not completion of tile downloads or rendering. Device, platform, network, and build configuration all affect results.

## Prerequisites

- .NET 10 SDK and the .NET MAUI workload.
- Visual Studio 2022 with the .NET MAUI workload, or the .NET CLI and required platform tooling.
- Android SDK plus an emulator or device for Android.
- Windows and Windows App SDK tooling for Windows.
- macOS and Xcode for iOS or Mac Catalyst builds and deployment.
- Network access to load map tiles from OpenStreetMap.
- A Syncfusion license, if required for your use. Refer to the [Syncfusion MAUI Maps getting-started guide](https://help.syncfusion.com/maui/maps/getting-started) for licensing and setup details.

## Run the sample

Choose either project directory. The following commands use the default-marker sample; use `TileLayerCustomMarker` instead to run the custom-marker sample.

From the repository root in PowerShell:

```powershell
cd TileLayerDefaultMarker\TileLayerPerformanceSample
dotnet workload restore
```

Open `TileLayerPerformanceSample.slnx` in Visual Studio, select the project and target device, and press **F5**. Or, with the appropriate emulator/device configured, run:

```powershell
# Android
dotnet build -t:Run -f net10.0-android

# Windows (run on Windows)
dotnet build -t:Run -f net10.0-windows10.0.19041.0
```

For iOS and Mac Catalyst, use macOS with Xcode and a selected simulator or device:

```powershell
dotnet build -t:Run -f net10.0-ios
dotnet build -t:Run -f net10.0-maccatalyst
```

Restore or install the MAUI workload and platform tooling required by your host and target. Targets available in each project vary by build host.

## Build and deploy

From the selected sample's project directory, create a Release publish output for the target platform:

```powershell
dotnet publish -f net10.0-android -c Release
dotnet publish -f net10.0-windows10.0.19041.0 -c Release
dotnet publish -f net10.0-ios -c Release
dotnet publish -f net10.0-maccatalyst -c Release
```

Run only the publish command for a target supported by your host and configured SDKs. Publish output is placed beneath `bin\Release`. `dotnet publish` creates build/package output; store or enterprise distribution also requires the platform's signing and distribution steps:

- **Android:** Configure release signing with your keystore. To create an Android App Bundle for Google Play, add `-p:AndroidPackageFormat=aab`. Keep keystores and signing credentials out of source control.
- **iOS and Mac Catalyst:** Build on macOS and configure Apple signing, provisioning, and distribution in Xcode or Visual Studio.
- **Windows:** The projects currently set `WindowsPackageType` to `None`, which produces an unpackaged app. Configure MSIX packaging and signing separately if needed for Store distribution.

## Map tiles and attribution

The map uses OpenStreetMap tiles and requires an internet connection. If you distribute the app, include the required map attribution and follow the [OpenStreetMap tile usage policy](https://operations.osmfoundation.org/policies/tiles/).
