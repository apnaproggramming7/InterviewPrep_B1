using System.Collections;

namespace Other_Questions_Concepts
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CollectionsExample
    {
        public void GetData()
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("");
            al.Add("ApnaProgramming");
            al.Add(true);


            al.Remove(1);
            al.RemoveAt(2);


            int[] arr = { 10, 12, 13 };


            List<string> list = new List<string>();

            list.Add("shad4you");
            list.Add("ApnaProgramming");

            List<int> listInt = new List<int>();
            listInt.Add(1);


            Hashtable hashtable = new Hashtable();
            hashtable.Add("Id", 1001);
            hashtable.Add("Name", "shad4you");

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("Id", 1001);
            dic.Add("CompanyId", 100001);

        }

        public void AddStudent()
        {
            //List<Student> students2 = new List<Student>();
            //students.Add(new Student()
            //{
            //    Id = 1001,
            //    Name = "Wamique"
            //});
            //students.Add(new Student()
            //{
            //    Id = 1003,
            //    Name = "Naushad"
            //});

            //students.Add(new Student()
            //{
            //    Id = 1004,
            //    Name = "Dilshad"
            //});

            List<Student> students = new List<Student>()
            {
                new Student()
                {
                     Id = 1001,
                    Name = "Wamique"
                },
                new Student()
                {
                    Id = 1003,
                    Name = "Naushad"
                },
                new Student()
                {
                    Id = 1004,
                    Name = "Dilshad"
                }
            };         


        }
    }
}

/*
 Collections:
Q. What is the diff. b/w Array & ArrayList
Answer: 

Array:  We can store only similar type of data  
        We can not add/remove in middle of an array



ArrayList : We can store any type of value(object)
            We can  add/remove in middle of an ArrayList

Q. What is the diff. b/w ArrayList & List<T>

Answer: 
ArrayList: We can sotr any type value

List<T> : Place of T we assing type, and we can store the value based on type


Q. What is the difference between List<T> & Hasttable<Key,Value>
Answer:
List<T> : will be based on given type

Hashtable: Here Key and valir is there, We can add key and value, both are object type only



Q. What is the diff. b/w Hasttable<Key,Value> & Dictionary<TKey,TVal>


Hashtable: Here Key and value pair is there, We can add key and value, both are object type only

 Dictionary<TKey,TVal>: It is alos key, value pair. Whatever type we are adding, that type of value we can add onl.
 


LINQ: Language Integrated Language
=====
It works source of data

Q. What is the diff. b/w FirstOrDeafult and First?
Answer: 

FirstOrDeafult: When we trying to get the data from list, if data is not there is it will not throw the run time error (It will return null)
First: When we trying to get the data from list, if data is not there is it will throw the run time error

Q. What is the difference b/w SignleOrDefault and Single

SignleOrDefault: When we trying to get the data from list, if data is not there is it will not throw the run time error (It will return null)
Single: When we trying to get the data from list, if data is not there is it will throw the run time error

Q. What is the diff. b/w FirstOrDeafult and SignleOrDefault
Answer:
SignleOrDefault : We get the data,if we are gettin more than one data, then it will throw exception

FirstOrDeafult: We get the data, it ill return the first record of the list 
(If we are getting multiple record from that it will return only 0- index data)
In case -> if we are not founding any data, then it will retirn null. (It will not throw error)

Q. How to get disctinct data?

Answer: We use the get unique record 
students.ToList().Distinct();


==========================

Q. Boxing vs Unboxing

Boxing
=======
- Converting from any type to object called as Boxing 
- Its happer automatically (convertion is not required)

Unboxing:
=========
- We conver the object type data in to normal type - Unboxing
- Conversion is requeired


int num = 10;

object boxValue = num; // Boxing

int unboxValue = (int)boxValue; // Unboxing


 */