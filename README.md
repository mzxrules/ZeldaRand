# ZeldaRand

This project computes all possible solutions for the Truth Spinner Puzzle in Ocarina of Time. The puzzle works like this:

There is a statue of a bird that must be rotated to face one of 5 torches. Of those 5, only the three torches farthest from the initial
position will be a valid solution. 

In order to select a solution torch, the torches choose amongst themselves which one will be the solution. 

The first torch generates a random number between 0f and 3f exclusive. If that number is less than 1, it becomes the solution.

If the first torch wasn't selected, the second torch generates a random number between 0f and 3f exclusive. If that number is less than 2,
it becomes the solution.

If the first and second torch haven't been selected, the third torch generates a random number between 0f and 3f exclusive. If that number
is less than 3 (which it should be), it becomes the solution.
