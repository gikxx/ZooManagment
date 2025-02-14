using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.Interfaces;

namespace ZooManagement.Models
{
    // Класс для представления вещи, реализующий интерфейс IInventory
    public class Thing : IInventory
    {
        // Инвентарный номер вещи
        public int InventoryNumber { get; set; }

        // Название вещи
        public string Name { get; set; }

        // Конструктор для инициализации инвентарного номера и названия вещи
        public Thing(int inventoryNumber, string name)
        {
            InventoryNumber = inventoryNumber; 
            Name = name;                       
        }
    }
}
