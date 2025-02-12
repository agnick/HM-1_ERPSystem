using ERPSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ERPSystemTests
{
    /// <summary>
    /// Тесты для класса Thing.
    /// </summary>
    public class ThingTests
    {
        [Fact]
        public void ThingConstructor_WithValidParameters_ShouldCreateThing()
        {
            // Arrange.
            string expectedName = "Стол";
            int expectedNumber = 100;

            // Act.
            var thing = new Thing(expectedName, expectedNumber);

            // Assert.
            Assert.Equal(expectedName, thing.Name);
            Assert.Equal(expectedNumber, thing.Number);
        }

        [Fact]
        public void ThingConstructor_NullName_ShouldThrowArgumentNullException()
        {
            // Arrange.
            string name = null;
            int number = 100;

            // Act & Assert.
            Assert.Throws<ArgumentNullException>(() => new Thing(name, number));
        }

        [Fact]
        public void ThingConstructor_NegativeNumber_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange.
            string name = "Стол";
            int invalidNumber = -1;

            // Act & Assert.
            Assert.Throws<ArgumentOutOfRangeException>(() => new Thing(name, invalidNumber));
        }
    }
}
