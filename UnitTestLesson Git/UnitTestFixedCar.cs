using System;
using System.Collections.Generic;
using System.Text;
using Lesson_Git;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLesson_Git
{
    [TestClass]
    public class UnitTestFixedCar
    {
        [TestMethod]
        public void Test_Fix_StateEngine_true()
        {
            #region Arrange
            Car rabbit = new Car();
            rabbit.StateEngine = false;
            #endregion
            #region Action
            FixedCar.Fix(rabbit);
            #endregion
            #region Assert
            Assert.IsTrue(rabbit.StateEngine);
            #endregion
        }
        [TestMethod]
        public void Test_GetBill_120()
        {
            #region Arrange
            int Expected;
            Car rabbit = new Car();
            rabbit.Travel(1000);

            #endregion
            #region Action
            Expected=FixedCar.GetBill(rabbit);

            #endregion
            #region Assert

            Assert.AreEqual(Expected, 120);
            #endregion
        }
    }
}
