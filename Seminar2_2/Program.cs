// Напишите программу, которая будет принимать 
//на вход два числа и выводить, является ли второе число кратным первому.
//Если второе число не кратно числу первому, то програм
Console.WriteLine("Введите первое число: ");
number1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
number2 = Console.ReadLine();
if (number2 % number1 == 0)
{
Console.WriteLine("Число {number2} кратно числу {number1}");
}
else Console.WriteLine("Число {number2} не кратно числу {number1}");
