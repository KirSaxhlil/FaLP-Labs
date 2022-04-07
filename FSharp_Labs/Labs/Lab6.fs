module Lab6
open Lab6_Functions
open System

let task_11() = 
    Console.WriteLine "Задача 6.11"
    Console.WriteLine "Введите список: "
    let list = inputList()
    Console.WriteLine "Результат: "
    outputList (triple_lister list (fun a b c -> a + b + c))
    Console.WriteLine()