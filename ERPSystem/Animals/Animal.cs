using ERPSystem.Interfaces;
using System;

namespace ERPSystem.Animals
{
    /// <summary>
    /// Базовый класс для животных.
    /// </summary>
    public class Animal : IAlive, IInventory, INameable
    {
        /// <summary>
        /// Имя животного.
        /// </summary>
        public string _name;
        public string Name
        {
            get => _name;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Поле name не может быть null.");
                }

                _name = value;
            }
        }

        /// <summary>
        /// Количество еды, потребляемое животным в сутки.
        /// </summary>
        private int _food;
        public int Food
        {
            get => _food;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Поле food должно быть больше 0.");
                }

                _food = value;
            }
        }

        /// <summary>
        /// Инвентаризационный номер животного.
        /// </summary>
        private int _number;
        public int Number
        {
            get => _number;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Полу number должно быть неотрицательным.");
                }

                _number = value;
            }
        }

        /// <summary>
        /// Конструктор для создания животного.
        /// </summary>
        public Animal(string name, int food, int number)
        {
            Name = name;
            Food = food;
            Number = number;
        }
    }
}