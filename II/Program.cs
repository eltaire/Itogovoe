//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
		
string[] array = AskArray();
string[] result = FindArray(array, 3);
Console.WriteLine($"Во введенном Вами массиве [{string.Join(", ", array)}] условию удовлетворяют: [{string.Join(", ", result)}]");

string[] FindArray(string[] input, int n) {
    string[] output = new string[CountProcedure(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountProcedure(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

string[] AskArray() {
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

