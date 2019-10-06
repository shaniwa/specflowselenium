namespace specflowselenium.Bindings
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using TechTalk.SpecFlow;

    [Binding]
    class SpecflowBindings
    {
        private IWebDriver Driver;

        [When(@"I start the browser")]
        public void WhenIStartTheBrowser()
        {
            Driver = new FirefoxDriver();

        }

        [When(@"I navigate to '(.*)'")]
        public void WhenINavigateToHttpExample_Com(string Url)
        {
            Driver.Navigate().GoToUrl(Url);
        }
        [When(@"I click on the '(.*)'")]
        public void WhenIClickThe(string Label)
        {
            /*
            wait for elemnt to load and search for it in a cyclic manner.
            then clicking the link.
            presumably this is the correct function for clicking a searched link: 
            Driver.FindElement(By.LinkText(Label)).Click();
            */
        }

        [Then(@"a link with text '(.*)'")]
        public bool ThenLink(string Link)
        {
            /*
            find confirmation for links.
            wait here and check in a  cyclic manner for element.
            presumably this is the function to return if link exists:
            return Driver.FindElement(By.LinkText(Link)).size() > 0;
            */
        }

        [Then(@"the '(.*)' box must contain '(.*)' at index '(.*)'")]
        public bool ThenStringInIndex(string Box, string Label, int IDX)
        {
            /*
            find "Domain Names" box by string
            this could be an option - 
            Driver.FindElement(By.Xpath("//*[contains(., 'Domain names')]")); 
            taking the output of the previous function we should trace the elemnt's parent
            and from that - trace element "Root Zone Management" and verify its position in the index.
            Driver.FindElement(By.XPath("'FirstFuncOutputAsXPath'..div[. = 'Root Zone Management']]"));
            and here should be a validation for index '2'                                            
            */
        }


    }
}
