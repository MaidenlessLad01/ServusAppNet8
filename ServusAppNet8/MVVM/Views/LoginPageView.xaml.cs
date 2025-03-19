namespace ServusAppNet8.MVVM.Views;

public partial class LoginPageView : ContentPage
{
	public LoginPageView()
	{
		InitializeComponent();
	}

    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void SignUpButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
        Thread.Sleep(1000);
        await Navigation.PushAsync(new SignupPageView());
    }
}