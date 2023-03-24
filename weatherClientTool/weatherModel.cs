namespace weatherClientTool;
public class weatherModel
{
    public current_weather current_Weather
    {
        get; set;
    }
}
public class current_weather
{
    public double temperature { get; set; }
    public double windSpeed { get; set; }
}