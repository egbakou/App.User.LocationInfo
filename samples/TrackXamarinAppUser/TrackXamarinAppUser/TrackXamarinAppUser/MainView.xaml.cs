using System.ComponentModel;
using TrackXamarinAppUser.ViewModels;
using Xamarin.Forms;

namespace TrackXamarinAppUser
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

    }
}
