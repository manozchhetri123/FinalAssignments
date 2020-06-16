using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalAssignment;


namespace UnitTestProjectProgram
{
    [TestClass]
    public class RectangleTest
    {
        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;
        
        public RectangleTest()
        {

        }


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }



        
    }
}
