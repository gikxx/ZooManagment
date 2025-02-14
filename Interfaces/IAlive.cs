using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.Interfaces;

namespace ZooManagement.Interfaces
{
    // Интерфейс для живых существ, которые могут быть частью инвентаря
    public interface IAlive : IInventory
    {
        // Свойство для указания потребности в пище (в кг) для живого существа
        double FoodRequirement { get; set; }

        // Свойство для указания состояния здоровья живого существа
        bool IsHealthy { get; set; }
    }
}
