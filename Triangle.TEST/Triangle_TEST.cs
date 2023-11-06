using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Principal;
using WindowsFormsApp1;

namespace Triangle.TEST
{
    [TestClass]
    public class Triangle_TEST
    {
        [TestMethod]
        public void Triangle_ValidAB_C()
        {
            // Arrange
            int a = 3;
            int b = 4;
            double c_rez = 5;
            var tr = new WindowsFormsApp1.Triangle(a, b);
            // Act
            var c = tr.C();
            // Assert
            Assert.AreEqual(c_rez, c);

        }
        [TestMethod]
        public void Triangle_ValidAB_S()
        {
            // Arrange
            int a = 3;
            int b = 4;
            double s_rez = 6;
            var tr = new WindowsFormsApp1.Triangle(a, b);
            // Act
            var s = tr.S();
            // Assert
            Assert.AreEqual(s_rez, s);

        }
        [TestMethod]
        public void Triangle_NotValidA()
        {
            // Arrange
            int a = -3;
            int b = 4;
            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(()
                => new WindowsFormsApp1.Triangle(a, b));
        }
        [TestMethod]
        public void Triangle_NotValidB()
        {
            // Arrange
            int a = 3;
            int b = -4;
            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() 
                => new WindowsFormsApp1.Triangle(a, b));
        }
    
    [TestMethod]
    public void Triangle_NotValidAandB()
    {
        // Arrange
        int a = -3;
        int b = -4;
        // Act and assert
        Assert.ThrowsException<System.ArgumentOutOfRangeException>(() 
            => new WindowsFormsApp1.Triangle(a, b));
    }
        [TestMethod]
        public void Triangle_ValidAB_P_Returned7()
        {
            // Arrange
            int a = 3;
            int b = 4;
            double p_rez = 7;
            var tr = new WindowsFormsApp1.Triangle(a, b);
            // Act
            var p = tr.P();
            // Assert
            Assert.AreEqual(p_rez, p);

        }
    }
}
