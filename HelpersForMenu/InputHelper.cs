using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.HelpersForMenu
{
    // Статический класс для помощи с вводом данных
    public static class InputHelper
    {
        // Метод для считывания целого числа с ограничениями
        public static int ReadInt(string prompt, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            int value;
            while (true)
            {
                // Запрашиваем ввод от пользователя
                Console.Write(prompt);

                // Проверяем, что ввод является целым числом и находится в пределах заданных границ
                if (int.TryParse(Console.ReadLine(), out value) && value >= minValue && value <= maxValue)
                {
                    return value;  // Если ввод правильный, возвращаем значение
                }

                // Если ввод некорректный, показываем сообщение об ошибке
                Console.WriteLine($"Некорректный ввод. Введите число от {minValue} до {maxValue}.");
            }
        }

        // Метод для считывания числа с плавающей точкой (double)
        public static double ReadDouble(string prompt)
        {
            double value;
            while (true)
            {
                // Запрашиваем ввод от пользователя
                Console.Write(prompt);

                // Проверяем, что ввод является числом и положительным
                if (double.TryParse(Console.ReadLine(), out value) && value >= 0)
                {
                    return value;  // Если ввод правильный, возвращаем значение
                }

                // Если ввод некорректный, показываем сообщение об ошибке
                Console.WriteLine("Некорректный ввод. Введите положительное число.");
            }
        }

        // Метод для считывания логического значения (true/false)
        public static bool ReadBool(string prompt)
        {
            while (true)
            {
                // Запрашиваем ввод от пользователя
                Console.Write(prompt);
                string input = Console.ReadLine()?.ToLower();

                // Проверяем, что ввод является "true" или "false"
                if (input == "true" || input == "false")
                {
                    return bool.Parse(input);  // Возвращаем значение, преобразовав строку в bool
                }

                // Если ввод некорректный, показываем сообщение об ошибке
                Console.WriteLine("Некорректный ввод. Введите true или false.");
            }
        }

        // Метод для считывания строки
        public static string ReadString(string prompt)
        {
            Console.Write(prompt);  // Запрашиваем ввод от пользователя
            return Console.ReadLine();  // Возвращаем введенную строку
        }

    }
}
