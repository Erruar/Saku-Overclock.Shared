namespace Saku_Overclock.Shared.Models;

public class LocalThemeSettingsOptions
{
    /// <summary>
    ///     Основная строка настройки темы
    /// </summary>
    public string AppBackgroundRequestedTheme
    {
        get;
        set;
    } = "Default";

    /// <summary>
    ///     Массив кастомных тем
    /// </summary>
    public List<ThemeClass> CustomThemes
    {
        get;
        set;
    } = [];
}