using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorators
{
    public interface ICoffee
    {
        string GetDescription();

        double GetCost();
    }
}