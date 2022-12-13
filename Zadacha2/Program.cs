/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Enter number 1:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter index 1:");
int index= Convert.ToInt32(Console.ReadLine());

double pow = Math.Pow (10, index);

if(num < pow)
{
    Console.WriteLine($"Цифра меньше индекса");
}
else{
    int tmp = num;
    while(tmp>pow)
    {
        tmp/=10;
    }
    int result = tmp %10;
    Console.WriteLine($"Цифра под индексом {index} числа {num} -> {result}");
}