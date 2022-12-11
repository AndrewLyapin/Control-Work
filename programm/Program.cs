/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
ПРи решении не рекомендуется пользоваться коллекциями, лучше обойтись массивами. */


//Посчитаем кол-во элементов каждого элемента в массиве строк
int CountSymbolsInArray(string[] arrayOfString)
{
    int lenArray = arrayOfString.Length;
    int count = 0;
    int i = 0;

    while(i < lenArray)
    {
        if (arrayOfString[i].Length <= 3)
        {
            count++;
            i++;
            
        }
        else
        {
            i++;
        }
    }
    return count;
} 


//Создаем новый массив, который будет содержать элементы длиной максимум 3 символа
string[] CreateArray3symbOnly(string[] arrayOfString, int count)
{
    string[] arrayOfMax3Symb = new string[count];
    int lenArray = arrayOfString.Length;
    int i = 0;
    int j = 0;
    while(i < lenArray)
    {
        if (arrayOfString[i].Length <= 3)
        {
            arrayOfMax3Symb[j] = arrayOfString[i];
            i++;
            j++;
        }
        else
        {
            i++;
        }
    }
    return arrayOfMax3Symb;
}


//Вернем в консоль массив строк
void PrintArray(string[] arrayOfString)
{
   Console.WriteLine("[{0}]", string.Join(", ", arrayOfString));
}


string[] arrayOfString = {"hello", "2", "world", ":-)"};


int count = CountSymbolsInArray(arrayOfString);
PrintArray(arrayOfString);
Console.Write($"В этом массиве {count} элементов длинной в <=3 символов  ");
string[] arrayOfMax3Symb =  CreateArray3symbOnly(arrayOfString, count);
PrintArray(arrayOfMax3Symb);