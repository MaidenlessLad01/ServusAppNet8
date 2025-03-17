namespace ServusAppNet8.MVVM.Views;

public partial class SignupPageView : ContentPage
{
	public SignupPageView()
	{
		InitializeComponent();
	}

    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}