//Задайте массив из 10 элементов, заполненный числами из
//промежутка [-10, 10]. Замените отрицательные элементы на
//положительные, а положительные на отрицательные.



int[] array = { 1, -2, 3, -4, 5, -6, 7, -8, 9, 0 };
int i = 0;

while (i<array.Length)
{
    if (array[i]<0)
    {
        array[i]=array[i]*(-1);
    }
    else array[i]=array[i]*(-1);
    i++;

}
Console.WriteLine("[" + string.Join(" ", array) + "]");

//Console.Write (array[1] + " " + array[2] + " ");


//var str = string.Join(" ", array);
//Console.WriteLine(str);