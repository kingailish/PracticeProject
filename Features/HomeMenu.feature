Feature: HomeMenu
As a user on prepmajor website 
I want to navigate to the home menu
so that I can see available options

@mytag
Scenario: Home Menu
	Given that I navigate to "https://user-68906616-work.colibriwp.com/prepmajor1com/"
	When I click on Home Menu
	Then Prepmajor Home Menu Page is displayed
