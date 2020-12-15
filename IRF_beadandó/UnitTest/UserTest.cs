using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class UserTest
    {
        [
            Test,
            TestCase("<nagyo2>", false),
            TestCase("Hoe3", true),
            TestCase(";21da", false)
        ]
        public void TestValidateJelszo(string jelszo,bool expectedResult)
        {
            IRF_beadandó.Form_User fu = new IRF_beadandó.Form_User();

            var actualResult = fu.Jelszoellenorzes(jelszo);

            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
