// 27172 수 나누기 게임
// tags: math bruteforcing number_theory primality_test sieve

let m = 1000000

let n = stdin.ReadLine() |> int
let a = stdin.ReadLine().Split() |> Array.map int

let table = Array.create (m + 1) -1
a |> Array.iteri (fun i x -> table[x] <- i)

let score = Array.zeroCreate n

for i in 0 .. n - 1 do
    for j in a[i] * 2 .. a[i] .. m do
        if table[j] > -1 then
            score[table[j]] <- score[table[j]] - 1
            score[i] <- score[i] + 1

score |> Array.map string |> String.concat " " |> printfn "%s"
