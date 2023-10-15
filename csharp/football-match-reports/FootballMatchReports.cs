using System;
using System.Collections.Generic;
public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) =>
        (playerDescriptionForNumber.ContainsKey(shirtNum))
            ? playerDescriptionForNumber[shirtNum]
            : throw new ArgumentOutOfRangeException(nameof(shirtNum), $"Not expected shirt number: {shirtNum}");
    //This checks if the number is in the dictionary, if it is, it returns the value, if not, it throws an exception

    public static string AnalyzeOffField(object report) => report switch // report is the object that is passed in
    {
        int supporters => $"There are {supporters} supporters at the match.", //if report is an int, supporters is assigned the value of report
        String announcement => announcement, //if report is a string, announcement is assigned the value of report
        Injury injury => $"Oh no! {injury.GetDescription()} Medics are on the field.",
        Incident incident => incident.GetDescription(),
        Manager manager => ManagerDescription(manager),
        _ => throw new ArgumentException(nameof(report), $"Not expected data type: {report}")
    };
    #region Helper methods
    private static string ManagerDescription(Manager manager) => (manager.Club is null) ? manager.Name : $"{manager.Name} ({manager.Club})";
    #endregion 
    #region Fixed values
    private static readonly Dictionary<int, string> playerDescriptionForNumber = new Dictionary<int, string>
    {
        {1, "goalie"},
        {2, "left back"},
        {3, "center back"},
        {4, "center back"},
        {5, "right back"},
        {6, "midfielder"},
        {7, "midfielder"},
        {8, "midfielder"},
        {9, "left wing"},
        {10, "striker"},
        {11, "right wing"}
    };
    #endregion 
}