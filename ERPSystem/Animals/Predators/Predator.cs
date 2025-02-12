using System;

namespace ERPSystem.Animals.Predators
{
    /// <summary>
    /// Класс для хищников.
    /// </summary>
    public class Predator : Animal
    {
        public Predator(string name, int food, int number) : base(name, food, number)
        {
        }
    }
}