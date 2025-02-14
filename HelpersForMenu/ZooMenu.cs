using ZooManagement.Services;  // Для сервисов зоопарка

// Класс для отображения меню и управления взаимодействием с пользователем
public class ZooMenu
{
    private readonly ZooAddService _addService;  // Сервис для добавления животных и вещей
    private readonly ZooService _zooService;    // Сервис для работы с животными и вещами в зоопарке

    // Конструктор для инициализации сервисов, передаваемых в меню
    public ZooMenu(ZooAddService commandService, ZooService zooService)
    {
        _addService = commandService;  // Инициализируем сервис для добавления
        _zooService = zooService;      // Инициализируем сервис для отображения данных о зоопарке
    }

    // Метод для запуска меню
    public void Run()
    {
        while (true)
        {
            // Очищаем экран перед отображением меню
            Console.Clear();

            // Отображаем список доступных опций в меню
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Добавить новое животное");
            Console.WriteLine("2. Показать общее количество еды");
            Console.WriteLine("3. Показать животных для контактного зоопарка");
            Console.WriteLine("4. Добавить новую вещь");
            Console.WriteLine("5. Показать все вещи");
            Console.WriteLine("6. Выйти");
            Console.Write("Выберите опцию (1-6): ");

            // Считываем нажатую клавишу
            var key = Console.ReadKey().Key;
            Console.WriteLine();

            // В зависимости от выбранной опции выполняем соответствующий метод
            switch (key)
            {
                case ConsoleKey.D1:  // Если выбрана опция 1, добавляем животное
                    _addService.AddAnimal();
                    break;
                case ConsoleKey.D2:  // Если выбрана опция 2, отображаем потребности в пище
                    _zooService.DisplayFoodRequirement();
                    break;
                case ConsoleKey.D3:  // Если выбрана опция 3, отображаем животных для контактного зоопарка
                    _zooService.DisplayContactZooAnimals();
                    break;
                case ConsoleKey.D4:  // Если выбрана опция 4, добавляем вещь
                    _addService.AddThing();
                    break;
                case ConsoleKey.D5:  // Если выбрана опция 5, отображаем все вещи
                    _zooService.DisplayThings();
                    break;
                case ConsoleKey.D6:  // Если выбрана опция 6, выходим из меню
                    return;
                default:  // Если введен неверный выбор
                    Console.WriteLine("Неверный выбор.");
                    break;
            }

            // После выполнения операции просим пользователя нажать любую клавишу для продолжения
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
