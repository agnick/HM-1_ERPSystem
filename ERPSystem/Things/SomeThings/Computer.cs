using System;

namespace ERPSystem.Things.SomeThings
{
    /// <summary>
    /// Класс для компьютера, наследуется от Thing.
    /// </summary>
    public class Computer : Thing
    {
        public Computer(string name, int number) : base(name, number)
        {
        }
    }
}
