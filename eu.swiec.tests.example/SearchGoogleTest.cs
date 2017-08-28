using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eu.swiec.tests.example
{
    [TestClass]
    public class SearchGoogleTest
    {
        private GooglePage googlePage;

        [TestInitialize]
        public void SetupTest()
        {
            IKernel ikernel = new StandardKernel(new TestsConfigurator());
            googlePage = ikernel.Get<GooglePage>();
        }

        [TestMethod]
        public void SearchForSelenium()
        {
            googlePage.openPage().searchForQuery("selenium");
        }

    }
}
