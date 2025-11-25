using ProgressTestMAD.ViewModels;
namespace ProgressTestMAD;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    void OnReadMoreTapped(object? sender, EventArgs e)
    {
        IntroCollapsed.IsVisible = false;
        IntroExpanded.IsVisible = true;
    }
}
