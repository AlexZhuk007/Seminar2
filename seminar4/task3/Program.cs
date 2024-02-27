// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем. 
Console.Clear();
int[] CreateRandomArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int max = 9;
int min = 0;
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());



int PlaceNumber(int[] array) //Разряд числа в десятках
{
    long raz = 1;
    foreach (int item in array)
    {
        raz = raz * 10;
    }
    raz = raz/10;
    return raz;
}

int IntegerDigit(int [] array, long raz)
{
int dig = 0;
for (int i = 0; i < size; i++)
{
 dig = dig + array[i]*raz;
 raz=raz/10;   
}
return dig;
}

void ShowFinalDigit(int dig)
{
    Console.WriteLine("-+-" + dig + "-+-");
}

void ShowIntegerDigit(long raz)
{
    Console.WriteLine("--" + raz + "--");
}

void ShowArray(int [] array){
    foreach (int item in array)
    {
        Console.Write($"{item}, ");
    }
}

int[] array = CreateRandomArray(min, max, size);
long raz = PlaceNumber(array);
int dig = IntegerDigit(array, raz);
ShowArray(array);
ShowIntegerDigit(raz);
ShowFinalDigit(dig);