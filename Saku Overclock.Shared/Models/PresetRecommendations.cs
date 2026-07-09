namespace Saku_Overclock.Shared.Models;

public class PresetRecommendations
{
    public string[] TemperatureLimits
    {
        get;
        init;
    } = ["80C","90C"];
    
    public string[] StapmLimits
    {
        get;
        init;
    } = ["30W", "35W"];

    public string[] FastLimits
    {
        get;
        init;
    } = ["35W","45W"];
    
    public string[] SlowLimits
    {
        get;
        init;
    } = ["32W", "37W"];
    
    public string[] SlowTime
    {
        get;
        init;
    } = ["5s", "3s"];
    
    public string[] StapmTime
    {
        get;
        init;
    } = ["300s","700s"];
    
    public string[] ProchotRampTime
    {
        get;
        init;
    } = ["20ms","20ms"];
}