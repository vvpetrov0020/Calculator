using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // обозначенм переменную класса
        Calculations number;

        // создаем триггер, чтобы текстблоки были заблокированны (нужно для предотвращения лишних нажатий)
        private bool ChekPressTextBlocks()
        {
            if (!tbPlus.IsEnabled)
                return false;

            if (!tbMinus.IsEnabled)
                return false;

            if (!tbMultiplication.IsEnabled)
                return false;

            if (!tbDivision.IsEnabled)
                return false;

            if (!tbDegree.IsEnabled)
                return false;

            if (!tbRoot.IsEnabled)
                return false;

            return true;
        }

        // создаем триггер на открытие текстблоков, для возможности нажатия
        private void OpenPressTextBlocks()
        {
            tbPlus.IsEnabled = true;
            tbMinus.IsEnabled = true;
            tbMultiplication.IsEnabled = true;
            tbDivision.IsEnabled = true;
            tbRoot.IsEnabled = true;
            tbDegree.IsEnabled = true;
        }

        // функция округления
        private void Rounding()
        {
            // проверяем индекс плавающей точки в числе, и если она на одну позицию после нуля, то удаляем 
            if (tbResult.Text[0] == '0' && (tbResult.Text.IndexOf(",") != 1))
                tbResult.Text = tbResult.Text.Remove(0, 1);

            // то же самое, но для отрицательного числа (индексы смещаются на единицу)
            if (tbResult.Text[0] == '-')
                if (tbResult.Text[1] == '0' && (tbResult.Text.IndexOf(",") != 2))
                    tbResult.Text = tbResult.Text.Remove(1, 1);
        }


        public MainWindow()
        {
            InitializeComponent();

            // создаем экземпляр класса
            number = new Calculations();



        }

        private void tbClear_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // ставим ноль в поле результата
            tbResult.Text = "0";
            // очищаем переменную класса для дальнейших вычислений
            number.ClearNum();
            // открываем текстблоки действия
            OpenPressTextBlocks();
        }

        private void tbDivision_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Проверяем, есди текстблоки открыты, то заносим число из блока резултата(нажатое число), в переменную, с которой будет работать класс
            if (ChekPressTextBlocks())
            {
                number.PutNum(Convert.ToDouble(tbResult.Text));

                tbDivision.IsEnabled = false;

                tbResult.Text = "0";
            }
        }

        private void tbMultiplication_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Проверяем, есди текстблоки открыты, то заносим число из блока резултата(нажатое число), в переменную, с которой будет работать класс
            if (ChekPressTextBlocks())
            {
                number.PutNum(Convert.ToDouble(tbResult.Text));

                tbMultiplication.IsEnabled = false;

                tbResult.Text = "0";
            }
        }

        private void tbSeven_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Добавляем нажатое число в блок результата и округляем для точночти вычислений
            tbResult.Text += "7";

            Rounding();

        }

        private void tbEight_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Добавляем нажатое число в блок результата и округляем для точночти вычислений
            tbResult.Text += "8";
            Rounding();
        }

        private void tbNine_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Добавляем нажатое число в блок результата и округляем для точночти вычислений
            tbResult.Text += "9";
            Rounding();
        }

        private void tbMinus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Проверяем, есди текстблоки открыты, то заносим число из блока резултата(нажатое число), в переменную, с которой будет работать класс
            if (ChekPressTextBlocks())
            {
                number.PutNum(Convert.ToDouble(tbResult.Text));

                tbMinus.IsEnabled = false;

                tbResult.Text = "0";
            }
        }

        private void tbFour_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Добавляем нажатое число в блок результата и округляем для точночти вычислений
            tbResult.Text += "4";
            Rounding();
        }

        private void tbFive_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Добавляем нажатое число в блок результата и округляем для точночти вычислений
            tbResult.Text += "5";
            Rounding();
        }

        private void tbSix_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Добавляем нажатое число в блок результата и округляем для точночти вычислений
            tbResult.Text += "6";
            Rounding();
        }

        private void tbPlus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Проверяем, есди текстблоки открыты, то заносим число из блока резултата(нажатое число), в переменную, с которой будет работать класс
            if (ChekPressTextBlocks())
            {
                number.PutNum(Convert.ToDouble(tbResult.Text));

                tbPlus.IsEnabled = false;

                tbResult.Text = "0";
            }
        }

        private void tbOne_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Добавляем нажатое число в блок результата и округляем для точночти вычислений
            tbResult.Text += "1";
            Rounding();
        }

        private void tbTwo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Добавляем нажатое число в блок результата и округляем для точночти вычислений
            tbResult.Text += "2";
            Rounding();
        }

        private void tbThree_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Добавляем нажатое число в блок результата и округляем для точночти вычислений
            tbResult.Text += "3";
            Rounding();
        }

        private void tbZero_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Добавляем нажатое число в блок результата и округляем для точночти вычислений
            tbResult.Text += "0";
            Rounding();
        }

        private void tbDot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Добавляем нажатую точку в блок результата
            if ((tbResult.Text.IndexOf(",") == -1) && (tbResult.Text.IndexOf("∞") == -1))
                tbResult.Text += ".";
        }

        private void tbEqual_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Проверяем, если текстблок неактивный, то он был нажат, и тогда вызываается функция этого действия из класса и результат заносится в блок результата
            if (!tbMinus.IsEnabled)
                tbResult.Text = number.Difference(Convert.ToDouble(tbResult.Text)).ToString();

            // Проверяем, если текстблок неактивный, то он был нажат, и тогда вызываается функция этого действия из класса и результат заносится в блок результата
            if (!tbPlus.IsEnabled)
                tbResult.Text = number.Sum(Convert.ToDouble(tbResult.Text)).ToString();

            // Проверяем, если текстблок неактивный, то он был нажат, и тогда вызываается функция этого действия из класса и результат заносится в блок результата
            if (!tbMultiplication.IsEnabled)
                tbResult.Text = number.Multiplication(Convert.ToDouble(tbResult.Text)).ToString();

            // Проверяем, если текстблок неактивный, то он был нажат, и тогда вызываается функция этого действия из класса и результат заносится в блок результата
            if (!tbDivision.IsEnabled)
                tbResult.Text = number.Division(Convert.ToDouble(tbResult.Text)).ToString();

            // Проверяем, если текстблок неактивный, то он был нажат, и тогда вызываается функция этого действия из класса и результат заносится в блок результата
            if (!tbDegree.IsEnabled)
                tbResult.Text = number.Degree(Convert.ToDouble(tbResult.Text)).ToString();



            // Очищаем переменную класса и открываем все текстблоки
            number.ClearNum();
            OpenPressTextBlocks();
        }

        private void tbRoot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Проверяем, есди текстблоки открыты, то заносим число из блока резултата(нажатое число), в переменную, с которой будет работать класс
            if (ChekPressTextBlocks())
            {
                number.PutNum(Convert.ToDouble(tbResult.Text));

                tbRoot.IsEnabled = false;

                tbResult.Text = "0";
            }

            if (!tbRoot.IsEnabled)
                tbResult.Text = number.Root().ToString();
        }

        private void tbDegree_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Проверяем, есди текстблоки открыты, то заносим число из блока резултата(нажатое число), в переменную, с которой будет работать класс
            if (ChekPressTextBlocks())
            {
                number.PutNum(Convert.ToDouble(tbResult.Text));

                tbDegree.IsEnabled = false;

                tbResult.Text = "0";
            }
        }
    }
}
