using InterviewPrep_B1;//namespace /package

Console.WriteLine("Hello, World!");

// We can have any object name (it should not be the predefine keyword,or any existing name which have already used)
TestClass obj = new TestClass();

// With the object name you can access the members from the class

//obj.GetDetails();


//ConstructExample objConstructor = new ConstructExample("Test");
//ConstructExample objConstructor1 = new ConstructExample(10);

//ConstructExample objConstructor3 = new ConstructExample("Test");




//ConstructExample objConstructor2 = new ConstructExample();

//ConstructExample objConstructor4 = new ConstructExample(objConstructor2);

ConstructExample objConstructor = new ConstructExample();


PropertiesExample objProp = new PropertiesExample();

Console.WriteLine(objProp.address); // Delhi
objProp.address = "Bangalore";

Console.WriteLine(objProp.address); // Delhi


Console.WriteLine(objProp.Name);
objProp.Name = "Sibtain";
Console.WriteLine(objProp.Name);
objProp.Name = "Wamique Aliyas";

//==========================================================
Console.WriteLine("=============Base Or Chain Constructor=============");
DerivedClass md = new DerivedClass();
DerivedClass md1 = new DerivedClass(1);
Console.WriteLine("=============END Base Or Chain Constructor=============");