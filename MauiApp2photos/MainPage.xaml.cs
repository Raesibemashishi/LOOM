namespace MauiApp2photos
{
    public partial class MainPage : ContentPage
    {
        public class Cosmetic
        { 
               public string Name { get; set; } //Property to hold the name of the cosmetic product
            public string Color { get; set; } //Property to hold the color of the cosmetic product
            public string Image { get; set; } //Property to hold the image file name of the cosmetic product
            public decimal Price { get; set; } //Property to hold the price of the cosmetic product

        }

        public MainPage()
        {
            InitializeComponent();

            var cosmetics = new List<Cosmetic> //Creating a list of Cosmetic objects with sample data
            {
                new Cosmetic{Name= "Soap", Color="Black", Image="charcoal.png", Price= 350 },//Creating a list of Cosmetic objects with sample data
                new Cosmetic{Name= "lotion", Color="Pink", Image="pondlotn.png", Price= 75 },
                new Cosmetic{Name= "serum", Color="Orange", Image="ganier.png", Price= 150 },
                new Cosmetic{Name= "Vitamin c ", Color="Yellow", Image="vitaminc.png", Price= 180 },
                new Cosmetic{Name= "BarSoap", Color="Greeen", Image="gmbarsoap.png", Price= 30 },
                new Cosmetic{Name= "Pond Soap", Color="Yellow", Image="pondsoap.png", Price= 50 },
                new Cosmetic{Name= "Gentle Magic Lotion", Color="Green", Image="gmmlotion.png", Price= 70 },
                new Cosmetic{Name= "Ganier Even & Bright Serum", Color="Yellow", Image="ganierevenbright.png", Price= 250 },
                new Cosmetic{Name= " Pond Bar Soap", Color="Maroom", Image="soap.png", Price= 150 },
                new Cosmetic{Name= "Gentle Magic Vitamin B Complex", Color="Yellow", Image="gmvitaminc.png", Price= 150 },

            };

            CosmeticCollection.ItemsSource =cosmetics;//Binding the list of cosmetics to the CollectionView's ItemsSource
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)//Event handler for the tap gesture recognizer, triggered when a cosmetic item is tapped
        {
            if (sender is Frame frame && frame.BindingContext is Cosmetic cosmetics) //Checking if the sender is a Frame and its BindingContext is of type Cosmetic
            {
                await DisplayAlert
                    ("Cosmetic Tapped",//Title
                    $"{cosmetics.Name}\nColor: {cosmetics.Color}\nPrice: {cosmetics.Price}",//Message
                    "Ok");//Cancel/OK button text

                
            }
        }
    }
}
