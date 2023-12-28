namespace Other_Questions_Concepts
{
    public delegate int AddDeligate(int val1, int val2);
    public class DelegateExample
    {

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }                              
    }
}
/*
What is Deligate?

- Deligate is a function pointer
- We use deligate to pass funtion/method as a parameter
- We can create delegate with help of deligate keyword
- Delegate signature must be same as a mthod in the classs
- We can create delegate above the class(Under the class cannot create)



What are type of delegates 
- Siglecast and multi cast
 
public void GetData(int a, Employee emp, List<Employee> listEmp)
{


}

Q. What is Func, Action Predict
This is the predefine delegate

They will have some parameters

Func :
It can take zero, one and more meters

Action: 
It can take zero, one and more meters

Predicate:

 */
