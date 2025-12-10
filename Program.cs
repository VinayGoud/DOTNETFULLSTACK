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