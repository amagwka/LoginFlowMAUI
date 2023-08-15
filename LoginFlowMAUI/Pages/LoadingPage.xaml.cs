using LoginFlowMAUI.Services;

namespace LoginFlowMAUI.Pages;

public partial class LoadingPage : ContentPage
{
	AuthService _authService;
	public LoadingPage(AuthService authService){
		InitializeComponent();
		_authService = authService;
	}
    protected async override void OnNavigatedTo(NavigatedToEventArgs args) {
        base.OnNavigatedTo(args);
		if( await _authService.IsAuthentificatedAsync() ) {
			//Logged in
			await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
		} else {
			// Not Logged in
			await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
		}
    }
}