# <img src="art/icon.png" alt="Icon" width="50" />Tracking Plugin for Xamarin

This Plugin retrieves information about user's location without GPS activation: IP address, country name, city name, GPS coordinates (latitude and longitude), country calling code, country currency, country flag image, etc.

## Setup

- Available on NuGet: https://www.nuget.org/packages/App.User.LocationInfo/ [![NuGet](https://img.shields.io/nuget/v/App.User.LocationInfo.svg?label=NuGet)](https://www.nuget.org/packages/App.User.LocationInfo/)
- Install into your PCL/.NET Standard project and Client projects.

## Platform

App.User.LocationInfo is written in C#  as .NET Standard 2.0 project. it works fine in applications that can be deployed directly to users' devices. The plugin is based on the user's IP address to retrieve location information.

## Usage

Add namespace `App.User.LocationInfo.Services` and call `TrackingService` class to access to all methods:

- Get current user's IP Address:

```csharp
// Get current user's IP Address
var ip = await TrackingService.GetUserIPAdressAsync();
```

- Get current user's country code:

```csharp
// Get current user's country code
var country_code = await TrackingService.GetUserCountryCodeAsync();
```

- Get current user's country name:

```csharp
// Get current user's country name
var country_name = await TrackingService.GetUserCountryCodeAsync();
```

- Get [BasicUserLocationInfo](https://github.com/egbakou/App.User.LocationInfo/blob/master/src/App.User.LocationInfo/Models/BasicUserLocationInfo.cs) object(IP Address, Country, City, Currency, GPS coordinates, Internet Service Provider, ...)

```csharp
// Get BasicUserLocationInfo object
var basic_userlocationInfo = await TrackingService.GetBasicLocatioInfoAsync();
```

- Get [UserLocationInfo](https://github.com/egbakou/App.User.LocationInfo/blob/master/src/App.User.LocationInfo/Models/UserLocationInfo.cs) object ( [BasicUserLocationInfo](https://github.com/egbakou/App.User.LocationInfo/blob/master/src/App.User.LocationInfo/Models/BasicUserLocationInfo.cs) object + URL of the country flag image )

```csharp
// Get UserLocationInfo object
var userlocationInfo = await TrackingService.GetLocationInfoAsync();
```

## Created by: Kodjo Laurent Egbakou

- LinkedIn: [Kodjo Laurent Egbakou](https://www.linkedin.com/in/laurentegbakou/)
- Twitter: [@lioncoding](https://twitter.com/lioncoding)

## License

The MIT License (MIT) see [License file](https://github.com/egbakou/App.User.LocationInfo/blob/master/LICENSE)

## Contribution

Feel free to create issues and PRs 😃

