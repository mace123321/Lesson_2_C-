Console.Write(" Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string Numbertxt = Convert.ToString(Number);
if (Numbertxt.Length > 2){
  Console.WriteLine(" третья цифра : " + Numbertxt[2]);
}
else {
  Console.WriteLine(" третьей цифры нет :( ");
}