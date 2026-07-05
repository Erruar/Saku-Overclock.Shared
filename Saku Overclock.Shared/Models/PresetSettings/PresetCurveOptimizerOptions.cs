namespace Saku_Overclock.Shared.Models.PresetSettings;

public class PresetCurveOptimizerOptions
{
    public PresetOption<double> AutomaticCurveOptimizerManagement =  new(false, -10);
    public PresetOption<double> CpuCurveOptimizerUndervoltingLevel = new(false, -10);
    public PresetOption<double> IntegratedGpuCurveOptimizerUndervoltingLevel = new(false, -10);
}