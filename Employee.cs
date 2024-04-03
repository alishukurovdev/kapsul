
namespace Encapsulation
{
    public class Employee
    {
        private string _name;
        private bool _isSuccessful;
        private double _salary;

        public Employee(string name, bool isSuccessful, double salary)
        {
            Name = name;
            IsSuccessful = isSuccessful;
            Salary = salary;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public bool IsSuccessful
        {
            get
            {
                return _isSuccessful;
            }
            set
            {
                _isSuccessful = value;
            }
        }
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
    }
}
