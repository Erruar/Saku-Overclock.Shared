namespace Saku_Overclock.Shared.Models;

public class DefaultThemesProvider
{
    public static List<ThemeClass> DefaultThemes =>
    [
        new()
        {
            ThemeName = "Theme_Default",
            ThemeLight = false,
            ThemeCustom = false,
            ThemeOpacity = 0.0,
            ThemeMaskOpacity = 0.0,
            ThemeCustomBg = false,
            ThemeBackground = ""
        },
        new()
        {
            ThemeName = "Theme_Light",
            ThemeLight = true,
            ThemeCustom = false,
            ThemeOpacity = 0.0,
            ThemeMaskOpacity = 0.0,
            ThemeCustomBg = false,
            ThemeBackground = ""
        },
        new()
        {
            ThemeName = "Theme_Dark",
            ThemeLight = false,
            ThemeCustom = false,
            ThemeOpacity = 0.0,
            ThemeMaskOpacity = 0.0,
            ThemeCustomBg = false,
            ThemeBackground = ""
        },
        new()
        {
            ThemeName = "Theme_Clouds",
            ThemeLight = true,
            ThemeCustom = false,
            ThemeOpacity = 0.5,
            ThemeMaskOpacity = 1.0,
            ThemeCustomBg = false,
            ThemeBackground = "ms-appx:///Assets/Themes/DuwlKmK.png"
        },
        new()
        {
            ThemeName = "Theme_Neon",
            ThemeLight = false,
            ThemeCustom = false,
            ThemeOpacity = 0.3,
            ThemeMaskOpacity = 0.3,
            ThemeCustomBg = false,
            ThemeBackground = "ms-appx:///Assets/Themes/DuwlKmK.png"
        },
        new()
        {
            ThemeName = "Theme_Raspberry",
            ThemeLight = true,
            ThemeCustom = false,
            ThemeOpacity = 1.0,
            ThemeMaskOpacity = 1.0,
            ThemeCustomBg = false,
            ThemeBackground = "ms-appx:///Assets/Themes/fw41KXN.png"
        },
        new()
        {
            ThemeName = "Theme_Sand",
            ThemeLight = true,
            ThemeCustom = false,
            ThemeOpacity = 0.7,
            ThemeMaskOpacity = 1.0,
            ThemeCustomBg = false,
            ThemeBackground = "ms-appx:///Assets/Themes/ZqjqlOs.png"
        },
        new()
        {
            ThemeName = "Theme_Coffee",
            ThemeLight = false,
            ThemeCustom = false,
            ThemeOpacity = 0.3,
            ThemeMaskOpacity = 1.0,
            ThemeCustomBg = false,
            ThemeBackground = "ms-appx:///Assets/Themes/ZqjqlOs.png"
        }
    ];
}