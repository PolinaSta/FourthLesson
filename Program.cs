// 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// int sumToNum(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// Console.WriteLine("введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма чисел - " + sumToNum(number));

// 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// int countNum(int num){
//     int count = 0;
//     while (num>0)
// {
//     num = num / 10;
//     count++;
// }
//     return(count);
// }
// int numbers = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(countNum(numbers));

// 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//  int multiplayToNum(int num)
// {
//     int multiplay = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         multiplay *= i;
//     }
//     return multiplay;
// }
// Console.WriteLine("введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Произведение чисел - " + multiplayToNum(number));

// 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Метод.Создание массива рандомных чисел, где size-кол-во элементов в массива.в next min и max значения (max НЕ ВКЛЮЧИТЕЛЬНО ВСЕГДА))
// int[] CreatRandomArray(int size)
// {
//     int[] array = new int [size];
//     for(int i = 0; i<size; i++){
//         array[i] = new Random().Next(0,2);
//     }
//     return array;
// }

// Метод.Массив через ввод данных.
// int[] CreatArray(int size)
// {
//     int[] array = new int [size];
//     for(int i = 0; i<size; i++)
//     {
//         Console.Write("Ввод " + i + " Элемент");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// Метод. Для вывода массива на экран. Рандом тоже можно применить сюда.
// void ShowArray(int[] array) 
// {
//     for(int i = 0; i<array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int [] myRandomArray = CreatRandomArray(6);
// ShowArray(myRandomArray);
// Console.WriteLine();
// int[] myArray = CreatArray(6);
// ShowArray(myArray);

