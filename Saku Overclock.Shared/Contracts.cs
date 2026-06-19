using System.Text.Json.Serialization;

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

// Переносим структуры данных ядра для шаринга между Клиентом и Сервисом
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

public enum MemType : int
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


[JsonSourceGenerationOptions(WriteIndented = false)]
[JsonSerializable(typeof(IpcRequest))]
[JsonSerializable(typeof(IpcResponse))]
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