using Saku_Overclock.Shared.Models;

namespace Saku_Overclock.Shared.Ipc;

public enum IpcMessageKind
{
    Command,   // клиент -> Core, ждём ответ
    Response,  // Core -> клиент, ответ на Command по Id
    Event      // Core -> любой клиент, без ожидания ответа
}

public class IpcMessage
{
    public IpcMessageKind Kind { get; set; }
    public string Id { get; set; } = string.Empty;     // correlation id, только для Command/Response
    public string Name { get; set; } = string.Empty;   // имя команды или события
    public string Payload { get; set; } = string.Empty; // сериализованные данные внутри
    public bool IsSuccess { get; set; } = true;
    public string? Error { get; set; }
}

public class PresetUpdateMessage
{
    public int Index { get; set; }
    public Preset Preset { get; set; } = null!;
}

public class ImportPresetsRequest
{
    public string Folder { get; set; } = string.Empty;
    public string File { get; set; } = string.Empty;
    public bool Append { get; set; }
}

public class ExportPresetRequest
{
    public int Index { get; set; }
    public string Folder { get; set; } = string.Empty;
    public string File { get; set; } = string.Empty;
}

public class ExportPresetsRequest
{
    public int[] Indices { get; set; } = [];
    public string Folder { get; set; } = string.Empty;
    public string File { get; set; } = string.Empty;
}

public class ExportAllPresetsRequest
{
    public string Folder { get; set; } = string.Empty;
    public string File { get; set; } = string.Empty;
}