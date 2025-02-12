using ERPSystem.Interfaces;
using System;

namespace ERPSystem
{
    /// <summary>
    /// Класс для инвентаря.
    /// </summary>
    public class Thing : IInventory, INameable
    {
        /// <summary>
        /// Название предмета.
        /// </summary>
        private string _name;
        public string Name
        {
            get => _name;
            private set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value), "Имя не может быть null.");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Номер предмета.
        /// </summary>
        private int _number;
        public int Number
        {
            get => _number;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Number должен быть неотрицательным.");
                }
                _number = value;
            }
        }

        public Thing(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}