using System;
using System.Collections.Generic;
using System.Text;
using Demo;

namespace MyMsTest

{
    [TestClass]
    public class PersonTests
    {
        private Person person;
        [TestMethod]
        public void GetFullName_ReturnsCorrectFullName()
        {
            // Arrange
            var person = new Person("John", "Doe");

            // Act
            var fullName = person.GetFullName();

            // Assert
            Assert.AreEqual("John Doe", fullName);
        }

        [TestMethod]
        public void Constructor_SetsFirstNameAndLastName()
        {
            // Arrange & Act
            var person = new Person("Jane", "Smith");

            // Assert
            Assert.AreEqual("Jane", person.FirstName);
            Assert.AreEqual("Smith", person.LastName);
        }
    }
}
