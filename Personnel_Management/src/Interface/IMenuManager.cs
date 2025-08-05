namespace Personnel_Management.Base.Interface
{
    public interface IMenuManager
    {
        void ShowMainMenu();
        void HandleOption(int option);
        void InputFullTimeEmployee();
        void InputPartTimeEmployee();
        void PromptSearchByName();
        void PromptDeleteById();



    }
}
