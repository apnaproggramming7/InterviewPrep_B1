// See https://aka.ms/new-console-template for more information
using Static_Concept;

Console.WriteLine("=========Static Example===========\n");

//NormalClass obj1 = new NormalClass();

//obj1.GetNonStaticValue();
//obj1.GetStaticValue();

//NormalClass obj2 = new NormalClass();

//obj2.GetNonStaticValue();
//obj2.GetStaticValue();


/*
Q. What is mean by static classs
Answer: 
 -> We can create static class with the help of static keyword
 -> We can only define/add the static members, we cannot add non-static members
 -> When crate static class, then we can not instanciate / we can not inherit that class

Q. How we can access the static members from static class?


Q. How Static class is differ from normal or What is the difference b/w static class and normal class
Answer:
 -> In static class we can create only static members only, non-static members we cannot create
 -> IN Normal class , we can create static members as well as not static members

 -> We cannot create instance of static class (Inheritance is not possible)
 -> Normal class -> we can create (We can apply inhertance)

 -> In static we can create only static constructor
 -> We can create static and non-static constructor both

Q. What is diff b/w static method and non-static method?
Answer :
 -> To access non-static method, we will have to create object of that class can access based on object.
    NormalClass obj1 = new NormalClass(); obj1.Method();
 -> In Static- We can access the method directly based on classname (eg: StaticClassName.Method())


Q. What is the diff. b/w static field and non-static field?
Answer:

When we create static field, only one time memory create for that, if we will do anyoperation with that field
it will take from same memory(based on existing value).
public static int num = 10;


When we create non-static(instance) field, everytime memmory will be created
public int num = 10;



-> Static constructor will call first
 
 
 
 
 */


// We cannot create instance of a static class
//StaticClassExample obj123 = new StaticClassExample();

StaticClassExample.GetData();

NormalClass obj1 = new NormalClass();

obj1.GetNonStaticValue(); // 20
obj1.GetStaticValue(); // 20

NormalClass obj2 = new NormalClass();

obj2.GetNonStaticValue();
obj2.GetStaticValue();

//================================================

ClassWithStaticAndNonStaticField ob1= new ClassWithStaticAndNonStaticField();
ClassWithStaticAndNonStaticField ob2= new ClassWithStaticAndNonStaticField();
