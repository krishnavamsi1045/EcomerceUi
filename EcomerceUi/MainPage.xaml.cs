using EcomerceUi.ViewModel;

namespace EcomerceUi.Models;

public partial class MainPage
    : ContentPage
{
    private readonly HomePageViewModel _viewModel;
    public MainPage(HomePageViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.IntializeAsync();
    }
}