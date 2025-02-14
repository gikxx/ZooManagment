using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Interfaces
{
    // Интерфейс для объектов, которые могут иметь инвентарный номер
    public interface IInventory
    {
        // Свойство для хранения уникального инвентарного номера объекта
        int InventoryNumber { get; set; }
    }
}
