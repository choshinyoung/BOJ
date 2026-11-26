open System

let [| N; M |] = Console.ReadLine().Split() |> Array.map int

let graph =
    Array.init N (fun _ ->
        Console.ReadLine().ToCharArray() |> Array.map ((=) 'Y'))

let parents = Array.init N id

let rec find x =
    if parents[x] <> x then
        parents[x] <- find parents[x]

    parents[x]

let union x y =
    let x' = find x
    let y' = find y

    parents[x'] <- y'

let result = Array.zeroCreate N
let mutable remain = M

for x in 0 .. N - 2 do
    for y in x + 1 .. N - 1 do
        if graph[x][y] && find x <> find y then
            union x y

            remain <- remain - 1
            graph[x][y] <- false
            result[x] <- result[x] + 1
            result[y] <- result[y] + 1

if
    seq [ 0 .. N - 1 ]
    |> Seq.pairwise
    |> Seq.exists (fun (x, y) -> find x <> find y)
then
    printfn "-1"
else
    for x in 0 .. N - 2 do
        for y in x + 1 .. N - 1 do
            if graph[x][y] && remain > 0 then
                remain <- remain - 1
                result[x] <- result[x] + 1
                result[y] <- result[y] + 1

    if remain > 0 then
        printfn "-1"
    else
        result |> Seq.map string |> String.concat " " |> printfn "%s"
