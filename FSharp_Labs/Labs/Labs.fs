module Labs
open Lab5
open Lab6

let lab5 task =
    match task with
    | 11 -> task_11()
    | 12 -> task_12()
    | 13 -> task_13()
    | 14 -> task_14()
    | 15 -> task_15()
    | 16 -> task_16()
    | 17 -> task_17()
    | 18 | 19 -> task_19()
    | 20 -> task_20()
    | _ -> ()

let lab6 task =
    match task with
    | _ -> ()

let lab_chooser lab task = 
    match lab with
    | 5 -> lab5 task
    | 6 -> lab6 task
    | _ -> ()