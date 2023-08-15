using LoginFlowMAUI.Services;

namespace LoginFlowMAUI.Pages;

public partial class LoginPage : ContentPage
{
    private readonly AuthService authService;

    public LoginPage(AuthService authService)
	{
		InitializeComponent();
        this.authService = authService;
    }

    private async void Button_Clicked(object sender, EventArgs e) {
        authService.Login();
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}