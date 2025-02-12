using System;

namespace ERPSystem.Interfaces
{
    /// <summary>
    /// Интерфейс для инвентаризируемых объектов, содержит уникальный номер.
    /// </summary>
    public interface IInventory
    {
        int Number { get; }
    }
}