namespace WebShop.Pages
{
    public partial class Login
    {
        string username = "";
        string password = "";

        bool snackBarIsOpen = false;
        void loginOnClick()
        {
            if (username == "reka" && password == "reka") NavManager.NavigateTo("/profile");
            else
            {
                snackBarIsOpen = true;
                this.StateHasChanged();
            }
        }
    }
}
