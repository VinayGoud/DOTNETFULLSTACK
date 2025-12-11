// See https://aka.ms/new-console-template for more information

using System;
using Week2DemoProject;

//Console.Write("Hola, World");

//Console.WriteLine("Hello, World!");

//String varDatatype = "Vinay";

////String varDatatype2 = 'Vinay';
//char varChar = 'v';

////int varInt = 0;
//float varFloat = 0.021f;
////bool varBool = 0;
//bool varBool2 = false;
//Console.WriteLine(varChar);
//Console.WriteLine(varBool2);
//Console.WriteLine(varFloat);
//Console.WriteLine(varDatatype);
////Console.WriteLine(varDatatype2);
//Console.ReadKey();



//Product pdr = new Product();

//pdr.ProductName = "VinnuIphone";
//pdr.ProductID = 2002121;
//pdr.Sum();

//Console.WriteLine(pdr);
//Console.WriteLine("Enter Your Product Name:");
//var userInput = Convert.ToString(Console.ReadLine());
//Console.WriteLine(userInput);


//Console.WriteLine("Enter your Product ID:");
//int userInputPrdID = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(userInputPrdID);


//Console.WriteLine(pdr.ProductID);
//Console.WriteLine(pdr.Sum());

//Console.ReadLine("Your ProductName is :");




//Student Info Class Object Creation    

//StudentInfo stdinfo = new StudentInfo();

//stdinfo.StudentName = "Vinay";
//stdinfo.StudenID = 12;
//stdinfo.StudentEmail = " ";
//stdinfo.StudentPhone = 0000000000;  
//stdinfo.StudentAddress = " ";
//Console.WriteLine(stdinfo);
//Console.WriteLine("Enter Your Student Name:");
//   var userInputStdName = Convert.ToString(Console.ReadLine());
//Console.WriteLine(userInputStdName);

//Console.WriteLine("Enter your Student ID:");
//var userInputStudentID = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(userInputStudentID);

//Console.WriteLine("Enter your Student Email:");
//var userInputStudentEmail = Convert.ToString(Console.ReadLine());
//Console.WriteLine(userInputStudentEmail);

//Console.WriteLine("Enter your Student Phone number:");
//var userInputPhone = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(userInputPhone);

//Console.WriteLine("Enter your Student Address:");
//var userInputStudentAddress = Convert.ToString(Console.ReadLine());
//Console.WriteLine(userInputStudentAddress);




//Arithemetic Operations

//int ea = 20;
//int eb = 30;

////dynamic 
//Console.WriteLine("Enter the first number:");
//int sa = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the Second number:");
//int sb = Convert.ToInt32(Console.ReadLine());

//var Sum = sa * sb;
//Console.WriteLine("The Sum of 2 numbers :");
//Console.WriteLine(Sum);



//MathOperations mul = new MathOperations();

//Console.WriteLine("Enter your First number:");
//var firstNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(firstNumber);


//Console.WriteLine("Enter your Second number:");
//var secondNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(secondNumber);

//mul.varA = firstNumber;
//mul.varB = secondNumber;

//Console.WriteLine("Your answer is :");
//Console.WriteLine(mul.MultiplicationOperations());



//int num1 = 18;
//int num2 = 20;

//int sum1 = num1 * num2;
//Console.WriteLine(sum1);
//Console.WriteLine(sum1--);
//Console.WriteLine(--sum1);
////Console.WriteLine(sum1++);
////Console.WriteLine(++sum1);


//for (int i = 0; i < 10; i++) {

//    Console.WriteLine(i);
//}

//var testCase = 11 > 10 ? "Condion True" : "condition False";

//Console.WriteLine(testCase);


////coalescing

//String testName = null;
//String testCas1 = testName ?? "Cena";

//Console.WriteLine(testCas1);




//Task 02 Find Area of rectngle

//int recHeight = 10;
//Console.WriteLine("Enter the Height of Rectangle");
//int recHeight = Convert.ToInt32(Console.ReadLine());

////int recWidth = 5;
//Console.WriteLine("Enter the Width of Rectangle");
//int recWidth = Convert.ToInt32(Console.ReadLine());

