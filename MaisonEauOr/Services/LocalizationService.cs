using System.Text.Json;
using MaisonEauOr.Languages;

namespace MaisonEauOr.Services;

public class LocalizationService
{
    public string[] SupportedLanguages { get; set; } = { "fr-FR", "en-US" };
    public string SelectedLanguage { get; set; }
    private Dictionary<string, string> _translations = new();
    public delegate Task LanguageChangedEventHandler(string language);
    public event LanguageChangedEventHandler LanguageChanged = null!;
    
    public LocalizationService()
    {
        SelectedLanguage = SupportedLanguages[0];
        Init();
    }

    private Task Init()
    {
        var stream = File.OpenRead($".\\Languages\\{SelectedLanguage}.json");
        stream.Seek(0, SeekOrigin.Begin);
        _translations = JsonSerializer.Deserialize<Dictionary<string, string>>(stream)!;
        LanguageChanged?.Invoke(SelectedLanguage);
        return Task.CompletedTask;
    }

    public async Task SetLanguage(string lang)
    {
        SelectedLanguage = SupportedLanguages.Contains(lang) ? lang : SupportedLanguages[0]; 
        await Init();
    }
    
    public string Get(string key)
    {
        _translations.TryGetValue(key, out string? val);
        return string.IsNullOrWhiteSpace(val) ? "undefined" : val;
    }

    public Language GetCurrentLanguage()
    {
        return SelectedLanguage switch
        {
            "fr-FR" => Language.FR,
            "en-US" => Language.EN,
            _ => Language.FR
        };
    }
    
    public string GetLanguageText(Language lang)
    {
        return lang switch
        {
            Language.FR => "fr-FR",
            Language.EN => "en-US",
            _ => "fr-FR"
        };
    }
}