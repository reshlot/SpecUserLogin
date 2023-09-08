namespace SpecLoginProject.StepDefinitions
{
    [Binding]
    public class UserLoginSteps
    {
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            // Code to navigate to the login page
        }

        [When(@"I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            // Code to enter valid credentials
        }

        [When(@"I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            // Code to enter invalid credentials
        }

        [When(@"I do not enter any credentials")]
        public void WhenIDoNotEnterAnyCredentials()
        {
            // Code to not enter any credentials
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            // Code to click the login button
        }

        [Then(@"I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheHomePage()
        {
            // Code to verify the redirection to the home page
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // Code to verify the presence of an error message
        }

        [Then(@"I should see a validation message")]
        public void ThenIShouldSeeAValidationMessage()
        {
            // Code to verify the presence of a validation message
        }
    }
}