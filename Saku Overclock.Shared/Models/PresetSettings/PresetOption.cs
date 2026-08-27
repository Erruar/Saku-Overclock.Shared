using System.Text.Json.Serialization;

namespace Saku_Overclock.Shared.Models.PresetSettings;

public class PresetOption<T>
{
    public bool IsEnabled { get; set; }
    public T Value { get; set; } = default!;

    [JsonConstructor]
    public PresetOption() { }

    public PresetOption(bool isEnabled, T value)
    {
        IsEnabled = isEnabled;
        Value = value;
    }

    public PresetOption(T value) : this(false, value) { }
}