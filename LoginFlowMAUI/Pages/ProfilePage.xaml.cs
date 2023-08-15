using LoginFlowMAUI.Services;

namespace LoginFlowMAUI.Pages;

public partial class ProfilePage : ContentPage
{
    private readonly AuthService authService;

    public ProfilePage(AuthService authService)
	{
		InitializeComponent();
        this.authService = authService;
    }

    private void Button_Clicked(object sender, EventArgs e) {
        authService.Logout();
        Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}