using CommunityToolkit.Mvvm.ComponentModel;

namespace ShimmerIssue;
public partial class StudentModel : ObservableObject
{
    [ObservableProperty]
    public partial string FirstName { get; set; } = string.Empty;

    [ObservableProperty]
    public partial string LastName { get; set; } = string.Empty;

    [ObservableProperty]
    public partial string Email { get; set; } = string.Empty;
}