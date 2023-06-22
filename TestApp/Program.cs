using System;
using System.Collections.Generic;

namespace TestApp;

public class Program
{
    public static void Main()
    {
        var pilot1 = new Pilot("Jan Kowalski", new DateTime(1979, 5, 10), true);
        var pilot2 = new Pilot("Zenon Kowalski", new DateTime(1985, 1, 15), false);

        var attendant1 = new FlightAttendant("Emily Brown", new DateTime(1992, 7, 22), new List<Language> { Language.English, Language.German });
        var attendant2 = new FlightAttendant("Oliver Johnson", new DateTime(1993, 9, 8), new List<Language> { Language.Spanish, Language.Russian });
        var attendant3 = new FlightAttendant("Sophia Wilson", new DateTime(1995, 3, 18), new List<Language> { Language.English, Language.German });

        var flight = new Flight("ABC123", Language.German);

        flight.Pilots.AddRange(new[] { pilot1, pilot2 });
        flight.FlightAttendants.AddRange(new[] { attendant1, attendant2, attendant3 });

        pilot1.HasReceivedCompass = true;
        pilot2.HasReceivedCompass = true;

        bool isReady = flight.IsReadyForTakeoff();
        Console.WriteLine("Flight is ready for takeoff: " + isReady);
    }
}