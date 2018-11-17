using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson_Git;
namespace UnitTestLesson_Git
{
    [TestClass]
    public class UnitTestCar
    {
        [TestMethod]
        public void TestMethodTravel_IsDirty_True()
        {
            #region Arrange
            Car rabbit = new Car();
            #endregion

            #region Action
            rabbit.Travel(100);
            
            #endregion
            #region Assert
            Assert.IsTrue(rabbit.look);
            #endregion
        }
        [TestMethod]
        public void TestTravel_IsWorking_True()
        {
            #region Arrange

            Car rabbit = new Car();

            #endregion

            #region Action
            rabbit.Travel(100);
            #endregion

            #region Assert
            Assert.IsTrue(rabbit.StateEngine);
            #endregion
            
        }
        [TestMethod]
        public void TestTravel_IsWorking_1000_False()
        {
            #region Arrange
            Car rabbit = new Car();
            #endregion
            #region Action
            rabbit.Travel(1);
            rabbit.Travel(999);
            #endregion
            #region Assert
            Assert.IsFalse(rabbit.StateEngine);
            #endregion
        }
        [TestMethod]
        public void TestTravel_IsWorking_2000_false()
        {
            #region Arrange
            Car rabbit2 = new Car();
            #endregion
            #region Action
            rabbit2.Travel(2000);

            #endregion
            #region Assert
            Assert.IsFalse(rabbit2.StateEngine);
            #endregion
        }
        [TestMethod]
        public void TestTravel_IsWorking_5000_IsFalse()
        {
            #region Arrange
            Car rabbit = new Car();
            #endregion
            #region Action
            rabbit.Travel(5000);
            #endregion
            #region Assert
            Assert.IsFalse(rabbit.StateEngine);

            #endregion
        }

        [TestMethod]
        [ExpectedException(typeof(BrokenCarException))]
        public void TestTravel_5000_5000_BrokenCarExeption()
        {
            #region Arrange
            Car rabbit = new Car();
            #endregion
            #region Action
            rabbit.Travel(5000);
            rabbit.Travel(5000);
            #endregion
            
            #region Assert
            Assert.IsFalse(rabbit.StateEngine);
            #endregion
        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestTravel_minus_100_Argument()
        {
            #region Arrange
            Car rabbit = new Car();
            #endregion
            #region Action
            rabbit.Travel(-100);
            #endregion
            #region Assert
            
            #endregion
        }

        [TestMethod]
        public void TestTravel_100_Mealage_100()
        {
            #region Arrange
            Car rabbit = new Car();
            
            #endregion
            #region Action
           rabbit.Travel(100);
            #endregion

            #region Assert
            Assert.AreEqual(rabbit.Mileage, 100);
            #endregion
        }

    }
}
