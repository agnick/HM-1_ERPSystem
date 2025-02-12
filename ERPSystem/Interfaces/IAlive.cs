using System;

namespace ERPSystem.Interfaces
{
    /// <summary>
    /// Интерфейс для живых существ, учитывает потребление еды.
    /// </summary>
    public interface IAlive
    {
        int Food { get; set; }
    }
}