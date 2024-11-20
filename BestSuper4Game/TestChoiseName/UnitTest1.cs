using BestSuper4Game;
namespace TestChoiseName
{
    [TestClass]
    public class ChooseAvatarTests
    {
        [TestMethod]
        [DataRow(4)]
        [DataRow(3)]
        [DataRow(1)]
        public void ChooseAvatarValidInput()
        {
            //Arrange
            int validInput = 2;

            // Act
            bool result = Program.ChooseAvatar(validInput);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow(5)]
        [DataRow(0)]
        public void ChooseAvatarInvalidInput()
        {
            //Arrange
            int invalidInput = 6;

            //Act
            bool result = Program.ChooseAvatar(invalidInput);

            //Assert
            Assert.IsFalse(result);

        }
    }
}