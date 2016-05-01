using System.Web.UI;

namespace WebFormsDI
{
    public class BasePage : Page
    {
        public BasePage()
        {
            IoC.BuildUp(this);
        }
    }
}