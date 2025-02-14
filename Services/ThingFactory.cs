using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.HelpersForMenu;
using ZooManagement.Models;

namespace ZooManagement.Services
{
    // Статический класс для создания различных типов вещей
    public static class ThingFactory
    {
        // Метод для создания вещи в зависимости от выбора пользователя
        public static Thing CreateThing(int inventoryNumber, string name)
        {
            Console.WriteLine("Выберите тип вещи:");
            Console.WriteLine("1 - Стол");
            Console.WriteLine("2 - Компьютер");
            Console.Write("Ваш выбор: ");

            // Чтение ввода пользователя для выбора типа вещи
            var type = Console.ReadKey().Key;
            Console.WriteLine();

            // Возвращаем объект соответствующего типа вещи на основе выбора пользователя
            return type switch
            {
                // Создание стола с дополнительным вводом количества ножек
                ConsoleKey.D1 => new Table(inventoryNumber, name, InputHelper.ReadInt("Введите количество ножек: ", 1)),

                // Создание компьютера с дополнительным вводом типа процессора
                ConsoleKey.D2 => new Computer(inventoryNumber, name, InputHelper.ReadString("Введите тип процессора: ")),

                // Возврат null, если был выбран неверный вариант
                _ => null
            };
        }
    }

}
