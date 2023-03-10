/*/
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

/*/
// Задача 13
Console.Write("Введите число: ");
string num = Console.ReadLine()!;
int number = int.Parse(num);
if (num.Length >= 3 && number>=0) {
    Console.WriteLine($"{num}->{num[2]}");
} else if(num.Length >= 4 && number < 0) {
    Console.Write($"{num}->{num[3]}");
} else {
    Console.Write("Третьей цифры нет!");
}
//*/

//*/
// Задача 15
Console.Write("Введите номер дня недели для проверки того,\nявляется ли он выходным: ");
int number = int.Parse(Console.ReadLine()!);
if (number>=1 && number<=7) {
    switch(number) {
        case 1 or 2 or 3 or 4 or 5:
        Console.Write("Нет, это будний день!");
        break;
        case 6 or 7:
        Console.Write("Да, этот день выходной!");
        break;
    }
} else {
    Console.Write("Такого дня недели не существует!");
}
//*/
