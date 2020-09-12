Feature: XeroAddANZBankAccount
As a Xero User,
In order to manage my business successfully,
I want to be able to add an “ANZ (NZ)” bank account inside any Xero Organisation.

Scenario: Add an ANZ Bank Account
	Given I logon to Xero
	When I click the Business Bank Account Link
	And I click the Bank Account link
	Then I am happy