

namespace Design_Patterns.Adaptor.AdaptorPattern.Core
{
    public class EmployeesDateReader
    {
        public IEnumerable<Employee> GEtAllEmployees()
        {
            return new List<Employee>() 
            { 
                new Employee()
                {
                    FirstName = "shehab ",
                    LastName = " mohamed ",
                    SecondName = "Fathy",
                    PayItems = new List<PayItem>
                    {
                        new PayItem{ Name = "BasicSalary",Value= 1000},
                        new PayItem{ Name = "Tranportaion",Value= 250},
                        new PayItem{ Name = "Medical Insurance",Value= 150, IsDeduction =true},
                    }
                }, 
                new Employee()
                {
                    FirstName = "mohamed ",
                    LastName = " ahmed ",
                    SecondName = "Fathy",     
                    PayItems = new List<PayItem>
                    {
                        new PayItem{ Name = "BasicSalary",Value= 1000},
                        new PayItem{ Name = "Tranportaion",Value= 250},
                        new PayItem{ Name = "Medical Insurance",Value= 150},
                    }
                },
            };
        }
    }
}
