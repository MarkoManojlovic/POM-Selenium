using NUnit.Framework;
using PageObjectTest.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectTest.Helper
{
    public class Base
    {
        [SetUp]
        public static void BeforeScenario()
        {
            WebDriver.Initialization();

        }
        [TearDown]
        
        public static void AfterScenario()
        {
            WebDriver.Cleanup();
        }

      
       
    }
}
