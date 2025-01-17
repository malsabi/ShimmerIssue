using CommunityToolkit.Mvvm.ComponentModel;

namespace ShimmerIssue.Models;
public partial class StudentModel : ObservableObject
{
    [ObservableProperty]
    public partial string Name { get; set; }

    [ObservableProperty]
    public partial string Email { get; set; }

    [ObservableProperty]
    public partial string Password { get; set; }

    [ObservableProperty]
    public partial string Phone { get; set; }
}