using System.Runtime.InteropServices;

namespace SrvMan.WinService.WinApi
{
    [StructLayout(LayoutKind.Sequential)]
    public class ServiceDescriptionClass
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpDescription;
    }
}