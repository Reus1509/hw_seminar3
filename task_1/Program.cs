// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
double len = Math.Floor(Math.Log10(number) + 1);

if(len < 5 || len > 5){
    Console.WriteLine($"Число {number} содержит {len} символов а нужно 5.");
}
else {
    int first_symbol = number / 10000 % 10;
    int second_symbol = number / 1000 % 10;
    int forth_symbol = number / 10 % 10;
    int fifth_symbol = number % 10;
    if(first_symbol == fifth_symbol && second_symbol == forth_symbol)
    {
        Console.WriteLine($"Число {number} является палиндромом.");
    }
    else{
        Console.WriteLine($"Число {number} не является палиндромом.");
    }
}