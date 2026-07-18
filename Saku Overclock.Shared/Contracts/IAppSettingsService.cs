namespace Saku_Overclock.Shared.Contracts;

public interface IAppSettingsService
{
    /// <summary>
    ///     Loading client settings
    /// </summary>
    Task LoadSettingsAsync();

    /// <summary>
    ///     Fixed title bar flag
    /// </summary>
    bool FixedTitleBar
    {
        get;
        set;
    }

    /// <summary>
    ///     Autostart type:
    ///     0 - Disabled,
    ///     1 - Autostart with OS,
    ///     2 - Autostart & tray
    /// </summary>
    int AutostartType
    {
        get;
        set;
    }

    /// <summary>
    ///     Hide app to tray after closing window
    /// </summary>
    bool HideToTray
    {
        get;
        set;
    }

    /// <summary>
    ///     Auto-update feature flag
    /// </summary>
    bool CheckForUpdates
    {
        get;
        set;
    }

    /// <summary>
    ///     Hotkeys enabled flag
    /// </summary>
    bool HotkeysEnabled
    {
        get;
        set;
    }

    /// <summary>
    ///     Apply last applied settings on app launch
    /// </summary>
    bool ReapplyLatestSettingsOnAppLaunch
    {
        get;
        set;
    }

    /// <summary>
    ///     Apply last applied settings periodically (to avoid vendor-lock and changing from other programs)
    /// </summary>
    bool ReapplyOverclock
    {
        get;
        set;
    }

    /// <summary>
    ///     'Apply last applied settings periodically' time
    /// </summary>
    double ReapplyOverclockTimer
    {
        get;
        set;
    }

    /// <summary>
    ///     Selected theme
    /// </summary>
    int ThemeType
    {
        get;
        set;
    }

    /// <summary>
    ///     TrayMon enabled flag (monitoring in system tray)
    /// </summary>
    bool NiIconsEnabled
    {
        get;
        set;
    }

    /// <summary>
    ///     Rtss overlay enabled flag (monitoring in-game)
    /// </summary>
    bool RtssMetricsEnabled
    {
        get;
        set;
    }

    /// <summary>
    ///     TrayMon icons displaying type
    /// </summary>
    int NiIconsType
    {
        get;
        set;
    }

    // Presets and their options

    /// <summary>
    ///     Selected preset
    /// </summary>
    int Preset
    {
        get;
        set;
    }
    
    /// <summary>
    ///     Added default premade presets flag
    /// </summary>
    public bool PremadePresetsAdded
    {
        get;
        set;
    }
    
    /// <summary>
    ///     Selected preset for automatic apply on charger
    /// </summary>
    public string AcPreset
    {
        get;
        set;
    }
    
    /// <summary>
    ///     Selected preset for automatic apply on battery
    /// </summary>
    public string BatteryPreset
    {
        get;
        set;
    }

    /// <summary>
    ///     App first run flag
    /// </summary>
    bool AppFirstRun
    {
        get;
        set;
    }
}