namespace LOOM_APP;

public partial class Signup_LogIn : ContentPage
{
	public Signup_LogIn()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}