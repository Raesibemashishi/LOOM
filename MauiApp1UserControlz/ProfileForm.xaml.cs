

namespace MauiApp1UserControlz;

public partial class ProfileForm : ContentView
{
	public ProfileForm()
	{
		InitializeComponent();
	}

    //Bindable Property
    public static readonly BindableProperty ProfileImageProperty = BindableProperty.Create(
        nameof(ProfileImage),
        typeof(ImageSource),
        typeof(ProfileForm),
        null);

    public static readonly BindableProperty NameProperty = BindableProperty.Create(
        nameof(Name),
        typeof(string),
        typeof(ProfileForm),
        string.Empty);

    public static readonly BindableProperty SurnameProperty = BindableProperty.Create(
        nameof(Surname),
        typeof(string),
        typeof(ProfileForm),
       string.Empty);

    public static readonly BindableProperty EmailProperty = BindableProperty.Create(
        nameof(Email),
        typeof(string),
        typeof(ProfileForm),
        string.Empty);


    //Properties
    //ProfileImage property
    public ImageSource ProfileImage
    {
        get => (ImageSource)GetValue(ProfileImageProperty);
        set => SetValue(ProfileImageProperty, value);
    }

    //Name property
    public string Name
        {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }

    //Surname property
    public string Surname
    {
        get => (string)GetValue(SurnameProperty);
        set => SetValue(SurnameProperty, value);
    }

    //email adress property
    public string Email
    {
        get => (string)GetValue(EmailProperty);
        set => SetValue(EmailProperty, value);
    }

    //Save Button Clicked Event handler
    public event EventHandler? SaveButtonClicked;


    private void Button_Clicked(object sender, EventArgs e)
    {
        SaveButtonClicked?.Invoke(this, EventArgs.Empty);
    }
}