using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

    public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => _afternoonStartHour <= appointmentDate.Hour && appointmentDate.Hour < _afternoonEndHour;

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate}.";

    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, _anniversaryMonth, _anniversaryDay, 0, 0, 0);

    //------------------------------------------- fixed values
    private static readonly int _afternoonStartHour = 12;
    private static readonly int _afternoonEndHour = 18;
    private static readonly int _anniversaryMonth = 9;
    private static readonly int _anniversaryDay = 15;
}
