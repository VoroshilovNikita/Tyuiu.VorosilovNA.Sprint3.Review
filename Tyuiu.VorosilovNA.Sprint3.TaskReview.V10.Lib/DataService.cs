using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VorosilovNA.Sprint3.TaskReview.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((((5 * x) + 2.5) / (Math.Sin(x) + 3)) + 2 * x + Math.Cos(x)), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
