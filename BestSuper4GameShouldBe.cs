using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BestSuper4GameTestShouldBe
{
    [TestClass]
    public class BestSuper4GameShouldBe
    {
        // Quan el nom té més de 2 vocals
        [TestMethod]
        [DataRow(true, "Ababa")]
        [DataRow(true, "Ewewe")]
        [DataRow(true, "Inini")]
        public void CheckVowels_Multiple(bool expected, string name)
        {
            // Arrange
            bool vowelsValid = false;

            // Act
            BestSuper4Game.Program.Checkvowels(ref vowelsValid, ref name);

            // Assert
            Assert.AreEqual(expected, vowelsValid);
        }

        // Quan el nom té exactament dues vocals
        [TestMethod]
        [DataRow(true, "Aba")]
        [DataRow(true, "Ewe")]
        [DataRow(true, "Ini")]
        public void CheckVowels_Two(bool expected, string name)
        {
            // Arrange
            bool vowelsValid = false;

            // Act
            BestSuper4Game.Program.Checkvowels(ref vowelsValid, ref name);

            // Assert
            Assert.AreEqual(expected, vowelsValid);
        }

        // Quan el nom té menys de 2 vocals
        [TestMethod]
        [DataRow(false, "Ab")]
        [DataRow(false, "Ew")]
        [DataRow(false, "In")]
        public void CheckVowels_LessThanTwo(bool expected, string name)
        {
            // Arrange
            bool vowelsValid = false;

            // Act
            BestSuper4Game.Program.Checkvowels(ref vowelsValid, ref name);

            // Assert
            Assert.AreEqual(expected, vowelsValid);
        }

        // Quan el nom està buit
        [TestMethod]
        [DataRow(false, "")]
        public void CheckVowels_Empty(bool expected, string name)
        {
            // Arrange
            bool vowelsValid = false;

            // Act
            BestSuper4Game.Program.Checkvowels(ref vowelsValid, ref name);

            // Assert
            Assert.AreEqual(expected, vowelsValid);
        }

        // Quan el nom no conté vocals
        [TestMethod]
        [DataRow(false, "b")]
        [DataRow(false, "w")]
        [DataRow(false, "n")]
        public void CheckVowels_Zero(bool expected, string name)
        {
            // Arrange
            bool vowelsValid = false;

            // Act
            BestSuper4Game.Program.Checkvowels(ref vowelsValid, ref name);

            // Assert
            Assert.AreEqual(expected, vowelsValid);
        }
    }
}