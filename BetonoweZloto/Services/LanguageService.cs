using System.Globalization;

namespace BetonoweZloto.Services;

public class LanguageService
{
    public event Action? OnLanguageChanged;
    
    private CultureInfo _currentCulture = new("pl");
    
    public CultureInfo CurrentCulture
    {
        get => _currentCulture;
        set
        {
            if (_currentCulture.Name != value.Name)
            {
                _currentCulture = value;
                CultureInfo.CurrentCulture = value;
                CultureInfo.CurrentUICulture = value;
                OnLanguageChanged?.Invoke();
            }
        }
    }
    
    public void SetLanguage(string culture)
    {
        CurrentCulture = new CultureInfo(culture);
    }
    
    public string GetCurrentLanguageCode()
    {
        return CurrentCulture.TwoLetterISOLanguageName;
    }
}
