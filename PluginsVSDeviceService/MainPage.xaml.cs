using System.Threading.Tasks;

namespace PluginsVSDeviceService
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }


        //take photo
        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!MediaPicker.Default.IsCaptureSupported)
                {
                    await DisplayAlert("Error", "Camera not supported", "OK");
                    return;
                }

                var photo = await MediaPicker.Default.CapturePhotoAsync();
                if (photo == null)
                    return;

                SelectdImage.Source = ImageSource.FromFile(photo.FullPath);
                SelectdImage.IsVisible = true;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }


        //upload photo
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
               var photo = await MediaPicker.Default.PickPhotoAsync();
                if (photo == null)
                    return;
                SelectdImage.Source = ImageSource.FromFile(photo.FullPath);
                SelectdImage.IsVisible = true;

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
