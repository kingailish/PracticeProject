using NUnit.Framework;
using PracticeProject.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PracticeProject.Steps
{
    [Binding]
    public class HomeMenuSteps
    {
        HomeMenuPage homeMenuPage = new HomeMenuPage();

        [Given(@"that I navigate to ""(.*)""")]

        public void GivenThatINavigateTo(string url)
        {
            homeMenuPage.NavigateToWebsite(url);
        }
        
        [When(@"I click on Home Menu")]
        public void WhenIClickOnHomeMenu()
        {
            homeMenuPage.ClickHomeMenuButton();
        }

        [Then(@"Prepmajor Home Menu Page is displayed")]
        public void ThenPrepmajorHomeMenuPageIsDisplayed()
        {
            Assert.IsTrue(homeMenuPage.PrepmajorHomeMenuPageIsDisplayed());
        }

        
      
    }
}
