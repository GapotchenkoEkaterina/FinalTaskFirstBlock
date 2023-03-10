// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = GetArray();
Console.Write("Введите ограничение по количестве символов: ");
int n = int.Parse (Console.ReadLine()!);
string[] result = FindresArray(array, n);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

// Метод формирования массива из введеных данных пользователем

string[] GetArray() {
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

// Метод формирования массива из введеных данных пользователем ограниченный количеством знаков.
 
string[] FindresArray(string[] Arrayin, int n) {
    string[] Arrayout = new string[Count(Arrayin, n)];
 
    for(int i = 0, j = 0; i < Arrayin.Length; i++) {
        if(Arrayin[i].Length <= n) {
            Arrayout[j] = Arrayin[i];
            j++;
        }
    }
 
    return Arrayout;
}

// Метод нахождения количества значений удовлетворяещих ограничению по количеству знаков
 
int Count(string[] Arrayin, int n) {
    int count = 0;
 
    for(int i = 0; i < Arrayin.Length; i++) {
        if(Arrayin[i].Length <= n) {
            count++;
        }
    }
 
    return count;
}
