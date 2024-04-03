
namespace Encapsulation
{
    public class Assistant 
    {
        protected internal void GetFeedback(Employee employee)
        {
            if (employee.IsSuccessful)
            {
                Manager manager = new Manager();
                manager.GetPromotion(employee);
                Console.WriteLine($"{employee.Name} yaxsi ishci.");
            }
            else
            {
                Console.WriteLine($"{employee.Name} pis ishci.");
            }
        }
    }
}
