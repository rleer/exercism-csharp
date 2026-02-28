using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

var winID = "Eastern Standard Time";
var conv = TimeZoneInfo.TryConvertWindowsIdToIanaId(winID, out var ianaId);
Console.WriteLine(ianaId);

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc)
    {
        return dtUtc.ToLocalTime();
    }

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            var dt = DateTime.Parse(appointmentDateDescription);
        }

        return new DateTime();
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.GetAlertTime() method");
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.HasDaylightSavingChanged() method");
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.NormalizeDateTime() method");
    }
}
