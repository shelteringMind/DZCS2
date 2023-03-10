//*/
// Задача 10
Console.Write("Введите число c тремя и более разрядами: ");
string num = Console.ReadLine()!;
int number = int.Parse(num);
if (num.Length >= 3 && number>=0) {
    Console.WriteLine($"{num}->{num[1]}");
} else if(num.Length >= 4 && number < 0) {
    Console.Write($"{num}->{num[2]}");
} else {
    Console.Write("Введено неверное число!");
}
//*/