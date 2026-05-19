// 1181 단어 정렬
// tags: string sorting

let a=stdin.ReadLine
[for _ in 1..int(a())->a()]|>set|>Seq.sortBy String.length|>Seq.iter(printfn"%s")
