using logInn.ViewModel;

namespace logInn
   
{
    public partial class MainPage : ContentPage
    {
    

        public MainPage()
        {
            InitializeComponent();

            //Connecting our page to the viewmodel
            BindingContext = new SaveClientDetails(this);
        }

        private  async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///ForgetPassword");
        }


        /*private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///SignUpHere");
        }*/

        bool IsPasswordHidden = true;
        private void ShowHidePassword_Clicked(object sender, EventArgs e)
        {
           
            //Flips the values 
            IsPasswordHidden = !IsPasswordHidden;

            //Change Password Visibility
            PasswordEntryField.IsPassword = IsPasswordHidden;

            //Change the icon
            ShowHidePassword.Source = IsPasswordHidden? "hidepassword.png" : "showpasswordicon.png";
        }

       
    }
}
