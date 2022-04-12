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
    Console.WriteLine()

let task_17() =
    let list1 = [3;1;26;8;1;26;1;3]
    let list2 = [3;7;24;8;1;26;3]
    let l1 = [0 .. (list1.Length - 1)]
    let l2 = [0 .. (list2.Length - 1)]
    let subsequer list_len=
        let rec subwequer_body start finish superList =
            if start = finish then
                if finish = (list_len - 1) then superList @ [[start]]
                else subwequer_body start (finish + 1) superList @ [[start]]
            else if finish = (list_len - 1) then subwequer_body (start+1) (start) superList @ [[start .. finish]]
                 else subwequer_body start (finish + 1) superList @ [[start .. finish]]
        subwequer_body 0 0 [[]]


            //[start .. finish]
    let subseqs1 = subsequer (list1.Length)
    let subseqs2 = subsequer (list2.Length)

    let morph ind_list list =
        let rec morph_body (ind_list:int list list) (list:int list) ind res =
            if ind = (ind_list.Length) then res
            else morph_body ind_list list (ind + 1) (res @ [List.collect (fun i -> [list.Item i]) (ind_list.Item ind)])
        morph_body ind_list list 0 [[]]

    let ss1 = morph subseqs1 list1
    let ss2 = morph subseqs2 list2

    let FindMaxSubseq list1 list2 =
        let rec FindMaxSubseq_body (list1:int list list) (list2:int list list) iter (res:int list) =
            if iter = list1.Length then res
            else
                let tmp1 = List.tryFind (fun x -> list1.Item iter = x) list2
                let tmp =
                    if tmp1.IsNone then []
                    else tmp1.Value
                if tmp.Length > res.Length then FindMaxSubseq_body list1 list2 (iter+1) tmp
                else FindMaxSubseq_body list1 list2 (iter+1) res
        FindMaxSubseq_body list1 list2 0 []

    let maxss = FindMaxSubseq ss1 ss2
    Lab6_Functions.outputList maxss
    //List.
    //let bruh = List.collect (fun x -> [List.collect (fun y -> [x .. y] ) l1 ] ) l1
    //let bruh = List.collect (fun x -> [1 .. x] ) l1
    //let subseqs = List.permute (fun i -> list.Item i) l1
    //List.iter (Lab6_Functions.outputList) subseqs1
    //Lab6_Functions.outputList (subseqs.Item 3)