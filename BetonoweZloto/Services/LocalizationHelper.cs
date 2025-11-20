namespace BetonoweZloto.Services;

public class LocalizationHelper
{
    private readonly LanguageService _languageService;

    public LocalizationHelper(LanguageService languageService)
    {
        _languageService = languageService;
    }

    public string Get(Dictionary<string, string> resource)
    {
        var lang = _languageService.GetCurrentLanguageCode();
        return resource.ContainsKey(lang) ? resource[lang] : resource["pl"];
    }
}
