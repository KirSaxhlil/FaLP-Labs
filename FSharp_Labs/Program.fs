open System
open Labs

[<EntryPoint>]
let Main argv =
    Console.WriteLine "Введите номер задачи: "
    let input = Console.ReadLine()
    let lab = input.Split(".")[0] |> Int32.Parse
    let task = input.Split(".")[1] |> Int32.Parse
    lab_chooser lab task
    Console.ReadLine()
    0