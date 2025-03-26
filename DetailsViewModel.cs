using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ShimmerIssue;

public partial class DetailsViewModel : ObservableObject
{
    [RelayCommand]
    private async Task OpenMain()
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}