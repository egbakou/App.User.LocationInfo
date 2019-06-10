# <img src="art/icon.png" alt="Icon" width="50" />Tracking Plugin for Xamarin

This Plugin retrieves information about user's location without GPS activation: IP address, country name, city name, GPS coordinates (latitude and longitude), country calling code, country currency, country flag image, etc.

## Setup

- Available on NuGet: https://www.nuget.org/packages/App.User.LocationInfo/ [![NuGet](https://img.shields.io/nuget/v/App.User.LocationInfo.svg?label=NuGet)](https://www.nuget.org/packages/Amporis.Xamarin.Forms.ColorPicker/)
- Install into your PCL/.NET Standard project and Client projects.

## Platform

App.User.LocationInfo is written in C#  as .NET Standard 2.0 project. it works fine in applications that can be deployed directly to users' devices. The plugin is based on the user's IP address to retrieve location information.

## API usage

Add namespace `App.User.LocationInfo.Services` and call `TrackingService` class to access to All methods:

```csharp
/// <summary>
/// Get current user's IP Address.
/// </summary>
/// <returns>User's IP Address.</returns>
Task<string> GetUserIPAdressAsync()


/// <summary>
/// Get current user's country code.
/// </summary>
/// <returns>Current user's country code.</returns>
Task<string> GetUserCountryCodeAsync()


/// <summary>
/// Get current user's country name.
/// </summary>
/// <returns>Current user's country name.</returns>
Task<string> GetUserCountryNameAsync()


/// <summary>
/// Get information about the user's location without URL of the country flag image.
/// </summary>
/// <returns>An instance of <see cref="BasicUserLocationInfo"/></returns>
Task<BasicUserLocationInfo> GetBasicLocatioInfoAsync()


/// <summary>
/// Get information about the user's location including URL of the country flag image.
/// </summary>
/// <returns>The <see cref="Task{UserLocationInfo}"/></returns>
Task<UserLocationInfo> GetLocationInfoAsync()

```

