using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            User test = new User();
            test.UserName = "Newlin";
            test.Password = "123";
            Assert.IsTrue(test.Insert());
        }
    }
}