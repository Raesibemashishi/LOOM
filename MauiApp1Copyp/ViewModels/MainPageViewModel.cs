
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MauiApp1Copyp.Models;


namespace MauiApp1Copyp.ViewModels
{
    class MainPageViewModel
    {
        public ObservableCollection<Cosmetic> Cosmetics { get; set; }

        public MainPageViewModel()
        {
            Cosmetics = new ObservableCollection<Cosmetic>
            {
              new Cosmetic {Name= "Soap",
                  Color="Red",
                  Image="charcoal.png",
                  Price= 300  },
              new Cosmetic {Name= "Ganier Even &  Bright Serum",
                  Color="Orange",
                  Image="ganierevenbright.png",
                  Price= 200  },
              new Cosmetic {Name= "Ganier Vitamin C Serum",
                  Color="Yellow",
                  Image="ganiervtmc.png",
                  Price= 185  },
              new Cosmetic {Name= "Gentle Magic Bar Soap",
                  Color="Green",
                  Image="gmbarsoap.png",
                  Price= 50  },
              new Cosmetic {Name= "Gentle Magic Lotion",
                  Color="Lime",
                  Image="gmmlotion.png",
                  Price= 100  },
              new Cosmetic {Name= "Gentle Magic Vitamin C",
                  Color="Green",
                  Image="gmvitaminc.png",
                  Price= 145  },
              new Cosmetic {Name= "Ponds Lotion",
                  Color="Pink",
                  Image="pondlotn.png",
                  Price= 112  },
              new Cosmetic {Name= "Pond Soap",
                  Color="White",
                  Image="pondsoap.png",
                  Price= 55  },
              new Cosmetic {Name= "soap",
                  Color="Black",
                  Image="soap.png",
                  Price= 80},
              new Cosmetic {Name= "Gentle Magic Vitamin C Supplements",
                  Color="White",
                  Image="vitaminc.png",
                  Price= 230 },

            };
        }
    }
}
