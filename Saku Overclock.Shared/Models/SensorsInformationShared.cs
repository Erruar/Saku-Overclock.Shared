using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Saku_Overclock.Shared.Models;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct SensorsInformationShared
{
    public volatile int Iteration; 
    
    public SafeString16 CpuCodeName;
    public double CpuStapmLimit;
    public double CpuStapmValue;
    public double CpuFastLimit;
    public double CpuFastValue;
    public double CpuSlowLimit;
    public double CpuSlowValue;
    public double ApuSlowLimit;
    public double ApuSlowValue;
    public double VrmTdcValue;
    public double VrmTdcLimit;
    public double VrmEdcValue;
    public double VrmEdcLimit;
    public double VrmPsiValue;
    public double VrmPsiSocValue;
    public double SocTdcValue;
    public double SocTdcLimit;
    public double SocEdcValue;
    public double SocEdcLimit;
    public double CpuTempValue;
    public double CpuTempLimit;
    public double ApuTempValue;
    public double ApuTempLimit;
    public double DgpuTempValue;
    public double DgpuTempLimit;
    public double CpuStapmTimeValue;
    public double CpuSlowTimeValue;
    public double CpuUsage;
    public SafeDoubleArray32 CpuFrequencyPerCore;
    public SafeDoubleArray32 CpuVoltagePerCore;
    public SafeDoubleArray32 CpuPowerPerCore;
    public SafeDoubleArray32 CpuTemperaturePerCore;
    public double ApuFrequency;
    public double ApuVoltage;
    public double MemFrequency;
    public double FabricFrequency;
    public double SocPower;
    public double SocVoltage;
    public double CpuFrequency;
    public double CpuVoltage;
    
    public SafeString32 BatteryName;
    public bool BatteryUnavailable;
    public int BatteryPercent;
    public int BatteryState;
    public SafeString16 BatteryHealth;
    public SafeString32 BatteryCycles;
    public SafeString32 BatteryCapacity;
    public double BatteryChargeRate;
    public int BatteryLifeTime;
    
    public double RamTotal;
    public double RamBusy;
    public int RamUsagePercent;

    public bool IsNvidiaGpuAvailable;
    public SafeString16 NvidiaDriverVersion;
    public SafeString16 NvidiaVramSize;
    public SafeString16 NvidiaVramType;
    public SafeString16 NvidiaVramWidth;
    public double NvidiaVramFrequency;
    public double NvidiaGpuUsage;
    public double NvidiaGpuFrequency;
    public double NvidiaGpuTemperature;
    
    public volatile int IterationEnd;
}

[InlineArray(32)]
public struct SafeDoubleArray32
{
    private double _element0;
}

[InlineArray(16)]
public struct SafeString16
{
    private char _element0;
}

[InlineArray(32)]
public struct SafeString32
{
    private char _element0;
}