module Lab7
open Lab7_Functions
open System

let task_11() =
    Console.WriteLine "Задача 7.11"
    let list = [3;6;26;8;0;26;2]
    Console.WriteLine "Исходный список: "
    Lab6_Functions.outputList list
    let max = List.max list
    let max_ind = List.findIndexBack (fun x -> x = max) list
    Console.WriteLine ("Количество элементов после последнего максимального: " + ((List.skip (max_ind+1) list).Length).ToString())
    Console.WriteLine()

let task_12() =
    Console.WriteLine "Задача 7.12"
    let list = [3;3;3;8;3;3]
    Console.WriteLine "Исходный список: "
    Lab6_Functions.outputList list
    let uniq = 
        let a = List.head list
        let reducedList = List.filter (fun x -> x <> a) list
        if reducedList.Length = 1 then reducedList.Head
        else a
    Console.WriteLine ("Отличающийся элемент: " + (uniq).ToString())
    Console.WriteLine()

let task_13() =
    Console.WriteLine "Задача 7.13"
    let list = [3;6;26;8;0;26;2]
    Console.WriteLine "Исходный список: "
    Lab6_Functions.outputList list
    let max = List.max list
    let max_ind = List.findIndex (fun x -> x = max) list
    Console.WriteLine ("Количество элементов после первого максимального: " + ((List.skip (max_ind+1) list).Length).ToString())
    Console.WriteLine()

let task_14() =
    Console.WriteLine "Задача 7.14"
    let list = [3;6;26;8;1;26;2]
    Console.WriteLine "Исходный список: "
    Lab6_Functions.outputList list
    let newList = List.filter (fun x -> x % 2 = 0) list
    Console.WriteLine ("Количество четных элементов: " + (newList.Length).ToString())
    Console.WriteLine()

let task_15() =
    Console.WriteLine "Задача 7.15"
    let list = [3;6;26;8;1;26;2]
    Console.WriteLine "Исходный список: "
    Lab6_Functions.outputList list
    let average = List.averageBy (fun (x:int) -> Convert.ToDouble (abs x)) list
    Console.WriteLine ("Среднее арифметическое модулей элементов: " + (average).ToString())
    Console.WriteLine()

let task_16() =
    Console.WriteLine "Задача 7.16"
    let list = [3;1;26;8;1;26;1;3]
    Console.Write "Исходный список: "
    Lab6_Functions.outputList list
    let L1 = List.distinct list
    let L2 = List.collect (fun x -> [(List.where (fun y -> x = y) list).Length]) L1
    Console.Write "Список L1: "
    Lab6_Functions.outputList L1
    Console.Write "Список L2: "
    Lab6_Functions.outputList L2
    //Console.WriteLine ("Среднее арифметическое модулей элементов: " + (average).ToString())
    Console.WriteLine()