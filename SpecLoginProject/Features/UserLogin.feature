

Feature: User Login
  As a user
  I want to be able to log into the application
  So that I can access my account
 @CheckValidLogin
  Scenario: Successful Login
    Given I am on the login page
    When I enter valid credentials
    And I click the login button
    Then I should be redirected to the home page

@CheckInValidLogin
  Scenario: Invalid Login
    Given I am on the login page
    When I enter invalid credentials
    And I click the login button
    Then I should see an error message

     @validcredentials
  Scenario: Missing Credentials
    Given I am on the login page
    When I do not enter any credentials
    And I click the login button
    Then I should see a validation message