using Microsoft.VisualStudio.TestTools.UnitTesting;
using sustav_za_rezervacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace sustav_za_rezervacije.Tests
{
    [TestClass()]
    public class DataHandlerTests
    {
        private TestContext context;
        public TestContext Context { get => context; set => context = value; }

        [TestMethod()]
        public void UcitajPodatkeTest()
        {

            Assert.IsTrue(Directory.Exists(DataHandler.DataPath));       

        }
    }
}