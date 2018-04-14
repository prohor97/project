using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 2) Класс Равнобочная трапеция, члены класса: координаты 4-х точек. Предусмотреть в классе конструктор и методы: проверка, является ли фигура равнобочной
 * трапецией; вычисления и вывода сведений о фигуре: длины сторон, периметр, площадь. В функции main продемонстрировать работу с классом: дано N трапеций,
 * найти количество трапеций, у которых площадь больше средней площади.
 */

namespace EqualTrapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var figura = new EqualTrapezoid(new Coordinates(3, 3), new Coordinates(6, 9), new Coordinates(12, 9), new Coordinates(15, 3));
            
            figura.OutputCoordinateTrapezoid();

            figura.CheckTheIsoscelesTrapezoid();

            figura.InfoAboutTrapezoid();*/

            // вторая часть задания
            int amountOfTrapezoid;
            double sumOfAreas = 0.0;
            double avarageArea = 0.0;

            var ArrayOfTrapeziums = new List<EqualTrapezoid>();
           
            Console.WriteLine("Введите количество трапеций:");
            amountOfTrapezoid = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amountOfTrapezoid; i++)
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("Введите значение координат точки A.");
                Console.Write("x:");
                var aX = Convert.ToInt32(Console.ReadLine());
                Console.Write("y:");
                var aY = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите значение координат точки B.");
                Console.Write("x:");
                var bX = Convert.ToInt32(Console.ReadLine());
                Console.Write("y:");
                var bY = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите значение координат точки C.");
                Console.Write("x:");
                var cX = Convert.ToInt32(Console.ReadLine());
                Console.Write("y:");
                var cY = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите значение координат точки D.");
                Console.Write("x:");
                var dX = Convert.ToInt32(Console.ReadLine());
                Console.Write("y:");
                var dY = Convert.ToInt32(Console.ReadLine());

                var trapioid = new EqualTrapezoid(new Coordinates(aX, aY), new Coordinates(bX, bY),
                    new Coordinates(cX, cY), new Coordinates(dX, dY));

                ArrayOfTrapeziums.Add(trapioid);

                sumOfAreas += trapioid.Area;
            }

            //Console.WriteLine(sumOfAreas);
            sumOfAreas /= amountOfTrapezoid;
            //Console.WriteLine(sumOfAreas);

            foreach (var item in ArrayOfTrapeziums)
            {
                if (item.Area > sumOfAreas)
                {
                    item.InfoAboutTrapezoid();
                }
            }

            Console.ReadKey();
        }
    }
}
