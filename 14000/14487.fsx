// 14487 욱제는 효도쟁이야!!
// tags: implementation greedy

stdin.ReadLine() |> ignore
let a = stdin.ReadLine().Split() |> Array.map int
Array.sum a - Array.max a |> printfn "%d"
