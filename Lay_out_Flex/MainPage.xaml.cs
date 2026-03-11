namespace Lay_out_Flex
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

       

        private async  void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Abs_olut_lay_out());
        }
    }
}
