using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson_Git;
namespace UnitTestLesson_Git
{
    [TestClass]
    public class UnitTestCar
    {
        [TestMethod]
        public void TestMethodTravel_IsDirty_False()
        {
            #region Arrange

            Car rabbit = new Car();


            #endregion

            #region Action
            rabbit.Travel(100);


            #endregion
            #region Assert

            Assert.IsFalse(rabbit.look);

            #endregion
        }
    }
}
