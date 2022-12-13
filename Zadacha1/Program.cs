/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Задача 13: Н */

Console.WriteLine("Enter number 1:");
int number=int.Parse(Console.ReadLine());

int num1 = number/100;
int num2 = (number - num1*100)/10;
int num3 = number - num1*100-num2*10;

int Result = num2;

    System.Console.Write(Result);