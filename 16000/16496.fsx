open System

Console.ReadLine() |> ignore
let A = Console.ReadLine().Split()

let sorted =
    A
    |> Seq.sortWith (fun x y -> compare (y + x) (x + y))
    |> String.concat ""

printfn "%s" (if sorted[0] = '0' then "0" else sorted)
