namespace BlazorBootstrapWASA.Services;

public class ThemeProvider
{
    public string CurrentTheme { get; private set; } = "theme-light.css";
    public event Action? OnThemeChanged;

    public void SetTheme(string theme)
    {
        if (theme != CurrentTheme)
        {
            CurrentTheme = theme;
            OnThemeChanged?.Invoke();
        }
    }
}