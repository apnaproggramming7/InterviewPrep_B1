namespace OOPS_Concept
{
    public class MailExample
    {
        public bool EmailSent(string toEmail)
        {
            if (!string.IsNullOrEmpty(toEmail))
                return true;
            else
                return false;
        }

        public bool EmailSent(string toEmail, string role)
        {
            if (!string.IsNullOrEmpty(toEmail) && !string.IsNullOrEmpty(role))
                return true;
            else
                return false;
        }
    }
}
