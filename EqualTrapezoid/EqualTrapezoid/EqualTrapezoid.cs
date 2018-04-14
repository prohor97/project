using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EqualTrapezoid
{
    class EqualTrapezoid
    {
        private double _AB;
        private double _BC;
        private double _CD;
        private double _DA;
        private double _h;
        private double _AC;
        private double _BD;

        public Coordinates A { get; private set; }
        public Coordinates B { get; private set; }
        public Coordinates C { get; private set; }
        public Coordinates D { get; private set; }
        public double Area { get; private set; }

        //конструктор принимающий точки
        public EqualTrapezoid(Coordinates a, Coordinates b, Coordinates c, Coordinates d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            _AB = Math.Sqrt(Math.Pow(Math.Abs(B.X) - Math.Abs(A.X), 2) + Math.Pow(Math.Abs(B.Y) - Math.Abs(A.Y), 2));
            _BC = Math.Sqrt(Math.Pow(Math.Abs(C.X) - Math.Abs(B.X), 2) + Math.Pow(Math.Abs(C.Y) - Math.Abs(B.Y), 2));
            _CD = _AB;
            _DA = Math.Sqrt(Math.Pow(Math.Abs(D.X) - Math.Abs(A.X), 2) + Math.Pow(Math.Abs(D.Y) - Math.Abs(A.Y), 2));
            _h = Math.Sqrt(Math.Pow((_DA - _BC) / 2, 2) + Math.Pow(_AB, 2));
            Area = (_BC + _DA) * _h / 2;
        }

        public EqualTrapezoid()
        {

        }

        // ввыод инфомрации о координатах точек
        public void OutputCoordinateTrapezoid()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Координаты точек трапеции:");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Координаты точки A: x = {A.X}, y = {A.Y}");
            Console.WriteLine($"Координаты точки B: x = {B.X}, y = {B.Y}");
            Console.WriteLine($"Координаты точки C: x = {C.X}, y = {C.Y}");
            Console.WriteLine($"Координаты точки D: x = {D.X}, y = {D.Y}");
            Console.WriteLine("---------------------------------------------\n");
        }

        // проверка является ли трапеция равнобокой
        public void CheckTheIsoscelesTrapezoid()
        {
           _AC = Math.Sqrt(Math.Pow(Math.Abs(C.X) - Math.Abs(A.X), 2) + Math.Pow(Math.Abs(C.Y) - Math.Abs(A.Y), 2));
           _BD = Math.Sqrt(Math.Pow(Math.Abs(B.X) - Math.Abs(D.X), 2) + Math.Pow(Math.Abs(B.Y) - Math.Abs(D.Y), 2));

            if (_AC == _BD)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Данная трапеция является равнобедренной!!!");
                Console.WriteLine("---------------------------------------------\n");
            }
            else
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Данная трапеция не является равнобедренной!!!");
                Console.WriteLine("---------------------------------------------\n");
            }
        }

        // вывод информации о трапеции: длины сторон, периметр, площадь
        public void InfoAboutTrapezoid()
        {
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("Информация о трапеции:");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Сторона AB = {_AB}.");
            Console.WriteLine($"Сторона CD = {_CD}.");
            Console.WriteLine($"Сторона BC = {_BC}.");
            Console.WriteLine($"Сторона DA = {_DA}.");
            Console.WriteLine($"Периметр трапеции равен {_AB + _BC + _CD + _DA}");
            Console.WriteLine($"Площадь трапеции равена {Area}");
            Console.WriteLine("---------------------------------------------\n");


        }
    }
}
