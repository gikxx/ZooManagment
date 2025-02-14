using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Models
{
    // Класс для тигров, наследуется от класса Predator (хищники)
    public class Tiger : Predator
    {
        // Свойство для хранения количества полос на тигре
        public int StripeCount { get; set; }

        // Конструктор для инициализации тигра
        public Tiger(int inventoryNumber, double foodRequirement, bool isHealthy, int stripeCount)
            // Вызываем конструктор базового класса Predator для инициализации инвентарного номера, потребности в пище и состояния здоровья
            : base(inventoryNumber, foodRequirement, isHealthy)
        {
            StripeCount = stripeCount;  // Инициализация количества полос
        }
    }
}
