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
            AnimalShelter<object> shelter = new AnimalShelter<object>();

            // Act
            bool result = shelter.ShelterIsEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Shelter_can_add_animals()
        {
            // Arrange
            AnimalShelter<object> shelter = new AnimalShelter<object>();

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
            AnimalShelter<object> shelter = new AnimalShelter<object>();
            shelter.AnimalEnqueue(Animal.Type.Dog);
            shelter.AnimalEnqueue(Animal.Type.Cat);

            // Act
            AnimalShelter<object>.Node result = shelter.AnimalDequeue(Animal.Type.Dog);

            // Assert
            Assert.Equal(Animal.Type.Dog, result.Value);
        }

        [Fact]
        public void Dequeue_returns_dog_or_cat_or_null()
        {
            // Arrange
            AnimalShelter<object> shelter = new AnimalShelter<object>();
            shelter.AnimalEnqueue(Animal.Type.Bird);
            shelter.AnimalEnqueue(Animal.Type.Dog);
            shelter.AnimalEnqueue(Animal.Type.Cat);

            // Act
            AnimalShelter<object>.Node result = shelter.AnimalDequeue(Animal.Type.Bird);

            // Assert
            Assert.Null(result);
        }



    }
}
