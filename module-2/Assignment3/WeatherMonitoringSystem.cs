using System;

// Define a delegate for events
public delegate void WeatherUpdateEventHandler(object sender, WeatherUpdateEventArgs e);

// Define an event arguments class to carry event-specific data
public class WeatherUpdateEventArgs : EventArgs
{
    public double Temperature { get; }
    public bool IsRaining { get; }

    public WeatherUpdateEventArgs(double temperature, bool isRaining)
    {
        Temperature = temperature;
        IsRaining = isRaining;
    }
}

// Create a class that raises events
class WeatherMonitoringSystem
{
    // Define events
    public event WeatherUpdateEventHandler TemperatureUpdate;
    public event WeatherUpdateEventHandler PrecipitationUpdate;

    // Method to simulate temperature updates
    public void SimulateTemperatureUpdate(double temperature)
    {
        OnTemperatureUpdate(new WeatherUpdateEventArgs(temperature, false));
    }

    // Method to simulate precipitation updates
    public void SimulatePrecipitationUpdate()
    {
        // Simulate random precipitation (for demonstration purposes)
        bool isRaining = new Random().Next(2) == 1;
        OnPrecipitationUpdate(new WeatherUpdateEventArgs(0, isRaining));
    }

    // Raise events
    protected virtual void OnTemperatureUpdate(WeatherUpdateEventArgs e)
    {
        TemperatureUpdate?.Invoke(this, e);
    }

    protected virtual void OnPrecipitationUpdate(WeatherUpdateEventArgs e)
    {
        PrecipitationUpdate?.Invoke(this, e);
    }
}
