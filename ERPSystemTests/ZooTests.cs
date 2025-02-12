using ERPSystem.Animals.HerboAnimals;
using ERPSystem.Animals.Predators;
using ERPSystem.Animals;
using ERPSystem.Interfaces;
using ERPSystem;
using ERPSystemTests.VetClinics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ERPSystemTests
{
    /// <summary>
    /// Тесты для класса Zoo.
    /// </summary>
    public class ZooTests
    {
        [Fact]
        public void AddAnimal_HealthyAnimal_ShouldAddAnimalToZoo()
        {
            // Arrange.
            IVetClinic fakeVet = new FakeVetClinicAlwaysHealthy();
            var zoo = new Zoo(fakeVet);
            var animal = new Animal("Лев", 10, 1);

            // Act.
            zoo.AddAnimal(animal);

            // Assert.
            Assert.Equal(1, zoo.GetAnimalCount());
            Assert.Contains(animal, zoo.GetAnimals());
        }

        [Fact]
        public void AddAnimal_UnhealthyAnimal_ShouldNotAddAnimalToZoo()
        {
            // Arrange.
            IVetClinic fakeVet = new FakeVetClinicAlwaysUnhealthy();
            var zoo = new Zoo(fakeVet);
            var animal = new Animal("Лев", 10, 1);

            // Act.
            zoo.AddAnimal(animal);

            // Assert.
            Assert.Equal(0, zoo.GetAnimalCount());
            Assert.DoesNotContain(animal, zoo.GetAnimals());
        }

        [Fact]
        public void AddThing_ShouldAddThingToInventoryItems()
        {
            // Arrange.
            IVetClinic fakeVet = new FakeVetClinicAlwaysHealthy();
            var zoo = new Zoo(fakeVet);
            var thing = new Thing("Стол", 100);

            // Act.
            zoo.AddThing(thing);

            // Assert.
            var inventory = zoo.GetInventoryItems();
            Assert.Contains(thing, inventory);
        }

        [Fact]
        public void GetTotalFoodConsumption_ShouldReturnCorrectSum()
        {
            // Arrange.
            IVetClinic fakeVet = new FakeVetClinicAlwaysHealthy();
            var zoo = new Zoo(fakeVet);
            var animal1 = new Animal("Лев", 10, 1);
            var animal2 = new Animal("Тигр", 15, 2);
            zoo.AddAnimal(animal1);
            zoo.AddAnimal(animal2);

            // Act.
            int totalFood = zoo.GetTotalFoodConsumption();

            // Assert.
            Assert.Equal(25, totalFood);
        }

        [Fact]
        public void GetAnimalsInContactZoo_ShouldReturnOnlyHerboWithHighKindness()
        {
            // Arrange.
            IVetClinic fakeVet = new FakeVetClinicAlwaysHealthy();
            var zoo = new Zoo(fakeVet);
            var herboHigh = new Herbo("Овечка1", 5, 1, 6);  // уровень доброты > 5.
            var herboLow = new Herbo("Овечка2", 5, 2, 4);   // уровень доброты <= 5.
            var predator = new Predator("Тигр", 10, 3);
            zoo.AddAnimal(herboHigh);
            zoo.AddAnimal(herboLow);
            zoo.AddAnimal(predator);

            // Act.
            var contactAnimals = zoo.GetAnimalsInContactZoo();

            // Assert.
            Assert.Single(contactAnimals);
            Assert.Contains(herboHigh, contactAnimals);
            Assert.DoesNotContain(herboLow, contactAnimals);
        }
    }
}
