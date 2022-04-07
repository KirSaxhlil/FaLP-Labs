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

let task_12() =
    Console.WriteLine "Задача 6.12"
    let list = [3;6;26;8;0;2]
    Console.WriteLine "Исходный список: "
    outputList list
    Console.Write "Кол-во элементов после последнего максимального элемента: "
    Console.WriteLine (fst (ListQuantity_afterLastMax list))
    Console.WriteLine()

let task_13() =
    Console.WriteLine "Задача 6.13"
    let list = [3;6;26;8;0;2]
    Console.WriteLine "Исходный список: "
    outputList list
    Console.Write "Индекс минимального элемента: "
    Console.WriteLine (snd (ListFindMin list))
    Console.WriteLine()

let task_14() =
    Console.WriteLine "Задача 6.14"
    let list = [3;6;26;8;0;2]
    Console.WriteLine "Исходный список: "
    outputList list
    Console.WriteLine "Итоговый список: "
    outputList (ListMovePreMin list)
    Console.WriteLine()