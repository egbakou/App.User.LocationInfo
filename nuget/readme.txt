Tracking Plugin for Xamarin

Find the latest at: https://github.com/egbakou/App.User.LocationInfo

------------------------------
		USAGE
------------------------------
1. Add Namespace
App.User.LocationInfo.Services

2. Get Information that you need
	===> Get user's IP Adress:
		var ip = await TrackingService.GetUserIPAdressAsync();

	===> Get current user's country code:
		var country_code = await TrackingService.GetUserCountryCodeAsync();

	===> Get current user's country name:
		var country_name = await TrackingService.GetUserCountryCodeAsync();

	===> Get information about the user's location without URL of the country flag image.
		var basic_userlocationInfo = await TrackingService.GetBasicLocatioInfoAsync();

	===> Get information about the user's location with URL of the country flag image.
		var userlocationInfo = await TrackingService.GetLocationInfoAsync();