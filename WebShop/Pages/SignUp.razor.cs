namespace WebShop.Pages
{

    public partial class SignUp
    {
        // Login Model that will help to validate
        private SignUpModel myModel = new SignUpModel();
        // Gender options 
        private string[] GenderItems = new[]
        {
        "Male",
        "Female"
        };

        // reset button callback that resets every value
        private void Reset()
        {
            myModel.Username = null;
            myModel.Password = null;
            myModel.Gender = null;
            myModel.DateOfBirth = DateTime.MinValue;
        }
    }
}
