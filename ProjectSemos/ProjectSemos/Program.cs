// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vnesi broj od tastatura:");
//int number = int.Parse(Console.ReadLine());
//Console.WriteLine(number + 2);
int j, sum = 0;
Console.Write("The first 10 natural number are :\n");
for (j = 1; j <= 10; j++)
{
    sum = sum + j;
    Console.Write("{0} ", j);
}
Console.Write("\nThe Sum is : {0}\n", sum);