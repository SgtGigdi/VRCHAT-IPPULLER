// CookieHelper.cs
using System.Net;

public static class CookieHelper
{
    // Static property to store cookies in a CookieContainer
    public static CookieContainer CookieContainer { get; set; } = new CookieContainer();
}
