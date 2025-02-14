using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.Interfaces;

namespace ZooManagement.Models
{
    // Абстрактный класс для животных, реализующий интерфейс IAlive
    public abstract class Animal : IAlive
    {
        // Инвентарный номер животного
        public int InventoryNumber { get; set; }

        // Потребность в пище животного (в кг)
        public double FoodRequirement { get; set; }

        // Состояние здоровья животного (здорово или нет)
        public bool IsHealthy { get; set; }

        // Конструктор для инициализации основных свойств животного
        protected Animal(int inventoryNumber, double foodRequirement, bool isHealthy)
        {
            InventoryNumber = inventoryNumber; 
            FoodRequirement = foodRequirement;  
            IsHealthy = isHealthy;             
        }
    }
}
