
using CubeOne;

namespace TestOne
{
    [TestClass]
    public class Test_Move
    {
        // Test Rotate Function.

        [TestMethod]
        public void Test_Rotate_Front_Left()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.Move("FLlf");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Rotate_Front_Right()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.Move("FRrf");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Rotate_Front_Up()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.Move("FUuf");
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Rotate_Front_Down()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.Move("FDdf"); ;
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        public void Test_Rotate_Front_Back()
        {
            Cube c = new Cube();
            string? s1 = c.GetState();
            c.Move("FBbf"); ;
            string? s2 = c.GetState();
            Assert.AreEqual(s1, s2);
        }

    }
}
