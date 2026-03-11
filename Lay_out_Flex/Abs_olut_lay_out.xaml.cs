namespace Lay_out_Flex;

public partial class Abs_olut_lay_out : ContentPage
{
	public Abs_olut_lay_out()
	{
		InitializeComponent();
	}

    private async  void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}