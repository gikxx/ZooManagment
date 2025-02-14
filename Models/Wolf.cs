using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Models
{
    // Класс для волков, наследуется от класса Predator (хищники)
    public class Wolf : Predator
    {
        // Свойство для хранения размера стаи, к которой принадлежит волк
        public int PackSize { get; set; }

        // Конструктор для инициализации волка
        public Wolf(int inventoryNumber, double foodRequirement, bool isHealthy, int packSize)
            // Вызываем конструктор базового класса Predator для инициализации инвентарного номера, потребности в пище и состояния здоровья
            : base(inventoryNumber, foodRequirement, isHealthy)
        {
            PackSize = packSize;  // Инициализация размера стаи
        }
    }
}
