// 34052 체육은 수학과목 입니다 2
// tags: math implementation arithmetic

let a = Seq.init 4 (fun _ -> stdin.ReadLine() |> int) |> Seq.sum

if a + 300 <= 1800 then "Yes" else "No"
|> printfn "%s"
