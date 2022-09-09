using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp
{
    internal class Calculate
    {
        private const int NR_HOURS = 24;
        public const int WEEK = 7;
        public static int cube(int value)
        {
            int cubeValue;
            cubeValue = value * value * value;
            return cubeValue;
        }
        public static double cifraDeAfaceri(int quantity, double value)
        {
            return quantity * value;
        }

        public static int numberOfWeeks(int days)
        {
            return days / WEEK;
        }

    }
}
