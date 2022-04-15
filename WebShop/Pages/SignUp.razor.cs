namespace WebShop.Pages
{

    class GenderDef
    {
        public string Name { get; set; }

        public GenderDef(string name)
        {
            Name = name;
        }
    }

    public partial class SignUp
    {
        LoginModel myModel = new LoginModel();

        string[] GenderItems = new[]
        {
        "Male",
        "Female"
        };

        void Reset()
        {
            myModel.Username = null;
            myModel.Password = null;
            myModel.Gender = null;
            myModel.DateOfBirth = DateTime.MinValue;
        }
    }
}
