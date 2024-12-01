using LlibreriaEx4_T2PR2;

namespace TestEx4_T2PR2
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        public void TestMehodAreaRectangleOne()
        {
            //Arrange
            double width = 30;
            double height = 45.5;
            double result;
            double expectedResult = width * height;
            //Act
            result = Calculator.RectangleArea(width, height);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMehodAreaRectangleTwo()
        {
            //Arrange
            double width = 0;
            double height = 5.5;
            double result;
            double expectedResult = width * height;
            //Act
            result = Calculator.RectangleArea(width, height);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMehodCircumferenceOne()
        {
            //Arrange
            double radius = 3;
            double result;
            double expectedResult = 2 * Math.PI * radius;
            //Act
            result = Calculator.CircleCircumference(radius);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMehodCircumferenceTwo()
        {
            //Arrange
            double radius = 0;
            double result;
            double expectedResult = 2 * Math.PI * radius;
            //Act
            result = Calculator.CircleCircumference(radius);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}