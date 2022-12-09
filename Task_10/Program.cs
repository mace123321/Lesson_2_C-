Console.Write("Введите любое число от 100 до 999:  ");
int number = Convert.ToInt32(Console.ReadLine());
int sum1 = number / 10;
int FinalSum = sum1 % 10;
Console.WriteLine($"{FinalSum}");
