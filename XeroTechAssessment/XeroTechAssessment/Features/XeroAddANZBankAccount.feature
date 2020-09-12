Feature: XeroAddANZBankAccount
As a Xero User,
In order to manage my business successfully,
I want to be able to add an “ANZ (NZ)” bank account inside any Xero Organisation.

Scenario: Add an ANZ Bank Account
	Given I logon to Xero
	When I click the Business Bank Account Link
	And I click the Bank Account link
	And I click the Bank Account button
	And I select ANZ
	And I select Everyday Account
	And I enter account name 'Abraham Test'
	And I enter account number 01-0277-0100200-00
	And I click the continue button
	Then account name 'Abraham Test' with account number '01-0277-0100200-00' is created