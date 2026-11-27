open System

let [| N; S; E; M |] = Console.ReadLine().Split() |> Array.map int

let edges =
    Array.init M (fun _ -> Console.ReadLine().Split() |> Array.map int)

let earn = Console.ReadLine().Split() |> Array.map int64
let dist = Array.create N Int64.MinValue
dist[S] <- earn[S]

let gain s e w =
    dist[s] <> Int64.MinValue && dist[s] + earn[e] - int64 w > dist[e]

for _ in 2..N do
    for [| s; e; w |] in edges do
        if gain s e w then
            dist[e] <- dist[s] + earn[e] - int64 w

let isCycle = Array.zeroCreate N
let visited = Array.zeroCreate N

for [| s; e; w |] in edges do
    if gain s e w then
        isCycle[e] <- true

let rec dfs v =
    if not visited[v] then
        visited[v] <- true
        dist[v] <- Int64.MaxValue

        edges
        |> Seq.filter (fun [| s; _; _ |] -> s = v)
        |> Seq.iter (fun [| _; e; _ |] -> dfs e)

isCycle
|> Seq.iteri (fun i c ->
    if c then
        dfs i)

if dist[E] = Int64.MinValue then printfn "gg"
elif dist[E] = Int64.MaxValue then printfn "Gee"
else printfn "%d" dist[E]
