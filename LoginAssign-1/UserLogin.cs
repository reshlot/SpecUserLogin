namespace LoginAssign_1
{
    public class UserLogin
    {

        public string UserName { get; set; }

        public string Password { get; set; }

       /* public bool ValidateCredentials()
        {
            // Code to validate the user's credentials
            // You can replace this with your own authentication logic
            if (UserName == "admin" && Password == "password")
            {
                return true;
            }
            else
            {
                return false;
            }
*/
       // }
        public bool ValidateCredentials()
        {
            // Code to validate the user's credentials
            // You can replace this with your own authentication logic
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckValidLogin(string username, string password)
        {
            // Code to check if the provided username and password are valid
            // You can replace this with your own authentication logic
            if (username == "admin" && password == "password")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckInvalidLogin(string username, string password)
        {
            // Code to check if the provided username and password are invalid
            // You can replace this with your own authentication logic
            if (username == "invalid" && password == "invalid")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
    