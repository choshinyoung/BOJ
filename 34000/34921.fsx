// 34921 덕후
// tags: math arithmetic

let [| a; t |] = stdin.ReadLine().Split() |> Array.map int
max 0 (10 + 2 * (25 - a + t)) |> printfn "%d"
