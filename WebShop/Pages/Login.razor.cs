namespace WebShop.Pages
{
    public partial class Login
    {
        // Values entered to login and username fields
        private string username = "";
        private string password = "";

        // is the snackbar visible
        private bool snackBarIsOpen = false;

        // log in button clicked
        private void loginOnClick()
        {
            // if username and password are both correct, it navigates to your profile
            if (username == "reka" && password == "reka") 
            { 
                Global.loggedIn = true;
                NavManager.NavigateTo("/profile"); 
            }
            // else it makes the snackbar visible
            else
            {
                snackBarIsOpen = true;
                this.StateHasChanged();
            }
        }
    }
}
