using SeguimientoInvAutos.Pages;

namespace SeguimientoInvAutos;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(HomePage),typeof(HomePage));
	}
}
