module Lab5
open System
open Lab5_Functions

// func_name : unit : runs all (func : unit) in module in order >:(((((
// func_name(): unit -> unit !

let task_11() =
    Console.WriteLine "Задача 11"
    Console.WriteLine "Назовите ваш любимый язык программирования:"
    Console.ReadLine() |> question |> Console.WriteLine
    Console.WriteLine()

let task_12() = 
    Console.WriteLine "Задача 12"
    Console.WriteLine "Назовите ваш любимый язык программирования:"
    Console.WriteLine (question (Console.ReadLine())) // Carring
    Console.WriteLine()
    Console.WriteLine "Назовите ваш любимый язык программирования:"
    (Console.ReadLine >> question >> Console.WriteLine)() // Superposition
    Console.WriteLine()

let task_13() = 
    let number = 386
    Console.WriteLine "Задача 13"
    Console.WriteLine ("Исходное число: " + Convert.ToString number)
    Console.Write "Произведение цифр числа, рекусрия вверх: "
    Console.WriteLine (DigitMultUp number)
    Console.Write "Произведение цифр числа, хвостовая рекурсия: "
    Console.WriteLine (DigitMultDown number)
    Console.Write "Максимальная цифра числа, рекурсия вверх: "
    Console.WriteLine (MaxDigitUp number)
    Console.Write "Максимальная цифра числа, хвостовая рекурсия: "
    Console.WriteLine (MaxDigitDown number)
    Console.Write "Минимальная цифра числа, рекурсия вверх: "
    Console.WriteLine (MinDigitUp number)
    Console.Write "Минимальная цифра числа, хвостовая рекурсия: "
    Console.WriteLine (MinDigitDown number)
    Console.WriteLine()