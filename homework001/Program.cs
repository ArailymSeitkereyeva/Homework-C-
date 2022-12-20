// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int size = 3;
int[] numbs = new int[size];
int count = 0;
while(count < size)
{
    Console.WriteLine($"Введите {1+count} число:");
    numbs[count] = Convert.ToInt32(Console.ReadLine());
    count++;
}
count = 1;
int max = numbs[0];
while(count < size)
{
if(numbs[count]>max)
max = numbs[count];
count++;
}
Console.WriteLine($"Максимальное число: "+max);