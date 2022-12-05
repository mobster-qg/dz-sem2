Console.Clear();
Console.WriteLine($"Ввести число ");
int num = int.Parse(Console.ReadLine());

int result = (num % 100); 

if (num > 0)num = num;
{
    Console.WriteLine($"{num} -> {num%10} Третье число");
}

while (num <100) 
{
    Console.WriteLine($"{num} -> {num <0}Числа нет");
  
  return;
}
