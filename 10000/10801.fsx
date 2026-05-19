// 10801 카드게임
// tags: implementation

let a () =
    stdin.ReadLine().Split() |> Array.map int

(a (), a ())
||> Seq.map2 compare
|> Seq.sum
|> sign
|> function
    | 1 -> "A"
    | -1 -> "B"
    | _ -> "D"
|> printf "%s"
