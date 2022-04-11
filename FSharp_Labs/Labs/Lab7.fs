module Lab7
open Lab7_Functions
open System

let task_11() =
    Console.WriteLine "Задача 7.11"
    let list = [3;6;26;8;0;2]
    Console.WriteLine "Исходный список: "
    Lab6_Functions.outputList list
    let max = List.max list
    let max_ind = List.findIndexBack (fun x -> x = max) list
    Console.WriteLine ("Количество элементов после последнего максимального: " + ((List.skip (max_ind+1) list).Length).ToString())
    Console.WriteLine()