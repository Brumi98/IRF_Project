using IRF_beadandó.Forms;
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
            Form_User fu = new Form_User(true);

            var actualResult = fu.Jelszoellenorzes(jelszo);

            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
