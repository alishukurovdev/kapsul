namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Alik", true, 700.00);
            Employee employee2 = new Employee("Fiko", false, 554.70);
            Assistant assistant = new Assistant();
            assistant.GetFeedback(employee1);
            assistant.GetFeedback(employee2);
            Console.WriteLine($"{employee1.Salary}manat Ümumi maaşı: {employee1.Name}");
            Console.WriteLine($"{employee2.Salary}manat Ümumi maaşı: {employee2.Name}");
        }

    }
}
