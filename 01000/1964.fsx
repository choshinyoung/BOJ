// 1964 오각형, 오각형, 오각형…
// tags: math

let n = stdin.ReadLine() |> int64
((5L + 3L * n) * n / 2L + 1L) % 45678L |> printf "%d"
