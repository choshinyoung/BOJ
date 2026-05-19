// 33967 SCSC 기차 놀이
// tags: implementation simulation

stdin.ReadLine() |> ignore

stdin.ReadLine()
|> Seq.pairwise
|> Seq.sumBy (fun (a, b) ->
    match a, b with
    | '2', '2'
    | '5', '5' -> 2
    | ']', '[' -> 0
    | _ -> 1)
|> printfn "%d"
