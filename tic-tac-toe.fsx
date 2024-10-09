open System

let board = [["X";"O";"X"];["X";"X";"O"];["O";"X";"X"]]

let mutable turn = " "

let mutable times = 0

let player1 = 
    printf "Player one: "
    Console.ReadLine()
let player2 = 
    printf "Player two: "
    Console.ReadLine()

let showBoard board = 
    board 
    |> List.iter (fun row -> 
    row |> List.iter (printf "|%s|")
    printfn "")

let playerTurn (turn : string) =
    if turn = "X" then
        "O"
    else
        "X"

//let ticTacToe board player1 player2= 
//    if (board.[0,0]=board.[0,1]=board.[0,2]=("X" || "O") || 
//        board.[1,0]=board.[1,1]=board.[1,2]=("X" || "O") || 
//        board.[2,0]=board.[2,1]=board.[2,2]=("X" || "O") ||
//        board.[0,0]=board.[1,0]=board.[2,0]=("X" || "O") ||
//        board.[0,1]=board.[1,1]=board.[2,1]=("X" || "O") ||
//        board.[0,2]=board.[1,2]=board.[2,2]=("X" || "O") ||
//        board.[0,0]=board.[1,1]=board.[2,2]=("X" || "O") ||
//        board.[0,2]=board.[1,1]=board.[2,0]=("X" || "O"))

let winnerCondition a b c =
    a = b && b = c && (a = "X" || a = "O")

let winnerLine (board:string list list) = 
    if (winnerCondition board.[0].[0] board.[0].[1] board.[0].[2]) ||
       (winnerCondition board.[1].[0] board.[1].[1] board.[1].[2]) ||
       (winnerCondition board.[2].[0] board.[2].[1] board.[2].[2]) ||
       (winnerCondition board.[0].[0] board.[1].[0] board.[2].[0]) ||
       (winnerCondition board.[0].[1] board.[1].[1] board.[2].[1]) ||
       (winnerCondition board.[0].[2] board.[1].[2] board.[2].[2]) ||
       (winnerCondition board.[0].[0] board.[1].[1] board.[2].[2]) ||
       (winnerCondition board.[0].[2] board.[1].[1] board.[2].[0]) then
        true
    else
        false

let game (board : string list list) (p1 : string) (p2 : string) (turn : string)=
    "aqui pondre el codigo"        

let ticTacToe (board : string list list ) (player1 : string) (player2 : string) 
              (turn : string) (times : int)=
    if winnerLine board then
        printfn "hay un ganador"
    else if times = 9 then
        printfn "empate"
    else
        let mutable internalturn = " "
        internalturn <- playerTurn (turn)
        let mutable (internaltimes : int) = 0
        internaltimes <- times + 1
    
    


showBoard board
ticTacToe board