// Домашнее задание к первому семинару.

//***************************************** Задание №1
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write ("Введите первое число - ");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.Write ("Введите первое число - ");
// int num2=Convert.ToInt32(Console.ReadLine());

// if (num1>num2) Console.WriteLine ($"Первое число {num1} больше второго {num2}");
// else Console.WriteLine($"Первое число {num1} меньше второго {num2}");


//**************************************Задание 2
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write ("Введите первое число - ");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.Write ("Введите первое число - ");
// int num2=Convert.ToInt32(Console.ReadLine());

// Console.Write ("Введите третье число - ");
// int num3=Convert.ToInt32(Console.ReadLine());

// int max = num1;
// if (max<num2) max=num2;
// if (max<num3) max=num3;

// Console.WriteLine($"Максимальное число - {max}");


//*************************************Задание 3
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write ("Введите число для проверки четности - ");
// int num=Convert.ToInt32(Console.ReadLine());
// if (num%2!=0 ) Console.WriteLine($"{num} - нечетное число");
// if (num%2==0 ) Console.WriteLine($"{num} - четное число");


//*************************************Задание 4
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Введите число - ");
int num=Convert.ToInt32(Console.ReadLine());
int current;
if (num%2>0)    // Проверка четности входного числа и установка начального четного числа
    { 
        if (num>0) current=num-1; // Проверка знака входного числа и установка начального четного числа 
        else current=num+1;
    }
else current=num;
while (Math.Abs(current)>1)
    {
    Console.Write(current +" ");
    if (num>0) current=current-2;
    else current=current+2;
    }







//             // Типы данных
//  int num1 = 1; // целые числа
//  int num2 = 1; // 
// double num2 = 2.34;         //числа с плавающей точкой
 //string world = "Привет, введите вес";    // Строка
 //bool check = true;          // Логигческий

 // ЗАдача квадрата
// Console.Write ("Введите первое число - ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write ("Введите второе число - ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int qvad= num2*num2;
// if (num1==qvad) 
//     {Console.WriteLine("Yes");}
// else 
//     {
//         Console.WriteLine("No");
//     }

// // *******************ЗАДАНИЕ "2"

// Console.WriteLine ("Введите число положительное  -");
// int number = Convert.ToInt32( Console.ReadLine ());
// int current = -number;
// while (current<=number)
//     {
//         Console.Write(current +" ");
//         current++;
//     }