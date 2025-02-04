﻿namespace DesignPatterns.Observer
{
    public class CurrentConditionsDisplay : IObserver
    {
        private float temperature;
        private float humidity;

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        }
    }
}