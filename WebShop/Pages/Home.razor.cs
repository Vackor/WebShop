// Home page code

namespace WebShop.Pages
{
    public partial class Home
    {
        // Page description texts
        private string szoveg1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec faucibus diam libero. Donec pellentesque elit eros, sit amet varius nisl ullamcorper quis. Nam at metus lorem. Proin scelerisque tempor arcu, vitae venenatis odio convallis ac. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In pharetra faucibus gravida. Quisque cursus ut odio facilisis vehicula. Vestibulum nec leo non tellus fringilla molestie. Quisque euismod venenatis auctor. Ut consequat, odio non rhoncus accumsan, tellus lacus cursus felis, eget tempus libero felis sed ante. Suspendisse sit amet urna vel purus finibus ornare at in velit. Etiam non nunc ac magna porta bibendum sit amet sed magna.";
        private string szoveg2 = "Cras lectus tellus, malesuada non imperdiet quis, sollicitudin eget nunc. Suspendisse imperdiet, velit nec mollis hendrerit, ante mauris eleifend dui, et scelerisque nibh elit eget est. Praesent sed condimentum tellus. Nullam molestie justo ut ante porttitor, vel vestibulum libero eleifend. Nam vitae magna id sapien viverra tristique a at velit. Sed sit amet faucibus elit. Duis a leo eget quam feugiat dictum. Donec euismod, eros vel imperdiet feugiat, arcu ipsum hendrerit sapien, ut laoreet justo magna sit amet tellus. Nulla dolor justo, euismod sed venenatis in, pellentesque quis quam. In vehicula nibh metus, sit amet convallis elit mattis vitae. Donec a posuere massa. Phasellus sem sapien, elementum a dapibus in, convallis a justo. Aenean at elit ex. Aliquam bibendum orci faucibus tempor condimentum.";
        
        // Callback functions of category selection
        private void onCategory1()
        {
            // Navigates to the main page of ice creams
            NavManager.NavigateTo("/icecream");
        }
        private void onCategory2()
        {
            // Navigates to the main page of ice creams
            NavManager.NavigateTo("/icecream");
        }
        private void onCategory3()
        {
            // Navigates to the main page of ice creams
            NavManager.NavigateTo("/icecream");
        }
    }
}
