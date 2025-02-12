using ERPSystem.Animals;
using ERPSystem.Animals.HerboAnimals;
using ERPSystem.Interfaces;
using System;

namespace ERPSystem
{
    /// <summary>
    /// Класс для управления зоопарком. 
    /// Отвечает за добавление животных и инвентаря, учёт потребляемой еды, 
    /// а также за формирование отчётов.
    /// </summary>
    public class Zoo
    {
        /// <summary>
        /// Экземпляр ветеринарной клиники, проверяющий здоровье животных перед добавлением.
        /// </summary>
        private readonly IVetClinic _vetClinic;

        /// <summary>
        /// Список всех животных, находящихся в зоопарке.
        /// </summary>
        private readonly List<Animal> _animals = new();

        /// <summary>
        /// Список всех инвентаризационных объектов, включая животных и вещи.
        /// </summary>
        private readonly List<IInventory> _inventoryItems = new();

        /// <summary>
        /// Конструктор класса зоопарка.
        /// </summary>
        /// <param name="vetClinic">Объект ветеринарной клиники для проверки здоровья животных.</param>
        public Zoo(IVetClinic vetClinic)
        {
            // Агрегация.
            _vetClinic = vetClinic;
        }

        /// <summary>
        /// Добавляет животное в зоопарк после проверки здоровья.
        /// </summary>
        /// <param name="animal">Животное, которое планируется добавить.</param>
        public void AddAnimal(Animal animal)
        {
            if (_vetClinic.IsHealthy(animal))
            {
                _animals.Add(animal);
                _inventoryItems.Add(animal);
                Console.WriteLine($"Животное '{animal.Name}' с номером {animal.Number} добавлено в зоопарк.");
            }
            else
            {
                Console.WriteLine($"Животное '{animal.Name}' с номером {animal.Number} не прошло проверку ветеринарной клиники.");
            }
        }

        /// <summary>
        /// Добавляет предмет инвентаря в зоопарк.
        /// </summary>
        /// <param name="thing">Объект инвентаря, который добавляется в зоопарк.</param>
        public void AddThing(IInventory thing)
        {
            _inventoryItems.Add(thing);
            string itemName = (thing is INameable nameable) ? nameable.Name : "Без названия";
            Console.WriteLine($"Вещь '{itemName}' с номером {thing.Number} добавлена в зоопарк.");
        }

        /// <summary>
        /// Возвращает количество животных, находящихся в зоопарке.
        /// </summary>
        /// <returns>Количество животных.</returns>
        public int GetAnimalCount() => _animals.Count;

        /// <summary>
        /// Рассчитывает общее количество еды (в кг), потребляемой всеми животными за сутки.
        /// </summary>
        /// <returns>Общее количество еды, потребляемой в сутки.</returns>
        public int GetTotalFoodConsumption() => _animals.Sum(a => a.Food);

        /// <summary>
        /// Возвращает список всех животных, находящихся в зоопарке.
        /// </summary>
        /// <returns>Коллекция животных.</returns>
        public IReadOnlyCollection<Animal> GetAnimals() => _animals.AsReadOnly();

        /// <summary>
        /// Формирует список животных, которые могут находиться в контактном зоопарке.
        /// Включает только травоядных с уровнем доброты выше 5.
        /// </summary>
        /// <returns>Коллекция животных, доступных для контактного зоопарка.</returns>
        public IReadOnlyCollection<Herbo> GetAnimalsInContactZoo() =>
            _animals.OfType<Herbo>()
            .Where(h => h.KindnessLevel > 5)
            .ToList()
            .AsReadOnly();

        /// <summary>
        /// Возвращает список всех объектов инвентаря, включая животных и вещи.
        /// </summary>
        /// <returns>Коллекция инвентаризационных объектов.</returns>
        public IReadOnlyCollection<IInventory> GetInventoryItems() => _inventoryItems.AsReadOnly();
    }
}