//Найдите произведения пар чисел в одномерном массиве. Парой
//считаем первый и последний элемент, второй и предпоследний и
//т.д. Результат запишите в новый массив.


int [] array = {1, 8, 6, 2, 8};
int i = 0;
int j = 1;
//int a = 0;
Console.Write ("[");
while (i < array.Length/2)
{
int [] array2 = {array[i]*array[array.Length-j]};
i++; 
j++;

Console.Write(" " + string.Join(" ", array2) + " "); 

}
Console.Write ("]");
