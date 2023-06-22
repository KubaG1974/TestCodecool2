using System;

namespace TestApp;

public class Pilot : AirlineEmployee
{
    public bool HasReceivedCompass { get; set; }
    public bool IsCaptain { get; set; }

    public Pilot(string name, DateTime birthDate, bool isCaptain) : base(name, birthDate)
    {
        IsCaptain = isCaptain;
    }
}
