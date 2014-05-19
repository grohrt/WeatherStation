using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation {
  public class CurrentConditionsDisplay : IObserver, IDisplayElement {
    private float temperature;
    private float humidity;
    private ISubject weatherData;

    public CurrentConditionsDisplay(ISubject weatherData) {
      this.weatherData = weatherData;
      weatherData.RegisterObserver(this);
    }

    #region IObserver Members

    public void Update(float temperature, float humidity, float pressure) {
      this.temperature = temperature;
      this.humidity = humidity;
      Display();
    }

    #endregion

    #region IDisplayElement Members

    public void Display() {
      Console.WriteLine("Current conditions: " + temperature + "F degress and " + 
        humidity + "% humidity");
    }

    #endregion
  }
}
