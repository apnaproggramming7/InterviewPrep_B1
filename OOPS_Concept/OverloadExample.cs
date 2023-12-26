
namespace OOPS_Concept
{
    public class MailSentClass
    {
        public bool EmailSent(string toEmail)
        {
            if (!string.IsNullOrEmpty(toEmail))
                return true;
            else
                return false;
        }

        public void EmailSent(string toUserEmail ,int id)
        {
            //return true;
        }

        public int EmailSent(int id, string toUserEmail)
        {
           return 1;
        }

        public bool EmailSent(string toEmail, string role)
        {
            if (!string.IsNullOrEmpty(toEmail) && !string.IsNullOrEmpty(role))
                return true;
            else
                return false;
        }

        public bool EmailSent(string toEmail, string role, int age)
        {
                return true;
        }

        public bool EmailSent(MailDTO mailDTO)
        {
            if (mailDTO != null)
                return true;
            return false;
        }
    }

    public class MailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Body { get; set; }
    }
}


/*
 
We have differet type of polymorphism

- Method Overloading

    - Method will be with same name and different parameters(Parameter type must be different, should not with same order)
    - We can apply method overloading in the same class

- Method Overriding 
 
 */