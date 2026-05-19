// 11024 더하기 4
// tags: math arithmetic

for _ in 1 .. stdin.ReadLine() |> int do
    stdin.ReadLine().Split() |> Array.map int |> Array.sum |> printfn "%d"
