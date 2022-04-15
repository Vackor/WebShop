using MatBlazor;

namespace WebShop.Shared
{
    public partial class MainLayout
    {
    string myStringValue;

    MatTheme theme1 = new MatTheme()
    {
        Primary = "#bcaaa4",
        Secondary = "#bdbdbd"
    };

        void HomeOnClick()
        {
            NavManager.NavigateTo("");
        }

        bool loggedIn = false;

        void profileOnClick()
        {
            string? page = loggedIn ? "/profile" : "/login";
            NavManager.NavigateTo(page);
        }
    }
}
