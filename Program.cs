// Написать программу, которая
// 1. из имеющегося массива строк формирует новый массив 
// 2. из строк длина которых меньше, либо равна 3 символам
// 3. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма
// 4.При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// ["Hello”, "2”, "world”, ":-)”] → ["2”, ":-)”]
// ["1234”, "1567”, "-2”, "computer science”] → ["-2”]
// ["Russia”, "Denmark”, "Kazan”] → [].
string[] NoMoreThreeSymbols(string[] massiv, string[] massivRedact)
{
    int i = 0;
    int y = 0;
    while (i < massiv.Length)
    {
        if (massiv[i].Length < 4)
        {
            massivRedact[y] = massiv[i];
            y++;
        }
        i++;
    }
    return massivRedact;
}
int MakeSizeForArray(string[] massiv)
{
    int i = 0;
    int z = 0;
    while (i < massiv.Length)
    {
        if (massiv[i].Length < 4)
        {
            z++;
        }
        i++;
    }
    return z;
}
void PrintArray (string[] massivFinal)
{
int r = 0;
while (r < massivFinal.Length)
{
    if (r<massivFinal.Length -1) 
    {
    Console.Write(massivFinal[r]);
    Console.Write(",");
    }
    else Console.Write(massivFinal[r]);
    r++;
}
}
string[] array = { "Russia", "Denmark", "Kazan", "Hello", "0", "456",  "2", ":-)5", "-2" };
int x = MakeSizeForArray(array);
string[] arrayRedact = new string[x];
string[] arrayFinal = NoMoreThreeSymbols(array, arrayRedact);
PrintArray(arrayFinal);