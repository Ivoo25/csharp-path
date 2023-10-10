using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idPart = (id.HasValue) ? $"[{id}] - " : string.Empty;
        string departmentPart = (department ??= _OwnerDepartment).ToUpper();

        return $"{idPart}{name} - {departmentPart}";
    }

    private static readonly string _OwnerDepartment = "Owner";
}
