
// Напишите программу, которая  из имеющего массива строк формирует массив из строк, 
// длина которых меньше либо равно 3 символа. 

// пишем метод по вводу элементов массива   
Console.Write("Введите количество элементов массива:");
int m = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[m];
//создаем функцию переборки массива которая не чего не вращает
void array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine();
    }
}
// Пишем функцию которая принемает элементы проверяет их и возвращает заданный результат 
string[] Elements(string[] stringArray)
{
    int m = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            m++;
    }
    string[] rez = new string[m];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            rez[j] = stringArray[i];
            j++;
        }
    }
    return rez;
}
// функция которая выводит результат 
void printResult(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"‘{stringArray[i]}’, ");
    }
    Console.Write("]");
}
array(stringArray);
printResult(Elements(stringArray));