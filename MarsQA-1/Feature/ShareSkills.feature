Feature: ShareSkills
	In order to add my Skill in Profile
As a User I want to be able to add Share Skills details

Background:
	Given User using the Chrome browser
	When Useris  navigates to "http://localhost:5000/Home" url
	And User is enter the valid login credentials "shriya1.gajjar@gmail.com" and "Shriya@2906"
	Then User able to log in to the application

@mytag
Scenario Outline: check user able to share skills
	Given User clicks on the Share Skill button
	When  User enter the details < Title >,< Description >,< Category >,< Subcategory >,< Tags >,< ServiceType >,< LocationType >,< SkillTrade >,< SkillExchange >,< Credit >,< WorkSamples > and < Active >
	And   User entere Available Days
	Then  that Skills should be added to the Manage Listing page

	Examples:
		| Title       | Description | Category           | Subcategory | Tags      | ServiceType         | LocationType | SkillTrade | SkillExchange | Credit | WorkSamples     | Active |
		| Skill Share | Automation  | Programmimg & Tech | QA          | QAAnalyst | Hourly basis service | Online       | Credit     | Available     | 100    | WorkSamples.pdf | Active |