using Microsoft.VisualStudio.TestTools.UnitTesting;
using sustav_za_rezervacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sustav_za_rezervacije.Tests
{
    [TestClass()]
    public class DataHandlerTests
    {
        [TestMethod()]
        public void DataHandlerTest()
        {
            Assert.IsTrue(Directory.Exists(DataHandler.DataPath));
        }
    }
}