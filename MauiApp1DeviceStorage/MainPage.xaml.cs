
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace MauiApp1DeviceStorage
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            LoadingMap();
        }

        private  async void LoadingMap()
        {
            try
            {
              var location = await Geolocation.GetLocationAsync();
                if (location != null)
                    return;
                  var mapLocation = new Location
                       (
                          location.Latitude, 
                          location.Longitude
                       );

                    MyMap.MoveToRegion
                      (MapSpan.FromCenterAndRadius
                         ( 
                           mapLocation, 
                           Distance.FromKilometers(1)
                         )
                      );
                  MyMap.Pins.Add(new Pin
                  {
                      Label = "You are here",
                      Location = mapLocation
                  });

                MyMap.Pins.Add
                 (new Pin
                 {
                     Label = "Paledi Mall",
                     Address = "PLK. R71",
                     Location = new Location(48.8584, 2.2945)
                 });
                     
                  
                  


            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Unable to get location: {ex.Message}", "OK");
            }
        }
    }
}
