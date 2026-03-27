using logInn.ViewModel;

namespace logInn;

public partial class ForgetPassword : ContentPage
{
	public ForgetPassword()
	{
		InitializeComponent();

        //Connecting our page to the viewmodel
        BindingContext = new SaveClientDetails();
    }

    private void DisplayInfomation_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }
}