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

////// TASK 12 //////
let ListTraversal list func init = 
    let rec ListTraversal_body list func init ind =
        match list with
        | [] -> init
        | h::t -> ListTraversal_body t func (func init (h,ind) ) (ind+1)
    ListTraversal_body list func init 0

let ListTraversalCond list cond func init init_ind =
    ListTraversal list (fun x y -> if cond x y then func x y else x) (init,init_ind)

let ListFind_byValue list cond init init_ind =
    ListTraversalCond list cond (fun x y -> y) init init_ind

let ListFindLastMax list =
    ListFind_byValue list (fun x y -> y >= x) list.Head 0

let ListQuantity_afterLastMax list =
    let maxInd = snd (ListFindLastMax list)
    ListTraversalCond list (fun x y -> snd y > maxInd) (fun x y -> (fst x + 1, 0) ) 0 0