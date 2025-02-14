using Microsoft.Extensions.DependencyInjection;  // Для внедрения зависимостей
using ZooManagement.Services;                
using ZooManagement.HelpersForMenu;          

class Program
{
    static void Main(string[] args)
    {
        // Настройка контейнера зависимостей для приложения
        var serviceProvider = new ServiceCollection()
            .AddSingleton<ZooService>()            // Регистрируем сервис ZooService для работы с животными и вещами
            .AddSingleton<VeterinaryService>()     // Регистрируем сервис VeterinaryService для проверки здоровья животных
            .AddSingleton<ZooAddService>()         // Регистрируем сервис ZooAddService для добавления животных и вещей в зоопарк
            .BuildServiceProvider();               // Строим провайдер сервисов

        // Получаем необходимые сервисы из контейнера зависимостей
        var addService = serviceProvider.GetRequiredService<ZooAddService>();
        var zooService = serviceProvider.GetRequiredService<ZooService>();

        // Создаем объект для меню с переданными сервисами
        var app = new ZooMenu(addService,zooService);

        // Запускаем приложение с меню
        app.Run();
    }
}
