namespace OOPS_Concept
{
    public class CommonClass
    {
        public string CreatedBy { get; set; }
        public DateTime CreatenOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool IsActive { get; set; }
    }


    public class Student: CommonClass
    {
        public int Id { get; set; }
        public string Name { get; set; }        
    }

    public class Teacher : CommonClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
    }
}
