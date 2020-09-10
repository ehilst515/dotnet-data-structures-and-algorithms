using System;
using System.Text;
using Xunit;
using DataStructures.StacksAndQueues;

namespace DataStructures.Tests
{
    public class AnimalTests
    {
        [Fact]
        public void Shelter_starts_empty()
        {
            // Arrange
            AnimalShelter shelter = new AnimalShelter();

            // Act
            bool result = shelter.ShelterIsEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Shelter_can_add_animals()
        {
            // Arrange
            AnimalShelter shelter = new AnimalShelter();

            // Act
            shelter.AnimalEnqueue(Animal.Type.Dog);
            bool result = shelter.ShelterIsEmpty();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Dequeue_returns_dog()
        {
            // Arrange
            AnimalShelter shelter = new AnimalShelter();
            shelter.AnimalEnqueue(Animal.Type.Bird);
            shelter.AnimalEnqueue(Animal.Type.Dog);
            shelter.AnimalEnqueue(Animal.Type.Cat);

            // Act
            Animal.Type? result = shelter.AnimalDequeue(Animal.Type.Dog);

            // Assert
            Assert.Equal(Animal.Type.Dog, result);
        }

        [Fact]
        public void Dequeue_returns_dog_or_cat_or_null()
        {
            // Arrange
            AnimalShelter shelter = new AnimalShelter();
            shelter.AnimalEnqueue(Animal.Type.Bird);
            shelter.AnimalEnqueue(Animal.Type.Dog);
            shelter.AnimalEnqueue(Animal.Type.Cat);

            // Act
            Animal.Type? result = shelter.AnimalDequeue(Animal.Type.Bird);

            // Assert
            Assert.Null(result); 
        }

    }
}
