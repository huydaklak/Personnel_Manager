using System;
using Personnel_Management.UI;
namespace Personnel_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MenuManager menuManager = new MenuManager();
            menuManager.Run();
            Console.WriteLine("test git");
        }
    }
}
