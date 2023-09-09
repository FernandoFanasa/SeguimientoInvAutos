namespace SeguimientoInvAutos.Pages;

public partial class LoginPage : ContentPage
{
    int count = 0;
    public LoginPage()
	{
		InitializeComponent();
	}
    void singin_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Pages.HomePage());
    }
}