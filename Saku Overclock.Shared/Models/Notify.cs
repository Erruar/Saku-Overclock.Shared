namespace Saku_Overclock.Shared.Models;

public class Notify
{
    public string Title
    {
        get;
        set;
    } = "";

    public string Msg
    {
        get;
        set;
    } = "";

    public InfoBarSeverity Type
    {
        get;
        init;
    } = InfoBarSeverity.Informational;

    public static bool IsClosable => true;
}