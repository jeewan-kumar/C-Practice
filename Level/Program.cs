// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine(3+3);

// Console.Write("Hello world!");
// Console.Write("I will print on the same line");

// String name = "Jeewan";
// Console.WriteLine("Name : "+name);

// int myNum = 215;
// Console.WriteLine("Number : "+myNum);

/* variable */

// int myint = 5;
// double mydouble = 55.990;
// char mychar = 'd';
// bool mybool = true;
// string mystring = "hello";

// Console.WriteLine("Int Value : "+myint);
// Console.WriteLine("Double Value : "+mydouble);
// Console.WriteLine("Char Value : "+mychar);
// Console.WriteLine("Boolean Value : "+mybool);
// Console.WriteLine("String Value : "+mystring);

/* Explicit Casting */

// double myDouble = 9.78;
// int myInt =(int) myDouble;

// Console.WriteLine("Without typecasting : "+myDouble);
// Console.WriteLine("With typecasting : "+myInt);


/* User Input */

// Console.Write("Enter your Name : ");
// string myName = Console.ReadLine();

// Console.Write("Enter your Age : ");
// int myAge = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Name : "+myName);
// Console.WriteLine("Name : "+myAge);

/* Unsigned integer */

// char a = 'G';
// int i = 89;
// short s = 56;
// long l = 4564;
// uint ui = 95;
// ushort us = 76;
// ulong ul = 3624573;
// double d = 8.358674532;
// float f = 3.733645f;
// decimal dec = 39.5m;

// Console.WriteLine("Char : "+a);
// Console.WriteLine("Integer : "+i);
// Console.WriteLine("Short : "+s);
// Console.WriteLine("Long : "+l);
// Console.WriteLine("Float : "+f);
// Console.WriteLine("Decimal : "+dec);
// Console.WriteLine("Double : "+d);
// Console.WriteLine("Unsinged integer: "+ui);
// Console.WriteLine("Unsinged short: "+us);
// Console.WriteLine("Unsinged long : "+ul);

/* Signed integral data type*/

// sbyte a = 126;
// Console.WriteLine(a);
// a++;
// Console.WriteLine(a);
// a++;
// Console.WriteLine(a);
// a++;
// Console.WriteLine(a);

/* Conversions */ //error
// double a = 1.0;
// decimal b = 2.1m;
// Console.WriteLine(a + (double)b);
// Console.WriteLine((decimal)a + b);

// double d = 3D;
// d = 4d;
//d = 3.934_001;

//float f = 3_000.5F;
//f = 5.4f;

//decimal myMoney = 3_000.5m;
//myMoney = 400.75M;

//Console.WriteLine(d);
//Console.WriteLine(f);
//Console.WriteLine(myMoney);



/* User Details */

Console.Write("Enter your user Name : ");
String uName = Console.ReadLine();

Console.Write("Enter your age : ");
int uAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your Name : "+uName);
Console.WriteLine("your Age : "+uAge);