using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.HelpersForMenu;
using ZooManagement.Models;

namespace ZooManagement.Services
{
    // Статический класс для создания различных типов животных
    public static class AnimalFactory
    {
        // Метод для создания животного в зависимости от выбора пользователя
        public static Animal CreateAnimal(int inventoryNumber, double foodRequirement, bool isHealthy)
        {
            Console.WriteLine("Выберите тип животного:");
            Console.WriteLine("1 - Травоядное");
            Console.WriteLine("2 - Хищник");
            Console.WriteLine("3 - Обезьяна");
            Console.WriteLine("4 - Кролик");
            Console.WriteLine("5 - Тигр");
            Console.WriteLine("6 - Волк");
            Console.Write("Ваш выбор: ");

            // Чтение ввода пользователя для выбора типа животного
            var type = Console.ReadKey().Key;
            Console.WriteLine();

            // Возвращаем объект соответствующего типа животного на основе выбора пользователя
            return type switch
            {
                // Создание травоядного животного с дополнительным вводом уровня доброты
                ConsoleKey.D1 => new Herbivore(inventoryNumber, foodRequirement, isHealthy, InputHelper.ReadInt("Введите уровень доброты (1-10): ", 1, 10)),

                // Создание хищника
                ConsoleKey.D2 => new Predator(inventoryNumber, foodRequirement, isHealthy),

                // Создание обезьяны с дополнительным вводом уровня интеллекта
                ConsoleKey.D3 => new Monkey(inventoryNumber, foodRequirement, isHealthy, InputHelper.ReadInt("Введите уровень интеллекта (1-10): ", 1, 10)),

                // Создание кролика с дополнительным вводом уровня доброты и скорости
                ConsoleKey.D4 => new Rabbit(inventoryNumber, foodRequirement, isHealthy,
                            InputHelper.ReadInt("Введите уровень доброты (1-10): ", 1, 10),
                            InputHelper.ReadInt("Введите скорость кролика (км/ч): ", 0)),

                // Создание тигра с дополнительным вводом количества полос
                ConsoleKey.D5 => new Tiger(inventoryNumber, foodRequirement, isHealthy, InputHelper.ReadInt("Введите количество полос: ", 0, 1000)),

                // Создание волка с дополнительным вводом размера стаи
                ConsoleKey.D6 => new Wolf(inventoryNumber, foodRequirement, isHealthy, InputHelper.ReadInt("Введите размер стаи: ", 0, 500)),

                // Возврат null, если был выбран неверный вариант
                _ => null
            };
        }
    }

}
