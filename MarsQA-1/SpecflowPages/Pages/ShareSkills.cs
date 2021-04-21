using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class ShareSkills
    {
        public IWebDriver WebDriver { get; }
          public IWebElement shareSkillbtn => WebDriver.FindElement(By.XPath("//*[@class='nav-secondary']//a[text()='Share Skill']"));
        public IWebElement titletxtbox => WebDriver.FindElement(By.XPath("//*[@name='title']"));
        public IWebElement desctxtbox => WebDriver.FindElement(By.XPath("//*[@name='description']"));
        public IWebElement clkdrpdwn => WebDriver.FindElement(By.XPath("//*[@name='categoryId']"));
        public IWebElement clksubcdrpdwn => WebDriver.FindElement(By.XPath("//*[@name='subcategoryId']"));
        public IWebElement AddTag => WebDriver.FindElement(By.XPath("//*[@class='form-wrapper field  ']/div/div/div/input")); public IWebElement Servicetype => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[5]/div[2]/div[1]/div[1]/div/input"));

        //Locate Hourly Service Type
        public IWebElement HourlyServiceType => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[5]/div[2]/div[1]/div[1]/div/input"));
        //Locate One off Service Type
        public IWebElement OneOffServiceType => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[5]/div[2]/div[1]/div[2]/div/input"));

        public IWebElement Locationtype => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[6]/div[2]/div/div[2]/div/input"));
        //Locate On-Site Location Type
        public IWebElement LTonsite => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[6]/div[2]/div/div[1]/div/input"));
        //Locate Online Location Type
        public IWebElement LTonline => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[6]/div[2]/div/div[2]/div/input"));
        //Locate the availability form
        public IWebElement AvaibilityFrom => WebDriver.FindElement(By.XPath(""));

        //Locate startdate drop-down
        public IWebElement startdate => WebDriver.FindElement(By.XPath("//*[@name='startDate']"));

        //Locate End Date drop-down
        public IWebElement enddate => WebDriver.FindElement(By.XPath("//*[@name='endDate']"));

        //Locate a check box (Sunday Text box)
        public IWebElement checkbox => WebDriver.FindElement(By.XPath("//label[contains(text(),'Sun')]"));
        //Locate the start time drop-down
        public IWebElement starttime => WebDriver.FindElement(By.XPath("//*[@name='StartTime']"));

        //Locate the end time drop-down 
        public IWebElement endtime => WebDriver.FindElement(By.XPath("//*[@name='EndTime']"));


        public IWebElement Skilltrade => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[8]/div[2]/div/div[1]/div/input"));
        public IWebElement skillExch => WebDriver.FindElement(By.XPath("//*[@class='field']/div/div/div/div/input"));
        //Locate the Credit Type
        public IWebElement Credittype => WebDriver.FindElement(By.XPath("//label[contains(text(),'Credit')]"));
        //Locate the credit amount
        public IWebElement Creditamount => WebDriver.FindElement(By.XPath("//*[@name='charge']"));

        public IWebElement imageUpload => WebDriver.FindElement(By.XPath("//*[@class='huge plus circle icon padding-25']"));
        public IWebElement active => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[10]/div[2]/div/div[1]/div/input"));

        //Locate the Hidden button
        public IWebElement Hidden => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[10]/div[2]/div/div[2]/div/input"));

        public IWebElement clkSave => WebDriver.FindElement(By.XPath("//*[@class='ui teal button']"));

        //Locate the Cancel Button
        public IWebElement Cancelbtn => WebDriver.FindElement(By.XPath("//*[@value='Cancel']"));

        public void ShareSkillbtn() => shareSkillbtn.Click();
        public void Startdate() => startdate.Click();


        public void ShareskillDetails(string Title, string Description, string Category, string Subcategory, string Tags, string ServiceType, string LocationType, string SkillTrade, string SkillExchange, string Credit, string WorkSamples, string Active)
        {

            /* titletxtbox.SendKeys(Title);
             desctxtbox.SendKeys(Description);
             clkdrpdwn.SendKeys(Category);
             clksubcdrpdwn.SendKeys(Subcategory);
             AddTag.SendKeys(Tags);
             AddTag.SendKeys(Keys.Enter);
             Servicetype.SendKeys(ServiceType);
             Locationtype.SendKeys(LocationType);
             Skilltrade.SendKeys(SkillTrade);
             skillExch.SendKeys(SkillExchange);
             skillExch.SendKeys(Keys.Enter);
             imageUpload.Click();// need to done 
             Active.Click();

          */


            //public void EnterShareSkill()
            // {
            //Click on Title text box
            Thread.Sleep(3000);
            titletxtbox.Click();
            Thread.Sleep(1500);
            titletxtbox.SendKeys(Title);

            //Enter the Description
            desctxtbox.Click();
            desctxtbox.Clear();
            desctxtbox.SendKeys(Title);

            //Select a Category
            clkdrpdwn.Click();
            String categoryValue = Helpers.ExcelLibHelper.ReadData(2, "Category");
            IList<IWebElement> CategoriesDropDownList = clkdrpdwn.FindElements(By.XPath("//option"));
            int DpListCount = CategoriesDropDownList.Count;
            for (int i = 0; i < DpListCount; i++)
            {
                if (CategoriesDropDownList[i].Text == Category)
                {
                    CategoriesDropDownList[i].Click();
                }
            }

            //Select a Sub Category
            String subCategory = Helpers.ExcelLibHelper.ReadData(2, "SubCategory");
            IList<IWebElement> optionsSubCategory = clksubcdrpdwn.FindElements(By.TagName("option"));
            int optionsSubCategoryCount = optionsSubCategory.Count();
            for (int i = 0; i < optionsSubCategoryCount; i++)
            {
                if (optionsSubCategory[i].Text == Subcategory)
                {
                    optionsSubCategory[i].Click();
                }
            }
            //Add Tags
            
            AddTag.Click();
            AddTag.Clear();
            AddTag.SendKeys(Tags);
            AddTag.SendKeys(Keys.Enter);

            //Select Service Type
            String Servicetype = Helpers.ExcelLibHelper.ReadData(2, "ServiceType");
            if (Servicetype.Equals("Hourly basis service"))
            {
                HourlyServiceType.Click();
            }
            else if (Servicetype.Equals("One-off service"))
            {
                OneOffServiceType.Click();

            }

            //Select Location Type
            switch (LocationType)
            {
                case "On-site":
                    LTonsite.Click();
                    break;
                case "Online":
                    LTonline.Click();
                    break;
            }

            //Select Available StartDate
            IWebElement AvailableStartDateInput = startdate.FindElement(By.Name("startDate"));
            AvailableStartDateInput.SendKeys(Helpers.ExcelLibHelper.ReadData(2, "AvailableStartDate"));

            //Select Available End Date
            IWebElement AvailableEndDateInput = enddate.FindElement(By.Name("endDate"));
            AvailableEndDateInput.SendKeys(Helpers.ExcelLibHelper.ReadData(2, "AvailableEndDate"));

            String[] WeekDays = new String[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //Set the startTime
            IList<IWebElement> AvailableStartTimeInputs = starttime.FindElements(By.Name("StartTime"));
            String AvailableStartTimesValue = Helpers.ExcelLibHelper.ReadData(2, "AvailableStartTimes");
            IList<String> AvailableStartTimes = AvailableStartTimesValue.Split(',');
            for (int i = 0; i < AvailableStartTimes.Count(); i++)
            {
                IList<String> startTimeInfo = AvailableStartTimes[i].Split(':');
                String startTimeDay = startTimeInfo[0];
                String startTimeValue = startTimeInfo[1];
                int indexOfDay = Array.IndexOf(WeekDays, startTimeDay);
                AvailableStartTimeInputs[indexOfDay].SendKeys(startTimeValue);

                //Set the End Time
                IList<IWebElement> AvailableEndTimeInputs = starttime.FindElements(By.Name("EndTime"));
                String AvailableEndTimesValue = Helpers.ExcelLibHelper.ReadData(2, "AvailableStartTimes");
                IList<String> AvailableEndTimes = AvailableStartTimesValue.Split(',');
                for (int j = 0; j < AvailableStartTimes.Count(); j++)
                {
                    IList<String> endTimeInfo = AvailableStartTimes[i].Split(':');
                    String endTimeDay = endTimeInfo[0];
                    String endTimeValue = startTimeInfo[1];
                    int indexOfDay1 = Array.IndexOf(WeekDays, endTimeDay);
                    AvailableStartTimeInputs[indexOfDay1].SendKeys(startTimeValue);

                    //Select Skill Exchange Type
                    String SkillTradeType = Helpers.ExcelLibHelper.ReadData(2, "SkillTradeType");
                    if (SkillTradeType.Equals("Skill-exchange"))
                    {
                        skillExch.Click();
                    }
                    else if (SkillTradeType.Equals("Credit"))
                    {
                        Credittype.Click();
                        Creditamount.SendKeys(Helpers.ExcelLibHelper.ReadData(2, "CreditsAmount"));

                    }

                    //Add Skill Exchange tags
                    skillExch.SendKeys(Helpers.ExcelLibHelper.ReadData(2, "SkillExchangeTab"));
                    skillExch.SendKeys(Keys.Enter);
                   
                    imageUpload.Click();

                    //Select Active Status Button
                    String ActiveType = Helpers.ExcelLibHelper.ReadData(2, "ActiveType");
                    if (SkillTradeType.Equals("Active"))
                    {
                        active.Click();
                    }
                    else if (SkillTradeType.Equals("Hidden"))
                    {
                        Hidden.Click();
                    }

                    //Click on Save Button
                    clkSave.Click();
                    Thread.Sleep(3000);
                }
                // }

            }
        }
        public void submit() => clkSave.Click();

    }
}

