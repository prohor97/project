using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1) Класс Деньги для работы с денежными суммами. Число должно быть представлено двумя полями: типа long для рублей и типа unsigned char - для копеек.
 * Дробная часть (копейки) при выводе на экран должна быть отделена от целой части запятой. Реализовать сложение, вычитание, деление сумм, деление суммы
 * на дробное число, умножение на дробное число и операции сравнения. В функции main проверить эти методы.
 */

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var summ1 = new Money(3, "22"); //создание и инициализация объекта summ1
            summ1.writeConsoleSum();
           
            var summ2 = new Money(1, "11");//создание и инициализация объекта summ2
            summ2.writeConsoleSum();

            new Money().AdditionSum(summ1, summ2);

            new Money().SubtractionSum(summ1, summ2);

            new Money().DivisionOfSumByFractionalNumber(summ1, 12.3);

            new Money().MultiplicationOfSumByFractionalNumber(summ1, 2.1);

            new Money().ComparisonOfAmounts(summ1, summ2);

            Console.ReadKey();
        }
    }
}
