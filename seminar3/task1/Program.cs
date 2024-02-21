//Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве. Программа
//должна выдать ответ: Да/Нет.


int[] array = { 3, 3, 2, 19, 4 };
int a = 4;
//int i = 0;
int yes = 0;

foreach (int i in array)
{
   if (i == a)
    {
        yes = 1;
    }
    }
    if (yes == 1)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}

//while (i < array.Length)
//{
//    if (array[i] == a)
//    {
//        yes = 1;
//    }
//    i++;
//}
//if (yes == 1)
//{
//    Console.Write("да");
//}
//else
//{
//    Console.Write("нет");
//}