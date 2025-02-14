using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Models
{
    // Класс для представления компьютера, наследуется от Thing
    public class Computer : Thing
    {
        // Свойство, представляющее тип процессора
        public string ProcessorType { get; set; }

        // Конструктор для создания объекта Computer, принимающий инвентарный номер, имя и тип процессора
        public Computer(int inventoryNumber, string name, string processorType)
            : base(inventoryNumber, name) // Вызываем конструктор базового класса Thing
        {
            ProcessorType = processorType;
        }
    }
}
