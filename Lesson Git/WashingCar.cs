using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Git
{
    /// <summary>
    /// Статический класс Мойка
    /// </summary>
    public static class WashingCar
    {
        /// <summary>
        /// Метод моет машину
        /// </summary>
        /// <param name="car">Эземпляр машинки</param>
        public static void Washing(Car car)
        {
            car.look = false;
        }

        /// <summary>
        /// Метод возвращает стоимость мойки машины
        /// </summary>
        /// <returns></returns>
        public static int GetBill()
        {
            return 25;
        }
    }
}
