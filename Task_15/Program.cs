Console.WriteLine(" Какой сегодня день недели по счету? ");
int Date = int.Parse(Console.ReadLine());
if (Date < 6)
{
    Console.WriteLine(" Сегодня будний день :( ");
}
if (Date >= 6)
{
    Console.WriteLine(" Ура!!! Сегодня выходой :) ");
}
