using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class ShareSkillsSteps
    {
        [Given(@"User using the Chrome browser")]
        public void GivenUserUsingTheChromeBrowser()
        {
            
        }
        
        [Given(@"User clicks on the Share Skill button")]
        public void GivenUserClicksOnTheShareSkillButton()
        {
            Thread.Sleep(5000);
            ShareSkills shareskillobject = new ShareSkills();
            shareskillobject.ShareSkillbtn();
        }
        
        [When(@"Useris  navigates to ""(.*)"" url")]
        public void WhenUserisNavigatesToUrl(string p0)
        {
            // driver.Navigate().GoToUrl(url);
        }

        [When(@"User is enter the valid login credentials ""(.*)"" and ""(.*)""")]
        public void WhenUserIsEnterTheValidLoginCredentialsAnd(string p0, string p1)
        {

        }
        
        [When(@"User enter the details (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*) and (.*)")]
        public void WhenUserEnterTheDetailsAnd(string Title, string Description, string Category, string Subcategory , string Tags, string ServiceType, string LocationType, string SkillTrade, string SkillExchange, string Credit, string WorkSamples, string Active)
        {
            ShareSkills shareskillobject = new ShareSkills();
            shareskillobject.ShareskillDetails(Title, Description, Category, Subcategory, Tags, ServiceType, LocationType, SkillTrade, SkillExchange,Credit, WorkSamples, Active);
        }

        [When(@"User entere Available Days")]
        public void WhenUserEntereAvailableDays()
        {
            ShareSkills shareskillobject = new ShareSkills();
            shareskillobject.Startdate();
        }
        
        [Then(@"User able to log in to the application")]
        public void ThenUserAbleToLogInToTheApplication()
        {

        }
        
        [Then(@"that Skills should be added to the Manage Listing page")]
        public void ThenThatSkillsShouldBeAddedToTheManageListingPage()
        {
            ShareSkills shareskillobject = new ShareSkills();
            shareskillobject.submit();
        }
    }
}
