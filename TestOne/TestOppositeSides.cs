using CubeOne;

namespace TestOne
{

    [TestClass]
    public class TestOppositeSides
    {
        // Check opposite sides.  The Intersection is empty.

        [TestMethod]
        public void Test_Up_Down()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.UpMove();
            c.DownMove();
            c.AntiUpMove();
            c.AntiDownMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Left_Right()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.LeftMove();
            c.RightMove();
            c.AntiLeftMove();
            c.AntiRightMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Front_Back()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.FrontMove();
            c.BackMove();
            c.AntiFrontMove();
            c.AntiBackMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

    }
}