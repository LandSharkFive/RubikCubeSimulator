using CubeOne;

namespace TestOne
{

    [TestClass]
    public class TestFourCycle
    {
        [TestMethod]
        public void Test_Front_Four_Cycle()
        {
            Cube c = new Cube();
            c.ShowPosition();
            string? s1 = c.GetState();
            c.Move("FFFF");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Back_Four_Cycle()
        {
            Cube c = new Cube();
            c.ShowPosition();
            string? s1 = c.GetState();
            c.Move("BBBB");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Left_Four_Cycle()
        {
            Cube c = new Cube();
            c.ShowPosition();
            string? s1 = c.GetState();
            c.Move("LLLL");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Right_Four_Cycle()
        {
            Cube c = new Cube();
            c.ShowPosition();
            string? s1 = c.GetState();
            c.Move("RRRR");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Up_Four_Cycle()
        {
            Cube c = new Cube();
            c.ShowPosition();
            string? s1 = c.GetState();
            c.Move("UUUU");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Down_Four_Cycle()
        {
            Cube c = new Cube();
            c.ShowPosition();
            string? s1 = c.GetState();
            c.Move("DDDD");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Anti_Front()
        {
            Cube c = new Cube();
            c.ShowPosition();
            string? s1 = c.GetState();
            c.Move("ffff");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Anti_Back()
        {
            Cube c = new Cube();
            c.ShowPosition();
            string? s1 = c.GetState();
            c.Move("bbbb");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Anti_Left()
        {
            Cube c = new Cube();
            c.ShowPosition();
            string? s1 = c.GetState();
            c.Move("llll");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Anti_Right()
        {
            Cube c = new Cube();
            c.ShowPosition();
            string? s1 = c.GetState();
            c.Move("rrrr");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Anti_Up()
        {
            Cube c = new Cube();
            c.ShowPosition();
            string? s1 = c.GetState();
            c.Move("uuuu");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Anti_Down()
        {
            Cube c = new Cube();
            c.ShowPosition();
            string? s1 = c.GetState();
            c.Move("dddd");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }


    }
}
