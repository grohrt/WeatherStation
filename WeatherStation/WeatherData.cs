﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation {
  class WeatherData : ISubject {

    private List<IObserver> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData() {
      observers = new List<IObserver>();
    }

    public void measurementsChanged() {
      NotifyObservers();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure) {
      this.temperature = temperature;
      this.humidity = humidity;
      this.pressure = pressure;
      measurementsChanged();
    }

    #region ISubject Members

    public void RegisterObserver(IObserver o) {
      observers.Add(o);
    }

    public void RemoveObserver(IObserver o) {
      observers.Remove(o);
    }

    public void NotifyObservers() {
      foreach (var observer in observers) {
        observer.Update(temperature, humidity, pressure);
      }
    }

    #endregion
  }
}
