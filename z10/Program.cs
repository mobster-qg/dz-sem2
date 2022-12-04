//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

 Console.Clear();
 Console.WriteLine($"Ввести число ");
int num = int.Parse(Console.ReadLine());

int result = (  (num % 100) & (num /= 10) ); 

if (num > 0) num = num;

while (num > 100) num /= 10;
if (num > 10)  num= num;
while (num > 10) num %=10;


Console.WriteLine($"{num} -> {num%10} Второе число");
