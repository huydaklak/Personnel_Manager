namespace Personnel_Management.src.Interface
{
    public interface IEmployeeUI
    {
        void InputFullTimeEmployee();
        void InputPartTimeEmployee();
        void PromptSearchByName();
        void PromptDeleteById();
        void PromptFindHighestSalary();
        void PromptCalculateTotalSalary();
        void PromptSearchById();
        void DisplaySortedBySalary();
        void DisplayAllEmployees();
    }
}
