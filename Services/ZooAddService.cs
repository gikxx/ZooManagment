using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.HelpersForMenu;
using ZooManagement.Models;

namespace ZooManagement.Services
{
    // Сервис для добавления животных и вещей в зоопарк
    public class ZooAddService
    {
        // Зависимости для работы с зоопарком и проверки здоровья
        private readonly ZooService _zooService;
        private readonly VeterinaryService _veterinaryService;

        // Конструктор для инициализации сервисов
        public ZooAddService(ZooService zooService, VeterinaryService veterinaryService)
        {
            _zooService = zooService;
            _veterinaryService = veterinaryService;
        }

        // Метод для добавления нового животного
        public void AddAnimal()
        {
            Console.Clear();
            Console.WriteLine("Добавление нового животного:");

            // Чтение данных для нового животного
            int inventoryNumber = InputHelper.ReadInt("Введите инвентарный номер: ");
            double foodRequirement = InputHelper.ReadDouble("Введите количество еды (кг/день): ");
            bool isHealthy = InputHelper.ReadBool("Животное здорово? (true/false): ");

            // Создание животного через фабрику
            Animal animal = AnimalFactory.CreateAnimal(inventoryNumber, foodRequirement, isHealthy);
            if (animal == null)
            {
                Console.WriteLine("Неверный выбор животного.");
                return;
            }

            // Проверка здоровья животного и добавление в зоопарк
            if (_veterinaryService.CheckHealth(animal))
            {
                _zooService.AddAnimal(animal);
                Console.WriteLine("Животное добавлено в зоопарк.");
            }
            else
            {
                Console.WriteLine("Животное не здорово и не может быть добавлено.");
            }
        }

        // Метод для добавления новой вещи
        public void AddThing()
        {
            Console.Clear();
            Console.WriteLine("Добавление новой вещи:");

            // Чтение данных для новой вещи
            int inventoryNumber = InputHelper.ReadInt("Введите инвентарный номер: ");
            Console.Write("Введите название вещи: ");
            string name = Console.ReadLine();

            // Создание вещи через фабрику
            Thing thing = ThingFactory.CreateThing(inventoryNumber, name);
            if (thing == null)
            {
                Console.WriteLine("Неверный выбор вещи.");
                return;
            }

            // Добавление вещи в зоопарк
            _zooService.AddThing(thing);
        }
    }

}
