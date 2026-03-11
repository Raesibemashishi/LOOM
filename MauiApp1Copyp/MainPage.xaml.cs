using MauiApp1Copyp.Models;
using MauiApp1Copyp.ViewModels;
namespace MauiApp1Copyp
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
            BindingContext= new MainPageViewModel(); // Connecting the ViewModel to the View

           
                 
        }

        private async  void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {


            if (sender is Frame frame && frame.BindingContext is Cosmetic cosmetics)
            {

                await DisplayAlert("Product Selected", $"{cosmetics.Name} - R{cosmetics.Price}", "OK"); 
                 
            }


        }

        private  async void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var cosmetics = button.BindingContext as Cosmetic;

            await DisplayAlert("Cart", $"{cosmetics.Name} added to cart", "OK");
        }
    }
}
