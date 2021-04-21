using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class ProfileSteps
    {
        private ChromeDriver driver;
              
        [Given(@"User is using chrome browser")]
        public void GivenUserIsUsingChromeBrowser()
        {
            
        }
        
        [Given(@"User click Languages tab in profile page")]
        public void GivenUserClickLanguagesTabInProfilePage()
        {
            Profile languageObject = new Profile();
            languageObject.ClickLanguage();
        }
        
        [Given(@"User click Add New Language button")]
        public void GivenUserClickAddNewLanguageButton()
        {
            Profile languageObject = new Profile();
            languageObject.ClickAddbtn();
        }
        
        [Given(@"User is click on the Languages tab in profile page")]
        public void GivenUserIsClickOnTheLanguagesTabInProfilePage()
        {
            Profile languageObject = new Profile();
            languageObject.ClickLanguage();
        }
        
        [Given(@"User is click on Edit Language button")]
        public void GivenUserIsClickOnEditLanguageButton()
        {
            Profile languageObject = new Profile();
            languageObject.ClickEdit();
        }
        
        [Given(@"User click on the Skills tab in profile page")]
        public void GivenUserClickOnTheSkillsTabInProfilePage()
        {
            Profile SkillObject = new Profile();
            SkillObject.ClickSkill();
        }
        
        [Given(@"User clicks on Add New Skill button")]
        public void GivenUserClicksOnAddNewSkillButton()
        {
            Profile SkillObject = new Profile();
            SkillObject.ClickAddnewSkillBtn();
        }
        
        [Given(@"User click on Edit Skill button")]
        public void GivenUserClickOnEditSkillButton()
        {
            Profile SkillObject = new Profile();
            SkillObject.ClickEditSkill();
        }
        
        [Given(@"User click on the Education tab in profile page")]
        public void GivenUserClickOnTheEducationTabInProfilePage()
        {
            Profile EduObject = new Profile();
            EduObject.ClickEducationTab();
        }
        
        [Given(@"User clicks on the Add New Education button")]
        public void GivenUserClicksOnTheAddNewEducationButton()
        {
            Profile EduObject = new Profile();
            EduObject.ClickAddnewEdubtn();
        }
        
        [Given(@"User clicks on Edit Education button")]
        public void GivenUserClicksOnEditEducationButton()
        {
            Profile EduObject = new Profile();
            EduObject.ClickEditEdu();
        }
        
        [Given(@"user click on the Certificate tab in profile page")]
        public void GivenUserClickOnTheCertificateTabInProfilePage()
        {
            Profile CertificateObject = new Profile();
            CertificateObject.ClkcertiTab();
        }
        
        [Given(@"User click on the Add New Certificate button")]
        public void GivenUserClickOnTheAddNewCertificateButton()
        {
            Profile CertificateObject = new Profile();
            CertificateObject.ClkAddnewcertibtn();
        }
        
        [Given(@"User is click on the Certifications tab in profile page")]
        public void GivenUserIsClickOnTheCertificationsTabInProfilePage()
        {
            Profile CertificateObject = new Profile();
            CertificateObject.ClkcertiTab();
        }
        
        [Given(@"User is clicks on Edit Certificate button")]
        public void GivenUserIsClicksOnEditCertificateButton()
        {
            Profile CertificateObject = new Profile();
            CertificateObject.ClkEditCerti();
        }
        
        [Given(@"User click on the Certifications tab in profile page")]
        public void GivenUserClickOnTheCertificationsTabInProfilePage()
        {
            Profile CertificateObject = new Profile();
            CertificateObject.ClkcertiTab();
        }
        
        [When(@"Navigate to ""(.*)"" url")]
        public void WhenNavigateToUrl(string url)
        {
           // driver.Navigate().GoToUrl(url);
        }
        
        [When(@"Enter valid login credentials ""(.*)"" and ""(.*)""")]
        public void WhenEnterValidLoginCredentialsAnd(string username, string password)
        {
           
            
        }
        
        [When(@"add new language (.*) and (.*)")]
        public void WhenAddNewLanguageAnd(string Language, string LanguageLevel)
        {
            Profile languageObject = new Profile();
            languageObject.AddLang(Language,LanguageLevel);
        }
        
        [When(@"User update Language information (.*)")]
        public void WhenUserUpdateLanguageInformation(string LanguageLevel)
        {
            Profile languageObject = new Profile();
            languageObject.UpdateLang(LanguageLevel);
        }
        
        [When(@"User is click on the Delete Languages button")]
        public void WhenUserIsClickOnTheDeleteLanguagesButton()
        {
            Profile languageObject = new Profile();
            languageObject.ClickDelete();
        }
        
        [When(@"User add new skills (.*) and (.*)")]
        public void WhenUserAddNewSkillsAnd(string Skill, string Level)
        {
            Profile SkillObject = new Profile();
            SkillObject.AddSkills(Skill,Level);
        }
        
        [When(@"User update the Skills information (.*)")]
        public void WhenUserUpdateTheSkillsInformation(string Level)
        {
            Profile SkillObject = new Profile();
            SkillObject.UpdateSkills(Level);
        }
        
        [When(@"User click on Delete Skill button")]
        public void WhenUserClickOnDeleteSkillButton()
        {
            Profile SkillObject = new Profile();
            SkillObject.ClickDeleteEdu();
        }
        
        [When(@"User adds a new Education (.*) ,(.*),(.*),(.*) and (.*)")]
        public void WhenUserAddsANewEducationAnd(string collegename, string country, string Title, string degree, string yearofgraduation)
        {
            Profile EduObject = new Profile();
            EduObject.AddEducation(collegename,country,Title,degree,yearofgraduation);
        }
        
        [When(@"User updates the Education year (.*)")]
        public void WhenUserUpdatesTheEducationYear(string yearofgraduation)
        {
            Profile EduObject = new Profile();
            EduObject.UpdateEducation(yearofgraduation);
        }
        
        [When(@"User clicks on the Delete Education button")]
        public void WhenUserClicksOnTheDeleteEducationButton()
        {
            Profile EduObject = new Profile();
            EduObject.ClickDeleteEdu();
        }
        
        [When(@"User add new Certificate  (.*),(.*) and (.*)")]
        public void WhenUserAddNewCertificateAnd(string Certificate, string CertificateFrom, string Year)
        {
            Profile CertificateObject = new Profile();
            CertificateObject.AddCertification(Certificate, CertificateFrom, Year);
        }
        
        [When(@"Update Certifications year (.*)")]
        public void WhenUpdateCertificationsYear(string Year)
        {
            Profile CertificateObject = new Profile();
            CertificateObject.UpdateCertification(Year);
        }
        
        [When(@"User click on the Delete Certificate button")]
        public void WhenUserClickOnTheDeleteCertificateButton()
        {
            Profile CertificateObject = new Profile();
            CertificateObject.ClkDeleteCerti();
        }
        
        [Then(@"verify user is logged in")]
        public void ThenVerifyUserIsLoggedIn()
        {
            Thread.Sleep(5000);
            //var isnamepresent = driver.FindElement(By.XPath("//span[text()='shriya']"));
           // Assert.IsTrue(isnamepresent.Displayed, "the value for name is not present");
        }
        
        [Then(@"language should be added")]
        public void ThenLanguageShouldBeAdded()
        {
            
        }
        
        [Then(@"updated detail should be visible on the Languages page")]
        public void ThenUpdatedDetailShouldBeVisibleOnTheLanguagesPage()
        {
            
        }
        
        [Then(@"Languages should be deleted on the Languages page")]
        public void ThenLanguagesShouldBeDeletedOnTheLanguagesPage()
        {
            
        }
        
        [Then(@"The should be added to the Skills page")]
        public void ThenTheShouldBeAddedToTheSkillsPage()
        {
           
        }
        
        [Then(@"that updated details should be visible on the Skills page")]
        public void ThenThatUpdatedDetailsShouldBeVisibleOnTheSkillsPage()
        {
           
        }
        
        [Then(@"that Skills should not be visible on the Skills page")]
        public void ThenThatSkillsShouldNotBeVisibleOnTheSkillsPage()
        {
          
        }
        
        [Then(@"The Education should be added to the Education page")]
        public void ThenTheEducationShouldBeAddedToTheEducationPage()
        {
           
        }
        
        [Then(@"that updated details should be visible on the Education page")]
        public void ThenThatUpdatedDetailsShouldBeVisibleOnTheEducationPage()
        {
           
        }
        
        [Then(@"that Education should not be visible on the Education page")]
        public void ThenThatEducationShouldNotBeVisibleOnTheEducationPage()
        {
            
        }
        
        [Then(@"certificate details added to the Certifications page")]
        public void ThenCertificateDetailsAddedToTheCertificationsPage()
        {
       
        }
        
        [Then(@"updated detail should be visible on the Certifications page")]
        public void ThenUpdatedDetailShouldBeVisibleOnTheCertificationsPage()
        {
           
        }
        
        [Then(@"certificate should not be visible on the Certifications page")]
        public void ThenCertificateShouldNotBeVisibleOnTheCertificationsPage()
        {
           
        }
    }
}
