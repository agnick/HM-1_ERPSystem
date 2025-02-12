using System;

namespace ERPSystem.Animals.Predators
{
    /// <summary>
    /// Класс для волков.
    /// </summary>
    public class Wolf : Predator
    {
        public Wolf(string name, int food, int number) : base(name, food, number)
        {
        }
    }
}