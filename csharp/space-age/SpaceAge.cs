using System;

public class SpaceAge
{
    private const double _EarthYearInSeconds = 31557600;
    private readonly double _MercuryOrbitSeconds = _EarthYearInSeconds * 0.2408467;
    private readonly double _VenusOrbitSeconds = _EarthYearInSeconds * 0.61519726;
    private readonly double _MarsOrbitSeconds = _EarthYearInSeconds * 1.8808158;
    private readonly double _JupiterOrbitSeconds = _EarthYearInSeconds * 11.862615;
    private readonly double _SaturnOrbitSeconds = _EarthYearInSeconds * 29.447498;
    private readonly double _UranusOrbitSeconds = _EarthYearInSeconds * 84.016846;
    private readonly double _NeptuneOrbitSeconds = _EarthYearInSeconds * 164.79132;

    public double secondsOld { get; set; }
    public SpaceAge(double? secondsPast)
    {
        secondsOld = secondsPast ?? 0;
    }

    public double calculateAge(double orbitSeconds)
    {
        return Math.Round(secondsOld / orbitSeconds, 2);
    }

    public double OnEarth() => calculateAge(_EarthYearInSeconds);

    public double OnMercury() => calculateAge(_MercuryOrbitSeconds);

    public double OnVenus() => calculateAge(_VenusOrbitSeconds);

    public double OnMars() => calculateAge(_MarsOrbitSeconds);

    public double OnJupiter() => calculateAge(_JupiterOrbitSeconds);

    public double OnSaturn() => calculateAge(_SaturnOrbitSeconds);

    public double OnUranus() => calculateAge(_UranusOrbitSeconds);

    public double OnNeptune() => calculateAge(_NeptuneOrbitSeconds);
}