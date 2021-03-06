module Lab5
open System
open Lab5_Functions

// func_name : unit : runs all (func : unit) in module in order >:(((((
// func_name(): unit -> unit !

let task_11() =
    Console.WriteLine "Задача 5.11"
    Console.WriteLine "Назовите ваш любимый язык программирования:"
    Console.ReadLine() |> question |> Console.WriteLine
    Console.WriteLine()

let task_12() = 
    Console.WriteLine "Задача 5.12"
    Console.WriteLine "Назовите ваш любимый язык программирования:"
    let carring input_func func output_func = output_func (func (input_func())) // bruh carring func
    carring Console.ReadLine question Console.WriteLine // Carring
    Console.WriteLine()
    Console.WriteLine "Назовите ваш любимый язык программирования:"
    (Console.ReadLine >> question >> Console.WriteLine)() // Superposition
    Console.WriteLine()

let task_13() = 
    let number = 386
    Console.WriteLine "Задача 5.13"
    Console.WriteLine ("Исходное число: " + Convert.ToString number)
    Console.Write "Произведение цифр числа, рекусрия вверх: "
    Console.WriteLine (DigitMultUp number)
    Console.Write "Произведение цифр числа, хвостовая рекурсия: "
    Console.WriteLine (DigitMultDown number)
    Console.Write "Максимальная цифра числа, рекурсия вверх: "
    Console.WriteLine (MaxDigitUp number)
    Console.Write "Максимальная цифра числа, хвостовая рекурсия: "
    Console.WriteLine (MaxDigitDown number)
    Console.Write "Минимальная цифра числа, рекурсия вверх: "
    Console.WriteLine (MinDigitUp number)
    Console.Write "Минимальная цифра числа, хвостовая рекурсия: "
    Console.WriteLine (MinDigitDown number)
    Console.WriteLine()

let task_14() =
    let number = 543
    Console.WriteLine "Задача 5.14"
    Console.WriteLine ("Исходное число: " + Convert.ToString number)
    Console.Write "Сумма делителей числа: "
    Console.WriteLine (DividersTraversal number (fun x y -> x + y) 0)
    Console.Write "Произведение делителей числа: "
    Console.WriteLine (DividersTraversal number (fun x y -> x * y) 1)
    Console.Write "Максимальный из делителей числа: "
    Console.WriteLine (DividersTraversal number (fun x y -> if y <> number then // Excluding self number as maximal divider
                                                                if x > y then x
                                                                else y
                                                            else x) 0)
    Console.Write "Минимальный из делителей числа: "
    Console.WriteLine (DividersTraversal number (fun x y -> if y <> 1 then // Excluding 1 as minimal divider
                                                                if x < y then x
                                                                else y
                                                            else x) number)
    Console.WriteLine()

let task_15() =
    let number = 14
    Console.WriteLine "Задача 5.15"
    Console.WriteLine ("Исходное число: " + Convert.ToString number)
    Console.Write "Сумма простых компонентов числа: "
    Console.WriteLine (SimpleCompTraversal number (fun x y -> x + y) 0)
    Console.Write "Произведение простых компонентов числа: "
    Console.WriteLine (SimpleCompTraversal number (fun x y -> x * y) 1)
    Console.Write "Максимальный из простых компонентов числа: "
    Console.WriteLine (SimpleCompTraversal number (fun x y -> if x > y then x else y) 0)
    Console.Write "Минимальный из простых компонентов числа: "
    Console.WriteLine (SimpleCompTraversal number (fun x y -> if x < y then x else y) number)
    Console.WriteLine()

let task_16() = 
    Console.WriteLine "Задача 5.16"
    let number_1 = 34
    let number_2 = 14
    Console.WriteLine ("Число эйлера для числа " + Convert.ToString number_1 + ": " + Convert.ToString (EulerNumber number_1))
    Console.WriteLine ("Число эйлера для числа " + Convert.ToString number_2 + ": " + Convert.ToString (EulerNumber number_2))
    Console.WriteLine()

let task_17() =
    let number = 14
    Console.WriteLine "Задача 5.17"
    Console.WriteLine ("Исходное число: " + Convert.ToString number)
    Console.Write "Произведение четных делителей числа: "
    Console.WriteLine (DividersTraversal_Cond number (fun x -> x % 2 = 0) (fun x y -> x * y) 1)
    Console.Write "Сумма простых компонентов числа, больших числа эйлера этого числа: "
    Console.WriteLine (SimpleCompTraversal_Cond number (fun x -> x > EulerNumber number) (fun x y -> x + y) 0)
    Console.WriteLine()

let task_19() =
    let number_1 = 14
    let number_2 = 74517
    let number_3 = 436
    Console.WriteLine "Задача 5.19"
    Console.Write ("Сумма простых делителей числа " + Convert.ToString number_1 + ": ")
    Console.WriteLine (SimpleDividersSum number_1)
    Console.Write ("Количество нечетных цифр числа " + Convert.ToString number_2 + ", больших 3: ")
    Console.WriteLine (Method_2 number_2)
    Console.Write ("Прозведение таких делителей числа " + Convert.ToString number_3 + ", сумма цифр которых меньше, чем сумма цифр исходного числа: ")
    Console.WriteLine (Method_3 number_3)
    Console.WriteLine()

let task_20() =
    let carring input func output = 
        let func_num = fst input
        let arg = snd input
        output ((func func_num) arg)

    Console.WriteLine "Задача 5.20"

    Console.WriteLine "Введите номер функции и ее аргумент:"
    let input = (Int32.Parse (Console.ReadLine()), Int32.Parse (Console.ReadLine()))
    carring input FuncChooser Console.WriteLine // Carring
    Console.WriteLine()

    Console.WriteLine "Введите номер функции и ее аргумент:"
    ((Console.ReadLine >> Int32.Parse >> (Console.ReadLine >> Int32.Parse >> FuncChooser)()) >> Console.WriteLine)() // Superposition
    Console.WriteLine()