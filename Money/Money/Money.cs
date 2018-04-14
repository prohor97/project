using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Money
    {
        //переменная отвечающая за рубли
        private long _ruble;
        //переменная отвечающая за копейки
        private string _kopeck;
        //флаг отвечающий за вывод суммы на консоль
        private bool _needToWriteInConsole = true;
        //переменная для преобразования первой суммы
        private double _createSumm1 = 0.0;
        //переменная для преобразования второй суммы
        private double _createSumm2 = 0.0;
        //переменная для хранения результата операций между первой и второй суммы
        private double _result = 0.0;

        // свойство Ruble 
        public long Ruble
        {

            get { return _ruble; }
            private set
            {
                if (Convert.ToInt32(value) >= 0)
                {
                    _ruble = value;
                }
                else
                {
                    Console.WriteLine("Некорректно введены рубли!!!\n");
                    _needToWriteInConsole = false;
                }
            }
        }

        // свойство Kopeck
        public string Kopeck
        {
            get { return _kopeck; }
            private set
            {
                if (Convert.ToInt32(value) >= 0 && Convert.ToInt32(value) < 100)
                {
                    _kopeck = value;
                }
                else
                {
                    Console.WriteLine("Некорректно введены копейки!!!\n");
                    _needToWriteInConsole = false;
                }
            }
        }

        //конструктор с параметрами ruble и kopeck
        public Money(long ruble, string kopeck)
        {
            Ruble = ruble;
            Kopeck = kopeck;
        }

        //конструктор без параметров
        public Money()
        {
        }

        //функция сложения двух сумм
        public void AdditionSum(Money summ1, Money summ2)
        {
            _createSumm1 = Convert.ToDouble(summ1.Ruble + "," + summ1.Kopeck);
            _createSumm2 = Convert.ToDouble(summ2.Ruble + "," + summ2.Kopeck);

            _result = _createSumm1 + _createSumm2;
            Console.WriteLine($"Сложение двух сумм равно: {_result}.\n");
        }

        //функция вычитания двух сумм
        public void SubtractionSum(Money summ1, Money summ2)
        {
            _createSumm1 = Convert.ToDouble(summ1.Ruble + "," + summ1.Kopeck);
            _createSumm2 = Convert.ToDouble(summ2.Ruble + "," + summ2.Kopeck);

            if (_createSumm1 > _createSumm2)
            {
                _result = _createSumm1 - _createSumm2;
                Console.WriteLine($"Сложение двух сумм равно: {_result}.\n");
            }
            else
            {
                Console.WriteLine($"Невозможно выполнить функцию вычитания, потому что первая сумма ({_createSumm1}) меньше второй({_createSumm2}).\n");
            }
        }

        //функция деления суммы на дробное число
        public void DivisionOfSumByFractionalNumber(Money summ1, double _number)
        {
            _createSumm1 = Convert.ToDouble(summ1.Ruble + "," + summ1.Kopeck);

            _result = _createSumm1 / _number;
            Console.WriteLine($"Деление суммы({_createSumm1}) на {_number}: {_result}.\n");
        }

        //функция умножения суммы на дробное число
        public void MultiplicationOfSumByFractionalNumber(Money summ1, double _number)
        {
            _createSumm1 = Convert.ToDouble(summ1.Ruble + "," + summ1.Kopeck);

            _result = _createSumm1 * _number;
            Console.WriteLine($"Умножение суммы({_createSumm1}) на {_number}: {_result}.\n");
        }

        //функция сравнения двух сумм
        public void ComparisonOfAmounts(Money summ1, Money summ2)
        {
            _createSumm1 = Convert.ToDouble(summ1.Ruble + "," + summ1.Kopeck);
            _createSumm2 = Convert.ToDouble(summ2.Ruble + "," + summ2.Kopeck);

            if (_createSumm1 > _createSumm2)
            {
                Console.WriteLine($"Первая сумма({_createSumm1}) больше второй ({_createSumm2}).\n");
            }
            else
            {
                Console.WriteLine($"Первая сумма({_createSumm1}) меньше второй ({_createSumm2}).\n");
            }
        }

        //вывод каждой суммы на консоль
        public void writeConsoleSum()
        {
            if (_needToWriteInConsole == true)
            {
                Console.WriteLine($"Сумма: {_ruble}" + "," + _kopeck + "\n");
            }          
        }
    }
}
