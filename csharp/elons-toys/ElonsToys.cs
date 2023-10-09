using System;

class RemoteControlCar
{
    private int _distance = 0;
    private int _battery = 100;

    public static RemoteControlCar Buy()
    {
        //throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        //throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
        return $"Driven {_distance} meters";

    }

    public string BatteryDisplay()
    {
        //throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
        return _battery == 0 ? $"Battery empty" : $"Battery at {_battery}%";
    }

    public void Drive()
    {
        //throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
        if (_battery > 0)
        {
            _distance += 20;
            _battery -= 1;
        }
    }
}
