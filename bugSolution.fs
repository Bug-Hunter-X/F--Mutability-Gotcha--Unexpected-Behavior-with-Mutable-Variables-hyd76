let mutable x = 1
let mutable y = 2
let mutable z = x + y
printf "%d" z
x <- 3
z <- x + y // Recalculate z
printf "%d %d" x z