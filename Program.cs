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

string[] InputArrayString(int length)
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


int arrayLength = InputNumber("Сколько элементов вы хотите задать?: ");
string[] arrayWord = InputArrayString(arrayLength);
PrintArray(arrayWord);