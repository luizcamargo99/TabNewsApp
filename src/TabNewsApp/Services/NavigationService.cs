
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace TabNewsApp.Services;
internal class NavigationService : IDisposable
{
    private const int _minHistorySize = 256;
    private const int _additionalHistorySize = 64;
    private readonly NavigationManager _navigationManager;
    public readonly List<string> history;

    public NavigationService(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
        history = new List<string>(_minHistorySize + _additionalHistorySize);
        history.Add(_navigationManager.Uri);
        _navigationManager.LocationChanged += OnLocationChanged;
    }

    /// <summary>
    /// Navigates to the specified url.
    /// </summary>
    /// <param name="url">The destination url (relative or absolute).</param>
    public void NavigateTo(string url)
    {
        _navigationManager.NavigateTo(url);
    }

    /// <summary>
    /// Returns true if it is possible to navigate to the previous url.
    /// </summary>
    public bool CanNavigateBack => history.Count >= 2;

    /// <summary>
    /// Navigates to the previous url if possible or does nothing if it is not.
    /// </summary>
    public void NavigateBack()
    {
        if (!CanNavigateBack) return;
        var backPageUrl = history[^2];
        history.RemoveRange(history.Count - 2, 2);
        _navigationManager.NavigateTo(backPageUrl);
    }

    private void OnLocationChanged(object sender, LocationChangedEventArgs e)
    {
        EnsureSize();
        history.Add(e.Location);
    }

    private void EnsureSize()
    {
        if (history.Count < _minHistorySize + _additionalHistorySize) return;
        history.RemoveRange(0, history.Count - _minHistorySize);
    }

    public void Dispose()
    {
        _navigationManager.LocationChanged -= OnLocationChanged;
    }
}
