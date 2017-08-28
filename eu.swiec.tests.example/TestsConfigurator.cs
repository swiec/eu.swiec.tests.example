using Ninject.Modules;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eu.swiec.tests.example
{
    class TestsConfigurator : NinjectModule
    {
        public override void Load()
        {
            Bind<IWebDriver>().To<RemoteWebDriver>()
                .InSingletonScope()
                .WithConstructorArgument("remoteAddress", new Uri("http://localhost:9515"))
                .WithConstructorArgument("options", new ChromeOptions());

            Bind<GooglePage>().ToSelf().InSingletonScope();
        }
    }
}
