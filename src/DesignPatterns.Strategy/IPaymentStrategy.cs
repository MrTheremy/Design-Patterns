﻿namespace DesignPatterns.Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}