using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Git
{
   public static class FixedCar
    {
        public static void Fix (Car car)
        {
            car.StateEngine = true;
        }
        public static int GetBill (Car car)
        {
            switch (car.Mileage)
            {
                case 1000:
                    return 120;
                case 2000:
                    return 150;
                case 5000:
                    return 180;
                default:
                    return 0;
            }
        }
    }
}
