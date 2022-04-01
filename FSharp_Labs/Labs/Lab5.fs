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