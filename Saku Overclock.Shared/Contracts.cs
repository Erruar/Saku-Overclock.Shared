using System.Text.Json.Serialization;
using Saku_Overclock.Shared.Ipc;
using Saku_Overclock.Shared.Models;

namespace Saku_Overclock.Shared;

public class IpcRequest
{
    public string Command { get; set; } = string.Empty;
    public string Payload { get; set; } = string.Empty;
}

public class IpcResponse
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; } = string.Empty;
}

// DTO для передачи параметров методов
public class SmuCommandPayload
{
    public SmuAddressSet Mailbox { get; set; } = null!;
    public uint Command { get; set; }
    public uint[] Arguments { get; set; } = [];
}

public class SmuCommandResult
{
    public byte Status { get; set; }
    public uint[] Arguments { get; set; } = [];
}

public class MsrReadPayload { public uint Index { get; set; } }
public class MsrReadResult { public bool Success { get; set; } public uint Eax { get; set; } public uint Edx { get; set; } }

public class MsrWritePayload { public uint Msr { get; set; } public uint Eax { get; set; } public uint Edx { get; set; } }
public class CoreMaskPayload { public uint Core { get; set; } public uint Ccd { get; set; } public uint Ccx { get; set; } }
public class SetCoperSingleCorePayload { public uint CoreMask { get; set; } public int Margin { get; set; } }

public class SmuAddressSet
{
    public uint MsgAddress { get; set; }
    public uint RspAddress { get; set; }
    public uint ArgAddress { get; set; }

    public SmuAddressSet() { }
    public SmuAddressSet(uint msgAddress, uint rspAddress, uint argAddress)
    {
        MsgAddress = msgAddress;
        RspAddress = rspAddress;
        ArgAddress = argAddress;
    }
}

public enum CpuFamily : byte
{
    Unsupported = 0, Family0Fh = 15, Family10H = 16, Family12H = 18, Family15H = 21, Family16H = 22, Family17H = 23, Family18H = 24, Family19H = 25, Family1Ah = 26
}

public enum CodenameGeneration : byte
{
    Unknown, Fp4, Fp5, Fp6, Ff3, Fp7, Fp8, Am4V1, Am4V2, Am5
}

public enum MemType
{
    Unknown = -1, Ddr4, Ddr5, Lpddr5
}

public struct CommonMotherBoardInfo
{
    public string? MotherBoardName { get; set; }
    public string? MotherBoardVendor { get; set; }
    public string? BiosVersion { get; set; }
}

public struct MemoryModule
{
    public string PartNumber { get; set; }
    public string Manufacturer { get; set; }
    public string Capacity { get; set; }
}

public struct MemoryTimings
{
    public string Tcl { get; set; }
    public string Trcdwr { get; set; }
    public string Trcdrd { get; set; }
    public string Tras { get; set; }
    public string Trp { get; set; }
    public string Trc { get; set; }
}

public struct MemoryConfig
{
    public MemType Type { get; set; }
    public int TotalCapacity { get; set; }
    public List<MemoryModule> Modules { get; set; }
    public int MemorySpeed { get; set; }
    public int FrequencyFromTimings { get; set; }
    public MemoryTimings MemoryTimings { get; set; }
}

public enum SmuStatus : byte
{
    OK = 0x01,
    FAILED = 0xFF,
    UNKNOWN_CMD = 0xFE,
    CMD_REJECTED_PREREQ = 0xFD,
    CMD_REJECTED_BUSY = 0xFC,
    TIMEOUT_MUTEX_LOCK = 0x30,
    TIMEOUT_MAILBOX_READY = 0x31,
    TIMEOUT_MAILBOX_MSG_WRITE = 0x32,
    PCI_FAILED = 0x33,
    CORE_UNAVAILABLE = 0x34, // Custom status, not Smu, when ZenStates-Core is unavailable
    CORE_FAILED = 0x35 // Custom status, not Smu, when CpuService raise exception on some command
}

public record ApplyResult(string ParameterName, bool IsSuccess, SmuStatus SmuStatusCode);


[JsonSourceGenerationOptions(WriteIndented = false, IncludeFields = true)]
[JsonSerializable(typeof(IpcMessage))]
[JsonSerializable(typeof(AppSettings))]
[JsonSerializable(typeof(Preset))]
[JsonSerializable(typeof(Preset[]))]
[JsonSerializable(typeof(PresetId))]
[JsonSerializable(typeof(PresetUpdateMessage))]
[JsonSerializable(typeof(ImportPresetsRequest))]
[JsonSerializable(typeof(ExportPresetRequest))]
[JsonSerializable(typeof(ExportPresetsRequest))]
[JsonSerializable(typeof(ExportAllPresetsRequest))]
[JsonSerializable(typeof(SmuCommandPayload))]
[JsonSerializable(typeof(SmuCommandResult))]
[JsonSerializable(typeof(MsrReadPayload))]
[JsonSerializable(typeof(MsrReadResult))]
[JsonSerializable(typeof(MsrWritePayload))]
[JsonSerializable(typeof(CoreMaskPayload))]
[JsonSerializable(typeof(SetCoperSingleCorePayload))]
[JsonSerializable(typeof(SmuAddressSet))]
[JsonSerializable(typeof(CommonMotherBoardInfo))]
[JsonSerializable(typeof(MemoryConfig))]
[JsonSerializable(typeof(LocalThemeSettingsOptions))]
[JsonSerializable(typeof(List<string>))]
[JsonSerializable(typeof(List<NiIconsElements>))]
[JsonSerializable(typeof(RtssSettings))]
[JsonSerializable(typeof(List<Notify>))]
[JsonSerializable(typeof(float[]))]
[JsonSerializable(typeof(uint[]))]
[JsonSerializable(typeof(bool))]
[JsonSerializable(typeof(bool?))]
[JsonSerializable(typeof(uint))]
[JsonSerializable(typeof(int))]
[JsonSerializable(typeof(double))]
[JsonSerializable(typeof(float))]
[JsonSerializable(typeof(float?))]
public partial class IpcJsonContext : JsonSerializerContext
{
}