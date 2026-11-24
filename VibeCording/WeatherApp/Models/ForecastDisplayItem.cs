using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models;

public class ForecastDisplayItem
{
    public string Date { get; set; } = "";

    public string Weather { get; set; } = "";

    public string MaxTemperature { get; set; } = "";

    public string MinTemperature { get; set; } = "";

    public string PrecipitationProbability { get; set; } = "";
}