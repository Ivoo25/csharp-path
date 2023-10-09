using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        /*bool isNewYork, isFake;
        string localNumber = phoneNumber.Substring(8, 4);
        if (phoneNumber.StartsWith("212"))
        {
            isNewYork = true;
        }
        else
        {
            isNewYork = false;
        };

        if (phoneNumber.Substring(4, 3) == "555")
        {
            isFake = true;
        }
        else
        {
            isFake = false;
        };
        return (isNewYork, isFake, localNumber);*/
        string[] nums = phoneNumber.Split('-');
        return (nums[0] == "212", nums[1] == "555", nums[2]);
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        if (phoneNumberInfo.IsFake)
        {
            return true;
        }
        else
        {
            return false;
        }

        throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
    }
}
