using Personnel_Management.UI;

namespace Personnel_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuManager menuManager = new MenuManager();
            menuManager.ShowMainMenu();
        }
    }
}
