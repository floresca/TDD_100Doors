using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_Doors
{
    [TestFixture]
    public class DoorTests
    {
        [Test]
        public void OpenAClosedDoor()
        {
            string doorBeingSent = "#";
            string expectedDoor = "@";
            var DoorInitialize = new DoorActions();
            string results = DoorInitialize.MakeDoors(doorBeingSent);

            Assert.AreEqual(expectedDoor, results);
        }

        [Test]
        public void CloseAnOpenDoor()
        {
            string doorBeingSent = "@";
            string expectedDoor = "#";
            var DoorInitialize = new DoorActions();
            string results = DoorInitialize.MakeDoors(doorBeingSent);

            Assert.AreEqual(expectedDoor, results);
        }

        [Test]
        public void ChangeEveryOtherDoorStartingWithSecondAfterLoopingOnce()
        {
            string doorBeingSent = "##";
            string expectedDoor = "@#";
            var DoorInitialize = new DoorActions();
            string results = DoorInitialize.MakeDoors(doorBeingSent);

            Assert.AreEqual(expectedDoor, results);
        }

        [Test]
        public void ChangeEveryOtherEveryThirdEveryFourthDoorAfterLoopingOnce()
        {
            string doorBeingSent = "@@##";
            string expectedDoor = "#@#@";
            var DoorInitialize = new DoorActions();
            string results = DoorInitialize.MakeDoors(doorBeingSent);

            Assert.AreEqual(expectedDoor, results);
        }

        [Test]
        public void TwentyOneDoorSalute()
        {
            string doorBeingSent = "#####################";
            string expectedDoor = "@##@####@######@#####";
            var DoorInitialize = new DoorActions();
            string results = DoorInitialize.MakeDoors(doorBeingSent);

            Assert.AreEqual(expectedDoor, results);
        }
    }
}
