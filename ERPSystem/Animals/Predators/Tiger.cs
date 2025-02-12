using System;

namespace ERPSystem.Animals.Predators
{
    /// <summary>
    /// Класс для тигров.
    /// </summary>
    public class Tiger : Predator
    {
        public Tiger(string name, int food, int number) : base(name, food, number)
        {
        }
    }
}