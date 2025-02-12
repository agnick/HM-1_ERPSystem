using System;

namespace ERPSystem.Animals.HerboAnimals
{
    /// <summary>
    /// Класс для кроликов.
    /// </summary>
    public class Rabbit : Herbo
    {
        public Rabbit(string name, int food, int number, int kindnessLevel) : base(name, food, number, kindnessLevel)
        {
        }
    }
}