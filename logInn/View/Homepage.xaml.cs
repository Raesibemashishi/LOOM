using logInn.ViewModel;

namespace logInn;

public partial class Homepage : ContentPage
{
	public Homepage()
	{
		InitializeComponent();

        //Connecting our page to the viewmodel
        BindingContext = new SaveClientDetails(this);
    }
}