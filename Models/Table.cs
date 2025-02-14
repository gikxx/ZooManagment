using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Models
{
    // Класс для представления стола, наследуется от Thing (вещи)
    public class Table : Thing
    {
        // Свойство для хранения количества ножек стола
        public int LegCount { get; set; }

        // Конструктор для инициализации стола
        public Table(int inventoryNumber, string name, int legCount)
            // Вызываем конструктор базового класса Thing для инициализации инвентарного номера и имени
            : base(inventoryNumber, name)
        {
            LegCount = legCount; 
        }
    }
}
