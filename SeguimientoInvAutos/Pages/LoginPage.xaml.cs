namespace SeguimientoInvAutos.Pages;

public partial class LoginPage : ContentPage
{
    int count = 0;
    public LoginPage()
	{
		InitializeComponent();
	}
	private async void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			singin.Text = $"Ingresar";
		else
			singin.Text = $"Ingresar";

		SemanticScreenReader.Announce(singin.Text);
		await Navigation.PushAsync(new Pages.HomePage());

	}
}