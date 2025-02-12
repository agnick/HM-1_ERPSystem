using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPSystem;
using ERPSystem.Animals;
using Xunit;

namespace ERPSystemTests
{
    /// <summary>
    /// Тесты для класса Animal.
    /// </summary>
    public class AnimalTests
    {
        [Fact]
        public void AnimalConstructor_WithValidParameters_ShouldCreateAnimal()
        {
            // Arrange.
            string expectedName = "Лев";
            int expectedFood = 10;
            int expectedNumber = 1;

            // Act.
            var animal = new Animal(expectedName, expectedFood, expectedNumber);

            // Assert.
            Assert.Equal(expectedName, animal.Name);
            Assert.Equal(expectedFood, animal.Food);
            Assert.Equal(expectedNumber, animal.Number);
        }

        [Fact]
        public void AnimalConstructor_NullName_ShouldThrowArgumentNullException()
        {
            // Arrange.
            string name = null;
            int food = 10;
            int number = 1;

            // Act & Assert.
            Assert.Throws<ArgumentNullException>(() => new Animal(name, food, number));
        }

        [Fact]
        public void AnimalConstructor_FoodLessOrEqualZero_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange.
            string name = "Лев";
            int invalidFood = 0;
            int number = 1;

            // Act & Assert.
            Assert.Throws<ArgumentOutOfRangeException>(() => new Animal(name, invalidFood, number));
        }

        [Fact]
        public void AnimalConstructor_NegativeNumber_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange.
            string name = "Лев";
            int food = 10;
            int invalidNumber = -1;

            // Act & Assert.
            Assert.Throws<ArgumentOutOfRangeException>(() => new Animal(name, food, invalidNumber));
        }
    }
}
