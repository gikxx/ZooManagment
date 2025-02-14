using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Models
{
    // Класс для хищников, наследуется от класса Animal
    public class Predator : Animal
    {
        // Конструктор для инициализации хищника, вызывающий конструктор базового класса Animal
        public Predator(int inventoryNumber, double foodRequirement, bool isHealthy)
            : base(inventoryNumber, foodRequirement, isHealthy) // Передаем параметры в базовый класс
        {
        }
    }
}
