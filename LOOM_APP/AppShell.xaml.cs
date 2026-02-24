namespace LOOM_APP
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("SignUp", typeof(Signup_LogIn));
        }
    }
}
