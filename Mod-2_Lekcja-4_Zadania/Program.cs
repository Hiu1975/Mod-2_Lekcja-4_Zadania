// Zadanie 1

Console.WriteLine("Please give me your First Name: ");
string fName = Console.ReadLine();
Console.WriteLine("Your Last Name is ? ");
string lastName = Console.ReadLine();
Console.WriteLine("your Age is ?");
byte age = byte.Parse(Console.ReadLine());
Console.WriteLine("Your sex is (m/w)?");
char sex = char.Parse(Console.ReadLine());
Console.WriteLine("Your PESEL number is?");
string pesel = Console.ReadLine();
Console.WriteLine("Your personal employee number is ?");
string pen = Console.ReadLine(); //PEN === Personal Employee No

// Zadanie 2

char x = 'A', y = 'B', z = 'C';
Console.WriteLine($"{z}, {y}, {x}");


// Zadanie 3

Console.Write("Please give me length of sides of the rectangle (a,b) \r\na= ");
double sideA = double.Parse(Console.ReadLine());
Console.Write("b= ");
double sideB = double.Parse(Console.ReadLine());
double diagonal = Math.Round(Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)), 2);
Console.WriteLine($"Length of diagonal = {diagonal}");

// Zadanie 4

int a4=10;
string b4="Szkoła Dotneta";
double c4 = 10.5; 
