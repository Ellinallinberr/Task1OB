//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Введите строки через запятую или пробел:");
string input = Console.ReadLine()?? ",";

string[] strings = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

string shortString = "[";

bool addComma = false;

for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        if (addComma)
        {
            shortString += ", ";
        }

        shortString += strings[i];
        addComma = true;
    }
}

shortString += "]";
Console.WriteLine("Результат:");
Console.WriteLine(shortString);
