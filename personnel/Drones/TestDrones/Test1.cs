using Drones;

namespace TestDrones
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Drone d = new Drone(12, 12, "20");
        }
    }
}
