using ZooManagement.Models;

namespace ZooManagement.Services
{
    // Сервис для проверки здоровья животных
    public class VeterinaryService
    {
        // Метод для проверки состояния здоровья животного
        public bool CheckHealth(Animal animal)
        {
            // Возвращает состояние здоровья животного
            return animal.IsHealthy;
        }
    }
}
