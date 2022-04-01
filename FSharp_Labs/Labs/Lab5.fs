module Lab5
open System
open Lab5_Functions

let task_11 =
    Console.WriteLine "Задача 11"
    Console.WriteLine "Назовите ваш любимый язык программирования:"
    Console.ReadLine() |> question |> Console.WriteLine
    Console.WriteLine()