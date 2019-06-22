using App.User.LocationInfo.Models;
using App.User.LocationInfo.Services;

namespace TrackXamarinAppUser.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Title = "App.User.LocationInfo";
            TrackUser();
        }

        async void TrackUser()
        {
            UserLocationInfo = await TrackingService.GetLocationInfoAsync();
            SyncInProcess = false;
            if (UserLocationInfo != null)
            {
                GpsPosition = "(" + UserLocationInfo.Location.Latitude + ", " + UserLocationInfo.Location.Longitude + ")";
                Languages = string.Join(", ", UserLocationInfo.Languages.ToArray());
            }
        }

        private UserLocationInfo _userLocationInfo;
        public UserLocationInfo UserLocationInfo
        {
            get { return _userLocationInfo; }
            set { SetProperty(ref _userLocationInfo, value); }
        }

        private string _gpsPosition;
        public string GpsPosition
        {
            get { return _gpsPosition; }
            set { SetProperty(ref _gpsPosition, value); }
        }

        private string _languages;
        public string Languages
        {
            get { return _languages; }
            set { SetProperty(ref _languages, value); }
        }
    }
}
