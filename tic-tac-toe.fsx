open System

let board = [["X";"O";"X"];["X";"X";"O"];["O";"X";"X"]]

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

let ticTacToe (board : string list list ) (player1 : string) (player2 : string) (turn : string)=
    if winnerLine board then
        printfn "hay un ganador"
    
    

let mutable (turn : string) = " "
showBoard board
ticTacToe board