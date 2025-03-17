namespace ServusAppNet8.MVVM.Views;

public partial class LandingPageView : ContentPage
{
	public LandingPageView()
	{
		InitializeComponent();
	}

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPageView());
    }

    private async void SignupButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignupPageView());
    }
}