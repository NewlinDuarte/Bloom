using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;

namespace UnitTestProject1
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void Insert()
        {
            User test = new User();
            test.UserName = "Newlin";
            test.Password = "123";
            test.Insert();
        }
    }
}
