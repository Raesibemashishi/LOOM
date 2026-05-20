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

  
}