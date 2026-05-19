// 34945 채플이 너무해
// tags: math implementation arithmetic

match stdin.ReadLine() |> int with
| x when x < 6 -> "Oh My God!"
| _ -> "Success!"
|> printfn "%s"
