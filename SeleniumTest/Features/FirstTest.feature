Feature: FirstTest
	User Login and Creating a new User 


Scenario Outline: Log in, Navigate and Create a new user
	Given I navigate to Vizor 'Login' Page
	  And I enter 'test.user@vizor.ie' and 'Testuser1$' and click Login button
	  And I navigate to Create User page via menu
	When I feel all fields from table
	| FirstName   | Surname   | Email   | InternationalCode   | Area   | PhoneNumber   |
	| <FirstName> | <Surname> | <Email> | <InternationalCode> | <Area> | <PhoneNumber> |
	  And I click 'Create' button
	Then I see that user has been successfully created
	  And I sign out

	Examples: 
	| FirstName | Surname | Email                 | InternationalCode | Area | PhoneNumber |
	| John      | Smith   | email1@mailinator.com | 123               | 321  | 1234567     |
	| John      | Doe     | email2@mailinator.com | +123              |      | 1234567     |
	| John      | Doe     | email2@mailinator.com | +123              | abc  |             |
	| John      | Doe     | email3@mailinator.com |                   | 888  |             |
	| John      | Doe     | email2@mailinator.com | 380               | 67   | 1485011     |