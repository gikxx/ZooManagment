using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.Interfaces;

namespace ZooManagement.Models
{
    public class Monkey : Animal
    {
        public int IntelligenceLevel { get; set; } // Уровень интеллекта

        public Monkey(int inventoryNumber, double foodRequirement, bool isHealthy, int intelligenceLevel)
            : base(inventoryNumber, foodRequirement, isHealthy)
        {
            IntelligenceLevel = intelligenceLevel;
        }
    }
}