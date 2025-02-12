using System;

namespace ERPSystem.Interfaces
{
    /// <summary>
    /// Интерфейс для объектов, имеющих имя.
    /// </summary>
    public interface INameable
    {
        string Name { get; }
    }
}