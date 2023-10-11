using System;
using System.Runtime.CompilerServices;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int _speed;
    private int _batteryDrain;
    private int _battery;
    private int _distanceDriven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
        _battery = 100;
        _distanceDriven = 0;
    }

    public bool BatteryDrained() => _battery < _batteryDrain;

    public int DistanceDriven() => _distanceDriven;

    public int RemainingDistance() => _speed * (_battery / _batteryDrain);

    public void Drive()
    {
        if (!BatteryDrained())
        {
            _distanceDriven += _speed;
            _battery -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int? _distance;

    public RaceTrack(int? distance)
    {
        _distance = distance ?? 0;
    }

    public bool TryFinishTrack(RemoteControlCar car) => _distance <= car.RemainingDistance();
}
