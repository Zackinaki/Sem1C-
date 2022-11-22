Console.Clear();
Console.Write("Vvedite chislo: ");

//int n = int.Parse(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
//Console.Write(Convert.ToInt32(n > 10));

if (n % 2 == 0 && n % 3 ==0)
    Console.Write("yes");
else
    Console.Write("no");


