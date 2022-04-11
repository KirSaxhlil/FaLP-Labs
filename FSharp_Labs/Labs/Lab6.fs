﻿module Lab6
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

let task_15() =
    Console.WriteLine "Задача 6.15"
    let list = [3;6;26;8;0;2]
    Console.WriteLine "Исходный список: "
    outputList list
    let index = 3
    Console.WriteLine ("Является ли элемент под номером " + index.ToString() + " локальным минимумом: " + (ListLocalMin list index).ToString())
    Console.WriteLine()

let task_16() =
    Console.WriteLine "Задача 6.16"
    let list = [3;6;26;8;0;2]
    Console.WriteLine "Исходный список: "
    outputList list
    let a = 2
    let b = 4
    Console.WriteLine ("Список в интервале [" + a.ToString() + ";" + b.ToString() + "]: ")
    outputList (ListGetPart list a b)
    Console.WriteLine ("Максимум в интервале [" + a.ToString() + ";" + b.ToString() + "]: " + (fst (ListFindMax_inPart list a b)).ToString())
    Console.WriteLine()