using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encapsulation
{
    public class Manager 
    {
        protected internal void GetPromotion(Employee employee)
        {
            if (employee.IsSuccessful)
            {
                double currentSalary = employee.Salary;
                Console.WriteLine($"{employee.Name}`in ilkin maaşı: {employee.Salary}");
                employee.Salary=currentSalary+100;
                Console.WriteLine($"{employee.Name} Uğurlu işçidi 100 manat şirinlik verirem.");
            }
            else
            {
                Console.WriteLine($"{employee.Name} Tənbəl işçidi maaşın alacaq.");
            }
        }
    }
}
