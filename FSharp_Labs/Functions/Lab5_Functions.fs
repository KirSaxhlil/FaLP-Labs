module Lab5_Functions

////// TASK 11-12 //////
let question (str : string) =
    match str.ToLower() with
    | "f#" | "prolog" -> "Подлиза"
    | "c++" | "c" -> "Красава"
    | "c#" -> "Ну допустим"
    | "python" -> "На петухоне значит пишем..."
    | "javascript" -> "Ну ты и джавастриптизер"
    | "php" -> "ишо одна шутка про пхп и я звоню в полицию"
    | "java" -> "вас посетил ентерпраиз джява примат
элемент в массиве найдётся, но только если вы напишите:
AbstractSingletonProxyFactoryBean"
    | "scratch 2" -> "аче)"
    | "html" -> "Ты дурачек?"
    | "pixilang" -> "Когда там новый видос про исскуственную жизнь уже?!?"
    | "ada" -> "RIP AND TEAR"
    | "pascal" -> "че по информатике задали?"
    | "delphi" -> "ладно"
    | "lua" -> "жалко корону"
    | "gml" -> "а вы ценитель"
    | "kotlin" | "ruby" -> "Здравствуйте, Арсений Сергеевич."
    | "ипонский" | "английский" | "русский" -> "скиньте скрипт пж"
    | _ -> "Что это?"

////// TASK 13 //////
    // Digits multiply
let rec DigitMultUp n =
    if n = 0 then 1
    else (n % 10) * DigitMultUp (n/10)

let DigitMultDown n =
    let rec DigitMultDown_body n res = 
        if n = 0 then res
        else DigitMultDown_body (n/10) (res*(n%10))
    DigitMultDown_body n 1

    // Max digit
let rec MaxDigitUp n =
    if n < 10 then n
    else if (n%10) > MaxDigitUp (n/10) then n%10
        else MaxDigitUp (n/10)

let MaxDigitDown n =
    let rec MaxDigitDown_body n max =
        if n = 0 then max
        else if (n%10) > max then MaxDigitDown_body (n/10) (n%10)
            else MaxDigitDown_body (n/10) max
    MaxDigitDown_body (n/10) (n%10)

    //Min digit
let rec MinDigitUp n =
    if n < 10 then n
    else if (n%10) < MinDigitUp (n/10) then n%10
        else MinDigitUp (n/10)

let MinDigitDown n =
    let rec MinDigitDown_body n min =
        if n = 0 then min
        else if (n%10) < min then MinDigitDown_body (n/10) (n%10)
            else MinDigitDown_body (n/10) min
    MinDigitDown_body (n/10) (n%10)

////// TASK 14 //////
let DividersTraversal n func init = 
    let rec DividersTraversal_body n func init divider =
        if divider = 0 then init
        else
            let newInit = 
                if n % divider = 0 then func init divider
                else init
            DividersTraversal_body n func newInit (divider - 1)
    DividersTraversal_body n func init n

////// TASK 15 //////
let GCD x y =
    let rec GCD_body x y iter result =
        if iter = x then result
        else if x % iter = 0 && y % iter = 0 then GCD_body x y (iter+1) iter
            else GCD_body x y (iter+1) result
    GCD_body x y 1 1

let SimpleCompTraversal n func init =
    let rec SimpleCompTraversal_body n func init iter = 
        if iter = 0 then init
        else 
            let newInit =
                if GCD n iter = 1 then func init iter
                else init
            SimpleCompTraversal_body n func newInit (iter - 1)
    SimpleCompTraversal_body n func init n

////// TASK 16 //////
let EulerNumber x =
    let rec EulerNumber_body x iter q = 
        if iter = 0 then q
        else if GCD x iter = 1 then EulerNumber_body x (iter - 1) (q + 1)
            else EulerNumber_body x (iter - 1) q
    EulerNumber_body x x 0

////// TASK 17 //////
let DividersTraversal_Cond n cond func init = 
    DividersTraversal n (fun x y -> if cond y then func x y else x) init

let SimpleCompTraversal_Cond n cond func init = 
    SimpleCompTraversal n (fun x y -> if cond y then func x y else x) init

////// TASK 19 //////
// Variant 1 //
    // Method 1: sum of simple dividers
let SimpleDividersSum n = 
    DividersTraversal_Cond n (fun x -> DividersTraversal x (fun a b -> a + 1) 0 = 2) (fun x y -> x + y) 0

    // Additional method: operations with digits
let rec DigitTraversal n func init =
    if n = 0 then init
    else DigitTraversal (n / 10) func (func init (n % 10))

    // Additional method: operation with digits with condition
let DigitTraversal_Cond n cond func init =
    DigitTraversal n (fun x y -> if cond y then func x y else x) init

    // Method 2: quantity of odd digits bigger then 3
let Method_2 n =
    DigitTraversal_Cond n (fun x -> x % 2 = 1 && x > 3) (fun a b -> a + 1) 0

    // Method 3: multiplication of dividers, digits sum of is smaller then original number digits sum
let Method_3 n =
    let Sum a b = a + b
    DividersTraversal_Cond n (fun a -> DigitTraversal a Sum 0 < DigitTraversal n Sum 0) (fun x y -> x * y) 1

////// TASK 20 //////
let FuncChooser n = 
    match n with
    | 1 -> SimpleDividersSum
    | 2 -> Method_2
    | 3 -> Method_3
    | _ -> (fun x -> x)