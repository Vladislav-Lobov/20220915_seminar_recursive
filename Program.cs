//Задача 63
//рекурсия от 0 до N

// int[] GetNextNumber(int number, int i=0, int[] array)
// {
//     if (i >= number)
//     {
//         return array;
//     }
//     array[i] = i;
//     GetNextNumber(number, i + 1, array);
//     return array;
// }


// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     };
// };




// Console.WriteLine("Введите число N ");
// bool isNumber = int.TryParse(Console.ReadLine(), out int number);

// if (isNumber == false || number < 1)
// {
//     Console.WriteLine("Неверный ввод");
//     return;
// };

// int[] newArray = new int[number];
// newArray = GetNextNumber(number, 5, newArray);
// PrintArr(newArray);

//Задача 65
//рекурсия от m до n

// int[] GetNextNumber(int m, int n, int i, int[] array)
// {
//     if (n - m <= i)
//     {
//         return array;
//     }
//     array[i] = i + m;
//     GetNextNumber(m, n, i + 1, array);
//     return array;
// }


// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     };
// };




// Console.WriteLine("Введите число m ");
// bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

// Console.WriteLine("Введите число n ");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

// if (isNumberM == false || m < 1 || isNumberN == false || n < 1)
// {
//     Console.WriteLine("Неверный ввод");
//     return;
// };

// int[] newArray = new int[n - m];
// newArray = GetNextNumber(m, n, 0, newArray);
// PrintArr(newArray);

//Задача 67
//возвращает сумму цифр числа на стринге

// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     };
// };

// int GetSumOfDigit(string number, int index=0, int summa=0)
// {
//     if (index == number.Length-1)
//     {
//         return summa += number[number.Length - 1]-'0';
//     }
//  //   summa = summa + number[index]-'0';
// // return GetSumOfDigit(number, index+1 ,summa+ (int)number[index+1]);
//     return  summa = summa + number[index]-'0' + GetSumOfDigit(number, index+1 , summa);
// }




// Console.WriteLine("Введите число n ");
// string number = Console.ReadLine();
// bool isNumberN = int.TryParse(number, out int n);

// if (isNumberN == false || n < 1)
// {
//     Console.WriteLine("Неверный ввод");
//     return;
// };
// Console.WriteLine($"Сумма цифр равна {GetSumOfDigit(number)}");


//Задача 67
//возвращает сумму цифр числа на интах

// int GetSum(int a, int res = 0)
// {
//     if (a != 0)
//     {
//         res += a % 10;
//         return GetSum(a / 10, res);
//     }
//     return res;
// }

//Задача 69
//возвести число A в B с помощью рекурсии

int GetPow(int a, int b, int res = 1, int i = 1)
{
    if (b < i)
    {
        return res;
    }
    res = res * a;
    return GetPow(a, b, res, i + 1);
}
Console.WriteLine("--> " + GetPow(2, 8));