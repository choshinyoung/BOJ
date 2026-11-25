open System
open System.Collections.Generic

let T = Console.ReadLine() |> int

for _ in 1..T do
    Console.ReadLine() |> ignore
    let pq = PriorityQueue<int64, int64>()

    Console.ReadLine().Split()
    |> Seq.map int
    |> Seq.iter (fun x -> pq.Enqueue(x, x))

    let rec solve acc =
        if pq.Count = 1 then
            acc
        else
            let x = pq.Dequeue() + pq.Dequeue()
            pq.Enqueue(x, x)
            solve (acc + x)

    solve 0 |> printfn "%d"
