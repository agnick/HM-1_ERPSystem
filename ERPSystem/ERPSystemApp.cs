using ERPSystem.Animals.HerboAnimals;
using ERPSystem.Animals.Predators;
using ERPSystem.Interfaces;
using ERPSystem.Things.SomeThings;
using System;

namespace ERPSystem
{
    public class ERPSystemApp
    {
        private readonly Zoo _zoo;

        public ERPSystemApp(Zoo zoo)
        {
            _zoo = zoo;
        }

        public void Run()
        {
            // Пробуем добавить несколько животных.
            try
            {
                var monkey = new Monkey("Мартышка", 5, 1, 8);
                var rabbit = new Rabbit("Кролик", 2, 2, 6);
                var tiger = new Tiger("Тигр", 10, 3);
                var wolf = new Wolf("Волк", 8, 4);
                var herbo = new Herbo("Овечка", 3, 5, 4);

                _zoo.AddAnimal(monkey);
                _zoo.AddAnimal(rabbit);
                _zoo.AddAnimal(tiger);
                _zoo.AddAnimal(wolf);
                _zoo.AddAnimal(herbo);
            } catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при добавлении животных: {ex.Message}");
            }

            // Добавляем несколько вещей.
            try
            {
                var table = new Table("Стол", 100);
                var computer = new Computer("Компьютер", 101);
                var otherThing = new Thing("Какая-то вещь", 777);

                _zoo.AddThing(table);
                _zoo.AddThing(computer);
                _zoo.AddThing(otherThing);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Ошибка при добавлении вещей: {ex.Message}");
            }

            // Формируем отчёты.
            Console.WriteLine("\nОтчет о зоопарке:");
            Console.WriteLine($"Общее количество животных: {_zoo.GetAnimalCount()}");
            Console.WriteLine($"Общее количество килограммов еды: {_zoo.GetTotalFoodConsumption()}");

            Console.WriteLine("\nЖивотные, подходящие для контактного зоопарка:");
            foreach (var animal in _zoo.GetAnimalsInContactZoo())
            {
                Console.WriteLine($"Имя: {animal.Name}, Уровень доброты: {animal.KindnessLevel}, Номер: {animal.Number}");
            }

            Console.WriteLine("\nВсе вещи и животные, находящиеся на балансе зоопарка:");
            foreach (var item in _zoo.GetInventoryItems())
            {
                string itemName = (item is INameable nameable) ? nameable.Name : "Без названия";
                string foodInfo = (item is IAlive alive) ? $", Потребляет еды в сутки: {alive.Food} кг" : "";

                Console.WriteLine($"Наименование: {itemName}, Номер: {item.Number}{foodInfo}");
            }
        }
    }
}