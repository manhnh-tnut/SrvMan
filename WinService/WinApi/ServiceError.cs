namespace SrvMan.WinService.WinApi
{
    public enum ServiceError
    {
        NoChanges = -1,

        Ignore = 0x00000000,

        Normal = 0x00000001,

        Severe = 0x00000002,

        Critical = 0x00000003
    }
}