open System
open System.Collections.Generic

let [| V; E |] = Console.ReadLine().Split() |> Array.map int
let K = Console.ReadLine() |> int

let adj = Array.create (V + 1) []

for _ in 1..E do
    let [| v; u; w |] = Console.ReadLine().Split() |> Array.map int
    adj[v] <- (u, w) :: adj[v]

let dist = Array.create (V + 1) Int32.MaxValue
dist[K] <- 0

let pq = PriorityQueue<int, int>()
pq.Enqueue(K, 0)

while pq.Count > 0 do
    let v = pq.Dequeue()

    for u, w in adj[v] do
        let next = dist[v] + w

        if dist[u] > next then
            dist[u] <- next
            pq.Enqueue(u, next)

dist[1..]
|> Seq.iter (fun x ->
    if x = Int32.MaxValue then printfn "INF" else printfn "%d" x)
