using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ZooManagement.Models
{
    public class Herbivore : Animal
    {
        public int KindnessLevel { get; set; }

        public Herbivore(int inventoryNumber, double foodRequirement, bool isHealthy, int kindnessLevel)
            : base(inventoryNumber, foodRequirement, isHealthy)
        {
            KindnessLevel = kindnessLevel;
        }
    }
}