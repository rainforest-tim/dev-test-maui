using CommunityToolkit.Mvvm.ComponentModel;
using GeoDraw.App.Services;

namespace GeoDraw.App.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    private readonly IObjectSelectionService _objectSelectionService;

    public MainPageViewModel(IObjectSelectionService objectSelectionService)
    {
        _objectSelectionService = objectSelectionService;
    }

    [ObservableProperty]
    private string? _selectedObject;

    public async Task LoadAsync()
    {
        SelectedObject = await _objectSelectionService.GetThing();
    }
}
