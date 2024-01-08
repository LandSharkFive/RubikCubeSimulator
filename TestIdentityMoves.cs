using CubeOne;

namespace TestOne
{
    [TestClass]
    public class TestIdentityMoves
    {
        [TestMethod]
        public void Test_Front_Four_Turns()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.FrontMove();
            c.FrontMove();
            c.FrontMove();
            c.FrontMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Back_Four_Turns()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.BackMove();
            c.BackMove();
            c.BackMove();
            c.BackMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Left_Four_Turns()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.LeftMove();
            c.LeftMove();
            c.LeftMove();
            c.LeftMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Right_Four_Turns()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.RightMove();
            c.RightMove();
            c.RightMove();
            c.RightMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Up_Four_Turns()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.UpMove();
            c.UpMove();
            c.UpMove();
            c.UpMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Down_Four_Turns()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.DownMove();
            c.DownMove();
            c.DownMove();
            c.DownMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Anti_Front()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.FrontMove();
            c.AntiFrontMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Anti_Back()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.BackMove();
            c.AntiBackMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Anti_Left()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.LeftMove();
            c.AntiLeftMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Anti_Right()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.RightMove();
            c.AntiRightMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Anti_Up()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.UpMove();
            c.AntiUpMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Anti_Down()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.DownMove();
            c.AntiDownMove();
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

    }
}