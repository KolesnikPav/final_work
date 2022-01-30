﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекоменлуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

// Начальный массив
string[] array = { "eufh49", "2f4", "23r5", "p4", "403kg", "4))" };

// Формируем новый массив согласно условию
string[] new_array = Array.FindAll(array, a => a.Length <= 3);
foreach (var a in new_array) ;

// Выводим в консоль оба массива для проверки правильности решения
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", new_array));