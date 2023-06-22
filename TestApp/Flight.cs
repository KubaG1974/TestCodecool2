using System;
using System.Collections.Generic;

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
}