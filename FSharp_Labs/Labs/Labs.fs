module Labs

let lab5 task =
    match task with
    | 11 -> Lab5.task_11()
    | 12 -> Lab5.task_12()
    | 13 -> Lab5.task_13()
    | 14 -> Lab5.task_14()
    | 15 -> Lab5.task_15()
    | 16 -> Lab5.task_16()
    | 17 -> Lab5.task_17()
    | 18 | 19 -> Lab5.task_19()
    | 20 -> Lab5.task_20()
    | _ -> ()

let lab6 task =
    match task with
    | 11 -> Lab6.task_11()
    | 12 -> Lab6.task_12()
    | 13 -> Lab6.task_13()
    | 14 -> Lab6.task_14()
    | 15 -> Lab6.task_15()
    | 16 -> Lab6.task_16()
    | 17 -> Lab6.task_17()
    | 18 -> Lab6.task_18()
    | 19 -> Lab6.task_19()
    | 20 -> Lab6.task_20()
    | _ -> ()

let lab7 task =
    match task with
    | 11 -> Lab7.task_11()
    | 12 -> Lab7.task_12()
    | 13 -> Lab7.task_13()
    | 14 -> Lab7.task_14()
    | 15 -> Lab7.task_15()
    | 16 -> Lab7.task_16()
    | 17 -> Lab7.task_17()
    | 18 -> Lab7.task_18()
    | 19 -> Lab7.task_19()
    | _ -> ()

let lab_chooser lab task = 
    match lab with
    | 5 -> lab5 task
    | 6 -> lab6 task
    | 7 -> lab7 task
    | _ -> ()