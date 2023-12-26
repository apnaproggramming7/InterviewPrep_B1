using System;

namespace ExcaptionHandling
{
    public class ExceptionExample
    {

        public void GetName()
        {
            try
            {
                int num1 = 10;
                int num2 = 0;

                var result = num1 / num2;

                try
                {

                }
                catch (Exception)
                {
                    throw;
                }


                throw new Exception();
                // Logic 
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException Eception : " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("ExceptionClasss:"+ ex.Message);

                //throw ex;
                //Catch/halde the exception
            }
            finally{
                Console.WriteLine("Its excute even we have error or not");
            }
        }
    }
}

/*
Q. How do you handle exception in your code/project?
- Using try catch 
- 

Q. How do you log your exception in your project?
- I store the exception in notepad
or 
I store the exception detail in to the database table


Q. We can see the last exception message (we will be also store the date and time)

Can we apply multiple try catch?
Yes


Q. Can we have multiple try block only?
NO, We cannot write only try block, its come with catch or finaly
 

Q. What is the use of finally in C#?

: Mostly we use finally block to clear the object or clear the memory
: Or we we want to excute something even we are getting exceptio or not

Q. What are the other way to clear the the object unwanted memory?
:
 using blcok - destroy the memory
 - Internally C# support garbage collection- by default it destroy the unwanted or unused memory

 - using finalize we can destroy the unwanted or unused memory



 */