// Вид 1 Ничего не возвращают и не принимают

void Method1()
{
    System.Console.WriteLine("Автор ...");
}
// Method1();



// Вид 2 Ничего не возвращают, но могут принимать какие то аргументы

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
//Method2("текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "текст сообщения", count: 4);
//Method21(count: 4, msg: "текст сообщения");


// вид 3 Что то возвращают, но не принимают

int Method3()
{
    return DateTime.Now.Year;

}

// int year = Method3();
// System.Console.WriteLine(year);


// Вид 4 Что то принимают и что то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {

//         result = result + text;
//         i++;
//     }
//     return result;
// }


string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}


//string res = Method4(10, "z");
//System.Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    //  System.Console.WriteLine();
}



int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);


PrintArray(arr);