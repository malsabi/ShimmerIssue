namespace ShimmerIssue;

public partial class MainPage : ContentPage
{
    private MainViewModel ViewModel => (MainViewModel)BindingContext;

    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        ViewModel.InitializeAsync();
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        base.OnNavigatedFrom(args);
        ViewModel.Students.Clear();
    }
}