using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Models
{
    // Класс для кроликов, наследуется от Herbivore (травоядные)
    public class Rabbit : Herbivore
    {
        // Свойство для хранения скорости кролика
        public int Speed { get; set; }

        // Конструктор для инициализации кролика
        public Rabbit(int inventoryNumber, double foodRequirement, bool isHealthy, int kindnessLevel, int speed)
            // Вызываем конструктор базового класса Herbivore для инициализации свойств животного
            : base(inventoryNumber, foodRequirement, isHealthy, kindnessLevel)
        {
            Speed = speed; // Инициализируем свойство скорости
        }
    }
}
