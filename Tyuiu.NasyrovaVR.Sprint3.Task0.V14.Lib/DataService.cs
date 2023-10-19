using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NasyrovaVR.Sprint3.Task0.V14.Lib
{
    public class DataService : ISprint3Task0V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int i;
            for ( i = startValue; i <= stopValue; i++ )
            {
                multiplySeries = multiplySeries * (Math.Pow((1 / Math.Pow(i, value)), -1));
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}
