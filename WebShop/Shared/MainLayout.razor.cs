using MatBlazor;
using Microsoft.JSInterop;

namespace WebShop.Shared
{
    public partial class MainLayout
    {
        // search value
        private string searchString;

        private bool snackBarIsOpen = false;

        // theme for the app
        public MatTheme theme = new MatTheme()
        {
            Primary = "#bcaaa4",
            Secondary = "#bdbdbd"
        };

        // Home button callback that navigates to home page
        private void HomeOnClick()
        {
            NavManager.NavigateTo("");
        }

        // Pofile button callback
        private void profileOnClick()
        {
            // if the user is logged in, it navigates them to their profile, or if they're not, it navigates them to log in page
            string? page = Global.loggedIn ? "/profile" : "/login";
            NavManager.NavigateTo(page);
        }

        // Cart button callback that navigates to your cart 
        private void cartOnClick()
        {
            NavManager.NavigateTo("/cart");
        }

        // search button callback
        private void searchOnClick()
        {
            // load cards if it hasn't been done yet
            if (Global.cards.Count == 0)
            {
                Global.createCards();
            } 

            // it navigates to the product if it's found
            bool found = false;
            Console.WriteLine(searchString);
            foreach (var item in Global.cards)
            {
                if (item.Name == searchString)
                {
                    found = true;
                    Global.theChosenOne = item;
                    NavManager.NavigateTo("/product");
                    break;
                }
            }

            // else it warns the user
            if (!found)
            {
                snackBarIsOpen = true;
                this.StateHasChanged();
            }
        }
    }
}
