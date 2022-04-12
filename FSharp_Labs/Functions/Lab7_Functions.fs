module Lab7_Functions
open System
open System.Text.RegularExpressions

////// Variant 1 //////
// 
////// TASK 17 //////
let subsequer list_len=
    let rec subwequer_body start finish superList =
        if start = finish then
            if finish = (list_len - 1) then superList @ [[start]]
            else subwequer_body start (finish + 1) superList @ [[start]]
        else if finish = (list_len - 1) then subwequer_body (start+1) (start) superList @ [[start .. finish]]
             else subwequer_body start (finish + 1) superList @ [[start .. finish]]
    subwequer_body 0 0 [[]]

let morph ind_list list =
    let rec morph_body (ind_list:int list list) (list:int list) ind res =
        if ind = (ind_list.Length) then res
        else morph_body ind_list list (ind + 1) (res @ [List.collect (fun i -> [list.Item i]) (ind_list.Item ind)])
    morph_body ind_list list 0 [[]]

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

////// TASK 18 //////
let outputArray (array:'a[]) =
    let rec outputArray_body iter =
        if iter = array.Length then Console.WriteLine()
        else (array.GetValue iter) |> Console.Write
             Console.Write " "
             outputArray_body (iter+1)
    outputArray_body 0

////// TASK 19 //////
let Method_1 (stringe:String) =
    (String.filter (fun c -> (c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я')) stringe).Length

let Method_2 (stringe:String) =
    let stringe = String.filter (fun c -> c >= 'a' && c <= 'z') stringe
    let rec processing iter =
        if stringe.Length < 2 then true
        else if iter > stringe.Length/2 then true
             else if stringe[iter] <> stringe[stringe.Length-iter-1] then false
                  else processing (iter+1)
    processing 0

let Method_3 (stringe:String) =
    if Regex.IsMatch( stringe, @"[0-9][0-9].[0-9][0-9].[0-9][0-9][0-9][0-9]" ) then true
    else if Regex.IsMatch( stringe, @"[0-9][0-9].[0-9][0-9].[0-9][0-9]" ) then true
    else false

let Method_Chooser = function
    | 1 -> Method_1 >> Convert.ToString
    | 2 -> Method_2 >> Convert.ToString
    | 3 -> Method_3 >> Convert.ToString
    | _ -> (fun x -> "Error input")

////// TASK 20 //////
let isVowel char =
    let tmp = Char.ToLower char
    match tmp with
    | 'у' | 'е' | 'ы' | 'а' | 'о' | 'э' | 'я' | 'и' | 'ю' -> true
    | _ -> false

let isConsonant char =
    let tmp = Char.ToLower char
    match tmp with
    | 'у' | 'е' | 'ы' | 'а' | 'о' | 'э' | 'я' | 'и' | 'ю' -> false
    | _ -> if tmp >= 'а' && tmp <= 'я' then true
           else false

let QVowels stringe = (String.filter (fun x -> isVowel x) stringe).Length

let QConsonants stringe = (String.filter (fun x -> isConsonant x) stringe).Length

let Method_4 (list:String list) =
    List.sortBy (fun x -> abs ((QVowels x) - (QConsonants x))) list