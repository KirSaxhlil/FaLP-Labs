﻿module Lab5_Functions

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
