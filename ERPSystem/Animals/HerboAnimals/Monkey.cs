using System;

namespace ERPSystem.Animals.HerboAnimals
{
    /// <summary>
    /// Класс для обезьян, наследуется от Herbo.
    /// </summary>
    public class Monkey : Herbo
    {
        public Monkey(string name, int food, int number, int kindnessLevel) : base(name, food, number, kindnessLevel)
        {
        }
    }
}