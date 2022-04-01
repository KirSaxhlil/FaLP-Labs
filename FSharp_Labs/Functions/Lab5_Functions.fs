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
    let rec MinDigitDown_body n max =
        if n = 0 then max
        else if (n%10) < max then MinDigitDown_body (n/10) (n%10)
            else MinDigitDown_body (n/10) max
    MinDigitDown_body (n/10) (n%10)