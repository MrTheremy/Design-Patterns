﻿namespace DesignPatterns.Decorators
{
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Coffee";
        }

        public double GetCost()
        {
            return 5.0; // Base cost of the coffee
        }
    }
}