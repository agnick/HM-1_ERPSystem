using ERPSystem.Animals.HerboAnimals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ERPSystemTests
{
    /// <summary>
    /// Тесты для класса Herbo.
    /// </summary>
    public class HerboTests
    {
        [Fact]
        public void HerboConstructor_WithValidParameters_ShouldCreateHerbo()
        {
            // Arrange.
            string expectedName = "Овечка";
            int expectedFood = 5;
            int expectedNumber = 2;
            int expectedKindness = 8;

            // Act.
            var herbo = new Herbo(expectedName, expectedFood, expectedNumber, expectedKindness);

            // Assert.
            Assert.Equal(expectedName, herbo.Name);
            Assert.Equal(expectedFood, herbo.Food);
            Assert.Equal(expectedNumber, herbo.Number);
            Assert.Equal(expectedKindness, herbo.KindnessLevel);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(11)]
        public void HerboConstructor_InvalidKindnessLevel_ShouldThrowArgumentOutOfRangeException(int invalidKindness)
        {
            // Arrange.
            string name = "Овечка";
            int food = 5;
            int number = 2;

            // Act & Assert.
            Assert.Throws<ArgumentOutOfRangeException>(() => new Herbo(name, food, number, invalidKindness));
        }
    }
}
