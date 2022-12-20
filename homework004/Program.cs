// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все четные числа:");
if (num==0) Console.Write($"0");
else
{
     int result = 0;
     if (num >0)
     {   
        while(result <= num-2)
        {
            result = result+2;
            Console.Write($"{result} ");
        }
     }
     else
     {
        num=-1*num;
        while(result <= num-2)
        {
            result = result+2;
            Console.Write($"{-1*result} ");
        }
     }
}
