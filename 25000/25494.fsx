// 25494 단순한 문제 (Small)
// tags: math bruteforcing arithmetic

let a=stdin.ReadLine
for i=1 to int(a())do a().Split()|>Seq.minBy int|>printfn"%s"
