using System.Reflection;
using EverCraft.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EverCraft.Tests
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void CharacterHasName()
        {
            // Arrange
            var character = new Character();
            var name = "Edward";

            // Act
            character.Name = name;

            // Assert
            Assert.AreEqual(name, character.Name);
        }


        [TestMethod]
        public void CharacterIsEvilFail()
        {
            var character = new Character();            

            // Act
            character.Alignment = CharacterAlignment.Good;

            // Assert
            Assert.AreEqual(CharacterAlignment.Good, character.Alignment);
        }

    }
}
