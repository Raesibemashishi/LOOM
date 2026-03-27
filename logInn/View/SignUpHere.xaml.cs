using logInn.ViewModel;

namespace logInn;

public partial class SignUpHere : ContentPage
{
	public SignUpHere()
	{
		InitializeComponent();

        //Connecting our page to the viewmodel
        BindingContext = new SaveClientDetails();
    }
}