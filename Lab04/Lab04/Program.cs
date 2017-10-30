using System;
using System.IO;
public class switchLearning
{
    public static void Main()
    {
        Console.Write("Input day name (sun,mon,tue,wed,thu,fri or sat) : ");
        string gradeString = Console.ReadLine();
        string message;
        switch (gradeString)
        {
            case "sun":
                message = "sun is Sunday, color Red";
                break;
            case "mon":
                message = "sun is Monday, color Yellow";
                break;
            case "tue":
                message = "sun is Tuesday, color Pink";
                break;
            case "wed":
                message = "sun is Wednesday, color Green";
                break;
            case "thu":
                message = "sun is Thursday, color Orange";
                break;
            case "fri":
                message = "sun is Friday, color Blue";
                break;
            case "sat":
                message = "sun is Saturday, color Purple";
                break;
            default:
                message = "Incorrect name";
                break;
        }
        Console.WriteLine(message);
    }
}


















