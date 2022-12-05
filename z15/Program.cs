// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.WriteLine($"Ввести день от 1 до 7");
int num = int.Parse(Console.ReadLine());
 
 if (num >1  & num < 7)
 
 if (num == 6)
 {
    Console.WriteLine($"{num}->  вых");
 } 
 if (num == 7)
 {
    Console.WriteLine($"{num} ->  вых");
 } 

 else
 {
    Console.WriteLine($"{num} ->  раб");
 }
