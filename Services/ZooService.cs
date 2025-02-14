using System.Collections.Generic;
using System.Linq;
using ZooManagement.Interfaces;
using ZooManagement.Models;

namespace ZooManagement.Services
{
    // Сервис для управления зоопарком
    public class ZooService
    {
        // Списки животных и вещей в зоопарке
        private List<Animal> _animals = new List<Animal>();
        private List<Thing> _things = new List<Thing>();

        // Добавление нового животного в зоопарк
        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        // Отображение общей потребности в пище для всех животных
        public void DisplayFoodRequirement()
        {
            // Суммируем потребности в пище всех животных
            double totalFood = _animals.Sum(animal => animal.FoodRequirement);
            Console.WriteLine($"Total food requirement: {totalFood} kg per day.");
        }

        // Отображение животных, которые могут находиться в контактном зоопарке
        public void DisplayContactZooAnimals()
        {
            // Отбираем травоядных с уровнем доброты больше 5
            var contactAnimals = _animals.OfType<Herbivore>().Where(h => h.KindnessLevel > 5);
            foreach (var animal in contactAnimals)
            {
                // Выводим ID животных, которые могут быть в контактном зоопарке
                Console.WriteLine($"Animal {animal.InventoryNumber} can be in the contact zoo.");
            }
        }

        // Отображение инвентаря: список животных и вещей
        public void DisplayInventory()
        {
            Console.WriteLine("Animals:");
            // Выводим информацию о каждом животном
            foreach (var animal in _animals)
            {
                Console.WriteLine($"- {animal.GetType().Name} (ID: {animal.InventoryNumber})");
            }

            Console.WriteLine("Things:");
            // Выводим информацию о каждой вещи
            foreach (var thing in _things)
            {
                Console.WriteLine($"- {thing.Name} (ID: {thing.InventoryNumber})");
            }
        }

        // Методы для работы с вещами

        // Добавление новой вещи в зоопарк
        public void AddThing(Thing thing)
        {
            _things.Add(thing);
            Console.WriteLine($"Вещь {thing.Name} добавлена в зоопарк.");
        }

        // Отображение всех вещей в зоопарке
        public void DisplayThings()
        {
            Console.WriteLine("Вещи в зоопарке:");
            // Для каждой вещи отображаем информацию
            foreach (var thing in _things)
            {
                Console.WriteLine($"- {thing.Name} (ID: {thing.InventoryNumber})");
            }
        }
    }
}
