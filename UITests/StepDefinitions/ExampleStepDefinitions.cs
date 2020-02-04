using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace UITests.StepDefinitions
{
    [Binding]
    public sealed class ExampleStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;

        public ExampleStepDefinitions(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I print ""(.*)"" in console")]
        public void GivenIPrintInConsole(string message)
        {
            Console.WriteLine("Printing in console {0}", message);
        }

    }
}
