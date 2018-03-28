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
        public void CharacterAlignmentIsGood()
        {
            var character = new Character();            

            // Act
            character.Alignment = CharacterAlignment.Good;

            // Assert
            Assert.AreEqual(CharacterAlignment.Good, character.Alignment);
        }

        [TestMethod]
        public void CharacterHasDefaultArmor()
        {
            var character = new Character();

            // Act
            // No Act Necessary (Testing default value)

            // Assert
            Assert.AreEqual(10, character.ArmorClass);
        }

        [TestMethod]
        public void CharacterHasUpgradedArmor()
        {
            var character = new Character();

            // Act
            character.ArmorClass = 20;

            // Assert
            Assert.AreEqual(20, character.ArmorClass);
        }

        [TestMethod]
        public void CharacterHasDefaultHitPoints()
        {
            var character = new Character();

            // Act
            // No Act Necessary (Testing default value)

            // Assert
            Assert.AreEqual(5, character.HitPoints);
        }

        [TestMethod]
        public void CharacterHasUpgradedHitPoints()
        {
            var character = new Character();

            // Act
            character.HitPoints = 10;

            // Assert
            Assert.AreEqual(10, character.HitPoints);
        }
    }
}
