using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GrabacionTareaDic5INS368
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodOpenAndUnlocked()
        {
            Door objeto = new Door(true, true);

            string key = "strongKey";

            objeto.Open();

            objeto.Unlock(key);

            bool result = objeto.OpenAndUnlocked(key);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethodClosedAndUnlocked()
        {
            Door objeto = new Door(true, true);

            string key = "strongKey";

            objeto.Close();

            objeto.Unlock(key);

            bool result = objeto.ClosedAndUnlocked(key);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethodOpenAndLocked()
        {
            Door objeto = new Door(true, true);

            string key = "Locked";

            objeto.Lock(key);

            bool result = objeto.OpenAndLocked(key);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void TestMethodClosedAndLocked()
        {
            Door objeto = new Door(true, true);

            string key = "Locked";

            objeto.Lock(key);

            bool result = objeto.ClosedAndLocked(key);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethodOpen()
        {
            Door objeto = new Door(true, false);
            objeto.Open();
            Assert.IsTrue(objeto.Open());
        }

        [TestMethod]
        public void TestMethodClose()
        {
            Door objeto = new Door(false, false);
            objeto.Open();
            Assert.IsTrue(objeto.Open());
        }

        [TestMethod]
        public void TestMethodLock()
        {
            Door objeto = new Door(false, true);
            objeto.Open();
            Assert.IsTrue(objeto.Open());
        }

        [TestMethod]
        public void TestMethodUnlock()
        {
            Door objeto = new Door(true, false);
            objeto.Open();
            Assert.IsTrue(objeto.Open());
        }
    }
}