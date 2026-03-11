namespace MauiApp2photos
{
    public partial class MainPage : ContentPage
    {
        public class Cosmetic
        { 
               public string Name { get; set; }
               public string Color { get; set; }
               public string Image { get; set; }
               public decimal Price { get; set; }

        }

        public MainPage()
        {
            InitializeComponent();

            var Cosmetic = new List<Cosmetic> 
            {
                new Cosmetic{Name= "Soap", Color="Black", Image="charcoal.png", Price= 350 },
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

            CosmeticCollection.ItemsSource = Cosmetic;
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {

        }
    }
}
