open System

let dfsWith adj action =
    let visited = adj |> Array.length |> Array.zeroCreate

    let rec dfs x =
        if visited[x] then
            false
        else
            visited[x] <- true
            adj[x] |> List.iter (dfs >> ignore)
            action x
            true

    dfs

let T = Console.ReadLine() |> int

for _ in 1..T do
    let [| N; M |] = Console.ReadLine().Split() |> Array.map int
    let adj = Array.create N []
    let adjRev = Array.create N []

    for _ in 1..M do
        let [| x; y |] = Console.ReadLine().Split() |> Array.map int
        adj[x - 1] <- y - 1 :: adj[x - 1]
        adjRev[y - 1] <- x - 1 :: adjRev[y - 1]

    let order = Array.zeroCreate N
    let mutable o = 0

    let dfsOrder =
        dfsWith adj (fun x ->
            order[o] <- x
            o <- o + 1)

    for x in 0 .. N - 1 do
        dfsOrder x |> ignore

    let scc = Array.zeroCreate N
    let mutable c = 0

    let dfsScc = dfsWith adjRev (fun x -> scc[x] <- c)

    for x in order |> Seq.rev do
        if dfsScc x then
            c <- c + 1

    let hasIn = Array.zeroCreate c

    for x in 0 .. N - 1 do
        for y in adj[x] do
            if scc[x] <> scc[y] then
                hasIn[scc[y]] <- true

    hasIn |> Seq.filter not |> Seq.length |> printfn "%d"
