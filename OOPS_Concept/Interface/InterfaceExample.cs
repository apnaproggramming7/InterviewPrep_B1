namespace OOPS_Concept.Interface
{
    interface IEmployee
    {
        // We cannot create the data members
        //int a = 10; We cannot create filed of instance member

        //Members will the the public

        //int EmpId { get; set; }

        // Abstract method
        void GetEmployee();
        void AddEmployee();
        void DeleteEmployee();

        void GetData()
        {
            Console.WriteLine("Normal method");
        }

        EmployeeDTO UpdateEmployee(EmployeeDTO employee)
        {
            var empDTO = new EmployeeDTO();
            if (employee != null)
            {
                empDTO = employee;
            }

            return empDTO;
        }

        static decimal GetAnnualBonus()
        {
            Console.WriteLine("Fixed bonus: 5000.00");
            return 5000.00M;
        }
    }

    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }


    public class Employee : IEmployee
    {
        //public int EmpId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddEmployee()
        {
            //throw new NotImplementedException();
        }

        public void DeleteEmployee()
        {
            //throw new NotImplementedException();
        }

        public void GetEmployee()
        {
            //throw new NotImplementedException();
        }
    }

}

/*
- Basically we use interface to apply abstraction 
in the project at file/class level

- To apply abstraction in c#, we can use interface
- We can create interface using interface keyword
- Default access of interface is internal
- Default access of interface members (method/properties) is public
- We cannot apply/provide any access specifiers/modifiers
- It support multiple Inheritance
- Interface can inherit another interface too.
- Interface cannot inherit class
- We cannot create instance of interface
- We cannot create any field 
(data members eg: int a = 10; protected string name;) under the interface 


 Before C# 8.0 Version
======================
- Interface was collection abstract methods, properties & events
- Interface cannot have default/normal method implementation
- Interface cannot have static method 

On 8.0 or later version (New Points)
=======================
- You can also create abstract and non abstract method
- You can also create static method

 */
