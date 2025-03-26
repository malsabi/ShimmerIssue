using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ShimmerIssue;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    public partial bool IsBusy { get; set; }

    [ObservableProperty]
    public partial bool IsRefreshing { get; set; }

    [ObservableProperty]
    public partial ObservableCollection<StudentModel> Students { get; set; } = [];


    public MainViewModel()
    {
    }

    [RelayCommand]
    private async Task RefreshData()
    {
        IsRefreshing = true;
        IsBusy = true;
        await Task.Delay(5000);
        FillData();
        IsRefreshing = false;
        IsBusy = false;
    }

    [RelayCommand]
    private async Task OpenDetails()
    {
        await Shell.Current.GoToAsync("DetailsPage");
    }

    private void FillData()
    {
        List<StudentModel> students = [];
        for (int i = 0; i < 150; i++)
        {
            students.Add(new StudentModel
            {
                FirstName = $"First Name {i}",
                LastName = $"Last Name {i}",
                Email = $"Email {i}"
            });
        }
        Students = new ObservableCollection<StudentModel>(students);
    }

    public void InitializeAsync()
    {
        IsBusy = true;
        FillData();
        IsBusy = false;
    }
}