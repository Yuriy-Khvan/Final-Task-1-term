// программа из массива строк формирует массив из строк, длина которых меньше либо равна 3 символа

string[] array1 = new string[5] {"012", "hello", "45", "dim", "piece"};
string[] array2 = new string[array1.Length];
void LastArrayRes(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[i] = array1[i];
                }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
LastArrayRes(array1, array2);
PrintArray(array2);
