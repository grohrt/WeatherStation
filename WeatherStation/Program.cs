using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation {
  class Program {
    static void Main(string[] args) {
      var weatherData = new WeatherData();

      var currentDisplay = new CurrentConditionsDisplay(weatherData);
      var heatIndexDisplay = new HeatIndexDisplay(weatherData);

      weatherData.SetMeasurements(80, 65, 30.4f);
      weatherData.SetMeasurements(82, 70, 29.2f);
      weatherData.SetMeasurements(78, 90, 29.2f);

      Console.Write("Press any key to continue...");
      Console.ReadKey();
    }
  }
}
