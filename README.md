# F# Mutability Gotcha: Unexpected Behavior with Mutable Variables

This example demonstrates a common pitfall in F# when dealing with mutable variables.  The value of `z` is calculated only once, even though `x` is updated later. This is because F# doesn't automatically recompute `z` based on changes to `x`.

**Bug:** The program prints `3 3` instead of `3 5`.

**Solution:**  The solution involves recalculating `z` after modifying `x`.