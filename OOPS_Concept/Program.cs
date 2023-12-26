// See https://aka.ms/new-console-template for more information
using OOPS_Concept;
using OOPS_Concept.AbstractClass;
using OOPS_Concept.Interface;

Console.WriteLine("OPPS Concept \n =================");

//Child  child = new Child();


Child1 obj1= new Child1();

MailSentClass mail = new MailSentClass();

MethodOverridExample example = new MethodOverridExample();
example.GetDetails();

//===============================Abstraction==============

Employee employee = new Employee();
employee.AddEmployee();

//=========================================


IEmployee employee1 = new Employee();

EmployeeDTO empDTO = new EmployeeDTO();
employee1.UpdateEmployee(empDTO);
IEmployee.GetAnnualBonus();

//LaptopMobleTab laptopMobleTab = new LaptopMobleTab();
//((IMobile)laptopMobleTab).GetCovers();

IMobile mob = new LaptopMobleTab();
mob.GetCovers();

ILaptop laptop = new LaptopMobleTab();
laptop.GetCovers();

ITablet tab = new LaptopMobleTab();
tab.GetCovers();


//AbstractClassExample objAbstract = new AbstractClassExample();


/*
 Inheritance:

Q1. What is inheritance in C#?
Answer:
 => Inheritance is mechanism to access members from one class to 
 another class based on parent-child (Base-derived/ Super-Sub) class
 relationship


 => We use inheritance for code reusability


Q2. What are the different type of inheritance?
Answer:

=> We have different type of inheritance in C#.
i.  Single Level
ii. Multi-Level 
ii. Hierarchical
iv. Multiple
v.  Hybrid

 
 
 */
