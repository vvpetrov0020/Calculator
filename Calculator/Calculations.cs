using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculations
    {
        // создаем переменную где будет хранится первое введенное значение
        private double num = 0;

        // функция передающая значение с текстблока
        public void PutNum(double num)
        {
            this.num = num;
        }

        // функция очищающая переменную 
        public void ClearNum()
        {
            num = 0;
        }

        // функция умножения 
        public double Multiplication(double b)
        {
            return num * b;
        }

        // функция деления 
        public double Division(double b)
        {
            return num / b;
        }

        // функция сложения
        public double Sum(double b)
        {
            return num + b;
        }

        // функция вычитания
        public double Difference(double b)
        {
            return num - b;
        }

        // функция возведения в степень (степень передается вторым числом) 
        public double Degree(double b)
        {
            return Math.Pow(num, b);
        }

        // функция вычисления квадратного корня
        public double Root()
        {
            return Math.Sqrt(num);
        }


    }
}
