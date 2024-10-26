using System;
using System.IO;

namespace Lib_2
{
    public static class LibMas
    {
        // Сохраняет массив в файл
        public static void SaveArray(string filename, int[] numbers)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (int number in numbers)
                {
                    writer.WriteLine(number);
                }
            }
        }

        // Открывает массив из файла
        public static int[] OpenArray(string filename)
        {
            int[] numbers = new int[0];
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Array.Resize(ref numbers, numbers.Length + 1);
                    numbers[numbers.Length - 1] = int.Parse(line);
                }
            }
            return numbers;
        }

        // Заполняет массив случайными целыми числами
        public static int[] FillArray(int size)
        {
            Random random = new Random();
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(-100, 101); // Случайное число от -100 до 100
            }
            return numbers;
        }

        // Очищает массив
        public static void ClearArray(ref int[] numbers)
        {
            numbers = new int[0];
        }

        // Выводит массив на экран
        public static void PrintArray(int[] numbers)
        {
            Console.WriteLine("Массив:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}