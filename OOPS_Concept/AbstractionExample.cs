using System.Collections;

namespace OOPS_Concept
{
    public class AbstractionExample
    {

        //Encaptulatio Process
        public void GetDetails()
        {
            ArrayList al= new ArrayList();
            al.Add("data");


            MailSentClass mail = new MailSentClass();
            mail.EmailSent("rerserwe");
        }
    }
}

/*
 What is mean by abstraction?

- To hiding the details ( We will be hinding the details from one class/file to another class/file)
- We can apply abstraction based on 2 concepts
    - using Abstract class
    - using Interface

- What is the difference between abstract class and interface?


What is mean by encapsulation?
- To hiding the details (We completly hide the code level details with end user/developers)
 
 */
