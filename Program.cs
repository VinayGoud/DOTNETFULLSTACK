// See https://aka.ms/new-console-template for more information

using Week2DemoProject;

Console.Write("Hola, World");

Console.WriteLine("Hello, World!");

String varDatatype = "Vinay";

//String varDatatype2 = 'Vinay';
char varChar = 'v';

//int varInt = 0;
float varFloat = 0.021f;
//bool varBool = 0;
bool varBool2 = false;
Console.WriteLine(varChar);
Console.WriteLine(varBool2);
Console.WriteLine(varFloat);
Console.WriteLine(varDatatype);
//Console.WriteLine(varDatatype2);
Console.ReadKey();



Product pdr = new Product();

pdr.ProductName = "VinnuIphone";
pdr.ProductID = 2002121;
pdr.Sum();

Console.WriteLine(pdr);
Console.WriteLine("Enter Your Product Name:");
var userInput = Convert.ToString(Console.ReadLine());
Console.WriteLine(userInput);


Console.WriteLine("Enter your Product ID:");
int userInputPrdID = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(userInputPrdID);


//Console.WriteLine(pdr.ProductID);
//Console.WriteLine(pdr.Sum());

//Console.ReadLine("Your ProductName is :");




//Student Info Class Object Creation    

StudentInfo stdinfo = new StudentInfo();

stdinfo.StudentName = "Vinay";
stdinfo.StudenID = 12;
stdinfo.StudentEmail = " ";
stdinfo.StudentPhone = 0000000000;  
stdinfo.StudentAddress = " ";
Console.WriteLine(stdinfo);
Console.WriteLine("Enter Your Student Name:");
   var userInputStdName = Convert.ToString(Console.ReadLine());
Console.WriteLine(userInputStdName);

Console.WriteLine("Enter your Student ID:");
var userInputStudentID = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userInputStudentID);

Console.WriteLine("Enter your Student Email:");
var userInputStudentEmail = Convert.ToString(Console.ReadLine());
Console.WriteLine(userInputStudentEmail);

Console.WriteLine("Enter your Student Phone number:");
var userInputPhone = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userInputPhone);

Console.WriteLine("Enter your Student Address:");
var userInputStudentAddress = Convert.ToString(Console.ReadLine());
Console.WriteLine(userInputStudentAddress);




//Arithemetic Operations

int ea = 20;
int eb = 30;

//dynamic 
Console.WriteLine("Enter the first number:");
int sa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second number:");
int sb = Convert.ToInt32(Console.ReadLine());

var Sum = sa * sb;
Console.WriteLine("The Sum of 2 numbers :");
Console.WriteLine(Sum);






