using Microsoft.VisualStudio.TestTools.UnitTesting;
using LSPM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPM.Tests
{
    [TestClass()]
    public class LSPMPasswordTests
    {
        [TestMethod()]
        public void validateTest()
        {
            var x = LSPMPassword.GetSHA1( "102030405060" );
            Assert.AreEqual( "d8a6a8071d128a319699f1cc6c6477a1acb4a1a0", x );
        }
    }
}