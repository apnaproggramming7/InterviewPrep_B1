namespace InterviewPrep_B1
{
    public class PropertiesExample
    {
        TestClass obj1 = null;
        public PropertiesExample()
        {
            if (obj1 != null)
            {
                obj1 = new TestClass();
            }
        }

        public string address = "Delhi";
        public int Id { get; set; }
        public string Name { get; set; } = "Aliyas";
        public string Addess { get; set; } = "Kolkata";

        public void Get()
        {

        }

        public void Get2()
        {

        }


        // Access Specifier/Modifier
        /*
         There are some type of access specifiers
         1. public
         2. private
         3. protected
         4. internal
         5. protected internal
         6. private protected                 
         */



    }

    /*
     
    Q. Can class  have private access?
    Q. Can we write private access specifier with class? 
    No , Class can have only public and internal

     What is properties 

     What is mean by getter & Setter in c#


    Getter => To view/read the value
    Setter => To modify/Update the value
         
     
     */
}
