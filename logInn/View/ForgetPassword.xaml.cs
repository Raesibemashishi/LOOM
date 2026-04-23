using logInn.Model;
using logInn.ViewModel;
using System.Threading.Tasks;

namespace logInn;

public partial class ForgetPassword : ContentPage
{
	public ForgetPassword()
	{
		InitializeComponent();

        //Connecting our page to the viewmodel
        BindingContext = new SaveClientDetails(this);
    }

    private async void DisplayInfomation_ItemTapped(object sender, ItemTappedEventArgs e)
    {
         var SelectClient = (SaveClientDetails)BindingContext;
        await SelectClient.OnClientTapped((ClientDetails)e.Item);
    }
}