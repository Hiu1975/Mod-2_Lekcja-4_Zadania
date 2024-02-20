// Zadanie 1

Console.WriteLine("Please give me your First Name: ");
string fName = Console.ReadLine();
Console.WriteLine("Your Last Name is ? ");
string LastName = Console.ReadLine();
Console.WriteLine("your Age is ?");
int Age = int.Parse(Console.ReadLine());
Console.WriteLine("Your sex is (m/w)?");
char sex = char.Parse(Console.ReadLine());
Console.WriteLine("Your PESEL number is?");
string PESEL = (Console.ReadLine());
Console.WriteLine("Your personal worker number is ?");
int PWN = int.Parse(Console.ReadLine()); //PWN === Personal Worker No

// Zadanie 2

char x = 'A', y = 'B', z = 'C';
Console.WriteLine($"{z}, {y}, {x}");


// Zadanie 3

Console.Write("Please give me length of sides of the rectangle (a,b) \r\na= ");
double side_A = double.Parse(Console.ReadLine());
Console.Write("b= ");
double side_B = double.Parse(Console.ReadLine());
double diagonal = Math.Round(Math.Sqrt(Math.Pow(side_A, 2) + Math.Pow(side_B, 2)), 2);
Console.WriteLine($"Length of diagonal = {diagonal}");

// Zadanie 4

int a4=10;
string b4="Szkoła Dotneta";
double c4 = 10.5; 
