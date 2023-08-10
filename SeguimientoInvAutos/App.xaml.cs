
using SeguimientoInvAutos.Modelo;
using SeguimientoInvAutos.Pages;

namespace SeguimientoInvAutos;

public partial class App : Application
{
	public static UserInfo UserInfo;
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage (new FlyoutPageT()) ;
	}
}
