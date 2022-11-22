// task 5
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = n * (-1);
while (i <= n)
{
    Console.Write($"{i} "); // !!!
    i = i + 1; // i++, i += 1
}

// // task 5
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = (-1) * n; i <= n; i++)
//     Console.Write(i + " ");

