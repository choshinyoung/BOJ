// 31450 Everyone is a winner
// tags: math arithmetic

let [| a; b |] = stdin.ReadLine().Split() |> Array.map int
if a % b = 0 then printfn "Yes" else printfn "No"