//int areaofRect = recHeight * recWidth;
//Console.WriteLine("Area of Rectangle is :" + areaofRect);

// Data Types conversions 

// There are 2 types of conversions 
//1. Implicit Conversions - Compiler will handle all implicit conversions between compatable data types,
//                        - When there is no loss of infirmation if there is no posibility of conversions
//2. Explicit Conversions - We need to take care of Conversions 


//Implicit Conversions Example

//int varValue1 = 10;
//float varValue2 = varValue1;

//Console.WriteLine(varValue2);


////Explicit Conversions
//float varValue3 = 10.01f;
////int varValue4 = (int)varValue3;
//int varValue5 = Convert.ToInt32(varValue3);
////float varValue2 = varValue1;

//Console.WriteLine(varValue5);


//String stringVarAge = "50";
////int age = int.Parse(stringVarAge);

//long a = 100000;
//int baa = (int)a;   // explicit cast


//double x = 10.75;
//int yqq = (int)x;   // explicit: y = 10 (decimal removed)


//bool res = int.TryParse(stringVarAge, out int age);

//Console.WriteLine(baa);
//Console.WriteLine(yqq);

//if (int.TryParse(stringVarAge, out int age1))
//{
//    Console.WriteLine("Valid Age = " + age1);
//}
//else
//{
//    Console.WriteLine("Invalid number!");
//}


//Arrays

//COllection of elements of the same datatypes.
// can store multiple values in single variable
// Identified by indexing (starts from 0)

////An array is a fixed-size collection of elements of the same data type, stored in continuous memory, and accessed using index numbers.

//String[] colors = new string[5];

//colors[0] = "Red";
//colors[1] = "Blue";
//colors[2] = "Black";
//colors[3] = "Green";

////Console.WriteLine(colors[0]);

//Console.WriteLine(colors[4]);



//// 2nd way of Arrays

//String[] colors1 = new[] { "Red", "Green", "Blue", "Black" };


////3rd way

//String[] colors2 = { "Red", "Green", "Blue", "Black" };

//foreach (var loop1 in colors2)
//{
//    Console.WriteLine(loop1);
//}

//Statements


//Assignment  -	Store a value in a variable
//Expression  -	Any action statement (a++, method call, etc.)
//Conditional - 	Decision-making statements (if, switch)
//Iteration	Repeating code (for, foreach, while)


// Switch Case

Console.WriteLine("Enter the day of week");

int dayOfWeek = int.Parse(Console.ReadLine());

switch (dayOfWeek) {

    case 1:
        Console.WriteLine("Monday");
        break;
    case 2: 
        Console.WriteLine("Tuesday");
        break;
    case 3: 
         Console.WriteLine("Wednesday");
         break;
    case 4:
   
        Console.WriteLine("Thursday");
        break;
    case 5: 
         Console.WriteLine("Friday");
         break;

    case 6:
        Console.WriteLine("SaturDay");
        break;
    case 7: 
         Console.WriteLine("Sunday");
         break;
    default:
        Console.WriteLine("Please Enter valid input");
        break;

}


//Loops 
//While loop --- Condition is checked first if condition is true loop starts,
//if condition is false = loop runs 0 times.

Console.WriteLine("Enter a input number");

//int inputNum = int.Parse(Console.ReadLine());

int inputNum = Convert.ToInt32(Console.ReadLine());

int startNum = 0;

while ( startNum <= inputNum)
{
    Console.WriteLine(startNum);
    startNum = startNum + 3;
    

}



//do while - Loop starts without checking the condition
// It will run first go to the body execute body once then check the condition 
//if it is true --> repeat
//if it is false --. Stop
// so it will execute atleast once


int startingNumber1 = 111;
int product;

Console.WriteLine("Please enter a number: ");
int userInput1 = Convert.ToInt32(Console.ReadLine());

do
{
    product = startingNumber1 * userInput1;
    Console.WriteLine($"{userInput1} * {startingNumber1} = {product}");
  //  Console.WriteLine(userInput1 * startingNumber1 = product);
    startingNumber1 += 1;

} while (startingNumber1 <= 10);
