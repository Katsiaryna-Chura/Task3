using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3_2
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void FillUserProfileTest()
        {
            FillUserProfileCommand command = new FillUserProfileCommand();
            Assert.IsTrue(command.SetUserData("John", 25));
        }
    }
  
}
