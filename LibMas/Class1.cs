using System;
using System.IO;

namespace Lib_2
{
    public static class LibMas
    {
        // ��������� ������ � ����
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

        // ��������� ������ �� �����
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

        // ��������� ������ ���������� ������ �������
        public static int[] FillArray(int size)
        {
            Random random = new Random();
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(-100, 101); // ��������� ����� �� -100 �� 100
            }
            return numbers;
        }

        // ������� ������
        public static void ClearArray(ref int[] numbers)
        {
            numbers = new int[0];
        }

        // ������� ������ �� �����
        public static void PrintArray(int[] numbers)
        {
            Console.WriteLine("������:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}