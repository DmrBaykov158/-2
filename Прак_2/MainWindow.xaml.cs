using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Lib_2;
using Lib_1;



namespace Прак_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(InputCount.Text);
                int[] numbers = LibMas.FillArray(n);
                int sum = Lib_1.Zad2.FindSumGreaterThan5(numbers);
                
                ResultTextBlock.Text = $"Сумма чисел > 5: {sum}";

                foreach (int num in numbers)
                {


                    Result.Text = Result.Text + num.ToString()+" ";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод данных.", "Ошибка");
            }
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Байков Дмитрий\n" +
                "Номер работы: 2\n" +
                "Задание: Ввести n целых чисел. Найти сумму чисел > 5. Результат вывести на экран.", "О программе");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

    
    }
}
