using System;
using System.Runtime.InteropServices;

namespace SrvMan.WinService.WinApi
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ServiceDescriptionStruct
    {
        public string lpDescription;
    }
}