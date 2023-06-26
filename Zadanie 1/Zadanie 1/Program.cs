using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj czas w sekundach: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        string formattedTime = FormatTime(seconds);
        Console.WriteLine(formattedTime);
    }

    static string FormatTime(int totalSeconds)
    {
        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;

        string formattedHours = hours.ToString("D2");
        string formattedMinutes = minutes.ToString("D2");
        string formattedSeconds = seconds.ToString("D2");

        string formattedTime = $"{formattedHours}:{formattedMinutes}:{formattedSeconds}";

        return formattedTime;
    }
}