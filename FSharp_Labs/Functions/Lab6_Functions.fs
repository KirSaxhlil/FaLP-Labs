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

////// Variant 1 //////
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
    ListFind_byValue list (fun x y -> fst y >= fst x) list.Head 0

let ListQuantity_afterLastMax list =
    let maxInd = snd (ListFindLastMax list)
    ListTraversalCond list (fun x y -> snd y > maxInd) (fun x y -> (fst x + 1, 0) ) 0 0

////// TASK 13 //////
let ListFindMin list =
    ListFind_byValue list (fun x y -> (fst y) < (fst x)) list.Head 0

////// TASK 14 //////
let ListMovePreMin list =
    let rec ListMovePreMin_body list min =
        match list with
        | h::t -> if h <> min then ListMovePreMin_body (t @ [h]) ( fst (ListFindMin t))
                  else list
    ListMovePreMin_body list ( fst (ListFindMin list))

////// TASK 15 //////
let ListGetElem list index =
    ListTraversalCond list (fun x y -> snd y = index) (fun x y -> y) 0 -1

let ListLocalMin list index =
    let a = ListGetElem list (index-1)
    let b = ListGetElem list index
    let c = ListGetElem list (index+1)
    if snd a <> -1 && snd c <> -1 then
        if fst a >= fst b && fst c >= fst b then true
        else false
    else if snd a = -1 then
        if fst b <= fst c then true
        else false
    else if snd c = -1 then
        if fst a >= fst b then true
        else false
    else true

////// TASK 16 //////
let ListGetPart list a b =
    let rec ListGetPart_body list a b iter result =
        match list with
        | [] -> result
        | h::t -> if iter >= a && iter <= b then ListGetPart_body t a b (iter+1) (result @ [h])
                  else ListGetPart_body t a b (iter+1) result
    ListGetPart_body list a b 0 []

let ListFindMax_inPart list a b =
    let partList = ListGetPart list a b
    ListFindLastMax partList

////// TASK 17 //////
let ListFindFirstMax list =
    ListFind_byValue list (fun x y -> fst y > fst x) list.Head 0

////// TASK 18 //////
let ListIndexes list =
    let rec ListIndexes_body list iter result =
        match list with
        | [] -> result
        | h::[] -> result
        | h::a::t -> if a < h then ListIndexes_body (a::t) (iter+1) (result @ [iter])
                     else ListIndexes_body (a::t) (iter+1) result
    ListIndexes_body list 1 []

let ListLength list = 
    ListTraversal list (fun x y -> x + 1) 0

////// TASK 19 //////
let ListQuantity list cond =
    fst (ListTraversalCond list cond (fun x y -> (fst x + 1,0)) 0 0)

let ListMinQuantity list = 
    let min = ListFindMin list
    ListQuantity list (fun x y -> fst y = fst min)

////// TASK 20 //////
let ListFreq list value =
    ListQuantity list (fun x y -> fst y = value)

let ListDel_byCond list cond = 
    let rec ListDel_byCond_body list cond result =
        match list with
        | [] -> result
        | h::t -> if cond h then ListDel_byCond_body t cond result
                  else ListDel_byCond_body t cond (result @ [h])
    ListDel_byCond_body list cond []

let ListDel_byValue list value =
    ListDel_byCond list (fun x -> x = value)

let QuadroList list =
    let rec QuadroList_body body_list result =
        match body_list with
        | [] -> result
        | h::t -> if h >= 0 && h < 100 && (ListFreq list h) > 2 then QuadroList_body (ListDel_byValue t h) (result @ [h*h])
                  else QuadroList_body (ListDel_byValue t h) result
    QuadroList_body list []