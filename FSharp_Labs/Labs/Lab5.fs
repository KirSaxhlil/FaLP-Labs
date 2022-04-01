﻿module Lab5
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

let task_14() =
    let number = 543
    Console.WriteLine "Задача 14"
    Console.WriteLine ("Исходное число: " + Convert.ToString number)
    Console.Write "Сумма делителей числа: "
    Console.WriteLine (DividersTraversal number (fun x y -> x + y) 0)
    Console.Write "Произведение делителей числа: "
    Console.WriteLine (DividersTraversal number (fun x y -> x * y) 1)
    Console.Write "Максимальный из делителей числа: "
    Console.WriteLine (DividersTraversal number (fun x y -> if y <> number then // Excluding self number as maximal divider
                                                                if x > y then x
                                                                else y
                                                            else x) 0)
    Console.Write "Минимальный из делителей числа: "
    Console.WriteLine (DividersTraversal number (fun x y -> if y <> 1 then // Excluding 1 as minimal divider
                                                                if x < y then x
                                                                else y
                                                            else x) number)
    Console.WriteLine()