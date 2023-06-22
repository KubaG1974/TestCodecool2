using System;
using System.Collections.Generic;

namespace TestApp;

public class Flight
{
    public string Identifier { get; set; }
    public Language FlightLanguage { get; set; }
    public List<Pilot> Pilots { get; set; }
    public List<FlightAttendant> FlightAttendants { get; set; }

    public Flight(string identifier, Language flightLanguage)
    {
        Identifier = identifier ?? throw new ArgumentNullException(nameof(identifier));
        FlightLanguage = flightLanguage;
        Pilots = new List<Pilot>();
        FlightAttendants = new List<FlightAttendant>();
    } 
    public bool IsReadyForTakeoff()
    {
        bool allPilotsReceivedCompass = Pilots.TrueForAll(pilot => pilot?.HasReceivedCompass ?? false);
        bool allAttendantsSpeakLanguage = FlightAttendants.TrueForAll(attendant =>
            attendant?.SpokenLanguages?.Contains(FlightLanguage) ?? false);

        if (allPilotsReceivedCompass && allAttendantsSpeakLanguage)
            return true;

        LogClearanceCheck(allPilotsReceivedCompass, allAttendantsSpeakLanguage);
        return false;
    }
    private void LogClearanceCheck(bool allPilotsReceivedCompass, bool allAttendantsSpeakLanguage)
    {
        Console.WriteLine("Clearance check failed:");

        if (!allPilotsReceivedCompass)
            Console.WriteLine("  - Not all pilots have received their compasses.");

        if (!allAttendantsSpeakLanguage)
            Console.WriteLine("  - Not all flight attendants speak the required language.");

        Console.WriteLine();
    }
    
}