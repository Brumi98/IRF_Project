using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using IRF_beadandó.Entities;
using IRF_beadandó.Forms;


namespace UnitTest
{
    class UserTestFixture
    {

        [
            Test,
            TestCase("@Ira92", false),
            TestCase("Mariska02", true),
            TestCase("<jozsika>", false)
        ]


        public void TestValidateJelszo(string jelszo, bool exptedResult)
        {
            
            IRF_beadandó.Form_User fu = new IRF_beadandó.Form_User();

            var actualResult = fu.ValidateJelszo(jelszo);

            Assert.AreEqual(exptedResult, actualResult);


        }
    }
}
