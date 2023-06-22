using System;
using System.Collections.Generic;

namespace TestApp;


public class FlightAttendant : AirlineEmployee
{
    public List<Language> SpokenLanguages { get; set; }

    public FlightAttendant(string name, DateTime birthDate, List<Language> spokenLanguages) : base(name, birthDate)
    {
        SpokenLanguages = spokenLanguages ?? throw new ArgumentNullException(nameof(spokenLanguages));
    }
}
