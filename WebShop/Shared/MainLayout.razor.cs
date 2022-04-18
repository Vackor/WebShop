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

        void profileOnClick()
        {
            string? page = Global.loggedIn ? "/profile" : "/login";
            NavManager.NavigateTo(page);
        }
        
        void cartOnClick()
        {
            NavManager.NavigateTo("/cart");
        }
    }
}
