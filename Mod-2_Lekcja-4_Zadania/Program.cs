// Zadanie 1

Console.WriteLine("Please give me your First Name: ");
string fName = Console.ReadLine();
Console.WriteLine("Your Last Name is ? ");
string LastName = Console.ReadLine();
Console.WriteLine("your Age is ?");
string Age = Console.ReadLine();
Console.WriteLine("Your sex is (m/w)?");
char sex = char.Parse(Console.ReadLine());
Console.WriteLine("Your PESEL number is?");
long PESEL = long.Parse(Console.ReadLine());
Console.WriteLine("Your personal worker number is ?");
int PWN = int.Parse(Console.ReadLine()); //PWN === Personal Worker No

// Zadanie 2

char x = 'A', y = 'B', z = 'C';
Console.WriteLine($"{z}, {y}, {x}");


// Zadanie 3

Console.Write("Please give me length of sides of the rectangle (a,b) \r\na= ");
double a2 = double.Parse(Console.ReadLine());
Console.Write("b= ");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(a2, 2) + Math.Pow(b2, 2)), 2));

// Zadanie 4

int a4=10;
string b4="Szkoła Dotneta";
double c4 = 10.5; 
