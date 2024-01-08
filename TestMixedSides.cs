
using CubeOne;

namespace TestOne
{
    [TestClass]
    public class TestMixedSides
    {
        // Check Mixed Sides.  Double Inverse.  XYY'X' = 1.
        // True on Adjacent Sides and Opposite Sides.

        [TestMethod]
        public void Test_Front_Left_Inverse()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.FrontMove();
            c.LeftMove();
            c.AntiLeftMove();
            c.AntiFrontMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Front_Right_Inverse()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.FrontMove();
            c.RightMove();
            c.AntiRightMove();
            c.AntiFrontMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Front_Up_Inverse()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.FrontMove();
            c.UpMove();
            c.AntiUpMove();
            c.AntiFrontMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Front_Down_Inverse()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.FrontMove();
            c.DownMove();
            c.AntiDownMove();
            c.AntiFrontMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Front_Back_Inverse()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.FrontMove();
            c.BackMove();
            c.AntiBackMove();
            c.AntiFrontMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

    }
}
