namespace logInn
{
    public partial class MainPage : ContentPage
    {
    

        public MainPage()
        {
            InitializeComponent();
        }

        private  async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///ForgetPassword");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            string email = EmailEntryField.Text;
            string password = PasswordEntryField.Text;

            //Validate
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Please enter both email and password.", "OK");
            }
            else if (email == "ldil" && password == "2025")
            {
                await DisplayAlert("Success", "Login successful!", "OK");


                //Clear the input fields
                EmailEntryField.Text = "";
                PasswordEntryField.Text = "";

                //Navigate to the home page
                await Shell.Current.GoToAsync("///HomePage");
            }
            else
            {
                await DisplayAlert("error", "invalid email or password", "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///SignUpHere");
        }

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
