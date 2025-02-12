using ERPSystem.Animals;
using System;

namespace ERPSystem.Interfaces
{
    /// <summary>
    /// Интерфейс ветеринарной клиники, проверяет здоровье животных.
    /// </summary>
    public interface IVetClinic
    {
        bool IsHealthy(Animal animal);
    }
}