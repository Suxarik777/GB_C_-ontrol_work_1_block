// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] 
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”] 
// [“Russia”, “Denmark”, “Kazan”] → []


int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    if(number > 0) return number;
    else return InputNumber("Упс! Вы что то не то ввели! Укажите число больше 0: ");
}

string InputString(string text)
{
    Console.Write(text);
    string word = Console.ReadLine();
    return word;
}

string[] FillArrayString(int length)
{
    string[] arrayString = new string[length];
    for(int i = 0; i < arrayString.Length; i++)
    {
        arrayString[i] = InputString($"Введите элемент №{i+1}: ");
    }
    return arrayString;
}

void PrintArray(string[] array)
{
    foreach(var element in array)
        Console.Write(element + " ");
    Console.WriteLine();
}

string[]? ArrayFilter(string[] array)
{
    string[] helpArray = new string?[array.Length];
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= 3) helpArray[i] = array[i];

    int numberEmptyElements = 0;
    for(int i = 0; i < helpArray.Length; i++) //сколько пустых ячеек?
        if(helpArray[i] == null) numberEmptyElements++;   

    string[] newArray = new string[helpArray.Length - numberEmptyElements];
    for(int i = 0; i < newArray.Length; i++)
        newArray[i] = helpArray[i];

    if(numberEmptyElements == helpArray.Length) return null;
    else return  newArray;
}


int arrayLength = InputNumber("Сколько элементов вы хотите задать?: ");
string[] arrayWord = FillArrayString(arrayLength);

Console.WriteLine("Исходный массив данных: ");
PrintArray(arrayWord);

string[]? resultArrayWord = ArrayFilter(arrayWord);

if(resultArrayWord == null) 
    Console.WriteLine("Все элементы имеют больше 3 символов");
else
{
    Console.WriteLine("Результат работы программы: ");
    PrintArray(resultArrayWord);
}