using ERPSystem.Animals;
using ERPSystem.Interfaces;
using System;

namespace ERPSystem
{
    /// <summary>
    /// Ветеринарная клиника, проверяющая здоровье животных.
    /// </summary>
    public class VetClinic : IVetClinic
    {
        private static readonly Random random = new Random();

        /// <summary>
        /// Животное здорово с вероятностью 70% (эмуляция осмотра). 
        /// </summary>
        public bool IsHealthy(Animal animal)
        {
            return random.NextDouble() < 0.7;
        }
    }
}
