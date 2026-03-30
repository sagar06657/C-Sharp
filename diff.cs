Console.WriteLine("Enter 1st Number:");
string a = Console.ReadLine();
int num1 = int.Parse(a);

Console.WriteLine("Enter 2nd Number:");
int num2 = int.Parse(Console.ReadLine());

int sum = num1 - num2;
Console.WriteLine("The Difference of {0} & {1} is {2}",num1,num2,sum);