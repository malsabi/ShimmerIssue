using Bogus;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShimmerIssue.Models;
using System.Collections.ObjectModel;

namespace ShimmerIssue.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    public partial ObservableCollection<StudentModel> Students { get; set; } = new ObservableCollection<StudentModel>();

    [ObservableProperty]
    public partial bool IsBusy { get; set; }

    public MainViewModel()
    {
        // Initialize data when the view model is created.
        LoadStudents();
    }

    private void LoadStudents()
    {
        // Use Bogus to generate fake student data.
        var faker = new Faker<StudentModel>()
            .RuleFor(s => s.Name, f => f.Name.FullName())
            .RuleFor(s => s.Email, f => f.Internet.Email())
            .RuleFor(s => s.Password, f => f.Internet.Password())
            .RuleFor(s => s.Phone, f => f.Phone.PhoneNumber());

        // Generate a list of students and populate the collection.
        var studentList = faker.Generate(120); // Generate 20 students.
        foreach (var student in studentList)
        {
            Students.Add(student);
        }
    }

    [RelayCommand]
    private async Task Refresh()
    {
        // Simulate refreshing data.
        IsBusy = true;
        // Simulate delay
        await Task.Delay(2000);
        try
        {
            // Clear the existing data and load fresh data.
            Students.Clear();
            LoadStudents();
        }
        finally
        {
            IsBusy = false;
        }
    }
}