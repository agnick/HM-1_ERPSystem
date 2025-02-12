using System;

namespace ERPSystem.Animals.HerboAnimals
{
    /// <summary>
    /// Класс для травоядных животных.
    /// </summary>
    public class Herbo : Animal
    {
        /// <summary>
        /// Уровень доброты от 0 до 10.
        /// </summary>
        private int _kindnessLevel;
        public int KindnessLevel
        {
            get => _kindnessLevel;
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "KindnessLevel должен быть в диапазоне от 0 до 10 включительно.");
                }

                _kindnessLevel = value;
            }
        }

        public Herbo(string name, int food, int number, int kindnessLevel) : base(name, food, number)
        {
            KindnessLevel = kindnessLevel;
        }
    }
}