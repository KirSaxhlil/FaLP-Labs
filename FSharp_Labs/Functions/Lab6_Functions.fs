module Lab6_Functions
open System
////// Additional //////
let rec inputElems n = 
    if n=0 then []
    else
        (Console.ReadLine() |> Convert.ToInt32) :: inputElems (n-1)

let inputList() =
    inputElems (Console.ReadLine() |> Int32.Parse)

let rec outputList (list:int list) =
    match list with
    | [] -> Console.WriteLine()
    | h::t -> Console.Write h
              Console.Write " "
              outputList t

////// TASK 11 //////
let triple_lister list func = 
    let rec triple_lister_body list func res = 
        match list with
        | [] -> res
        | a::b::c::l -> triple_lister_body l func (res @ [func a b c])
        | a::b::[] -> triple_lister_body [] func (res @ [func a b 1])
        | a::[] -> triple_lister_body [] func (res @ [func a 1 1])
    triple_lister_body list func []