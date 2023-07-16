// Explanation of while loops in C#

// Example 1: Basic usage of while loop
int i = 1;
while (i <= 5)
{
    Console.WriteLine("Iteration: " + i);
    i++;
}

// Explanation:
// - The variable 'i' is initialized to 1 before entering the loop.
// - The condition 'i <= 5' is checked before each iteration.
// - If the condition is true, the code block inside the loop is executed.
// - Inside the loop, the statement 'Console.WriteLine("Iteration: " + i);' is executed, printing the current iteration number.
// - The variable 'i' is incremented by 1 (i++).
// - After each iteration, the condition is checked again, and the loop continues until the condition evaluates to false.
// - In this example, the loop runs 5 times, producing the following output:
//   Iteration: 1
//   Iteration: 2
//   Iteration: 3
//   Iteration: 4
//   Iteration: 5

// Example 2: Using a while loop for a specific condition
bool condition = true;
while (condition)
{
    // Code to be executed repeatedly until 'condition' is false
    // ...
}

// Explanation:
// - In this example, the loop will continue executing as long as the variable 'condition' is true.
// - The code block inside the loop will be executed repeatedly until the condition evaluates to false.
// - It's important to ensure that the condition is updated within the loop block to eventually become false and exit the loop.

// Example 3: Infinite loop with a break statement
while (true)
{
    // Code to be executed indefinitely

    if (/* some condition to break the loop */)
        break;
}

// Explanation:
// - By setting the condition to 'true', this creates an infinite loop that executes indefinitely.
// - However, the loop can be terminated using a 'break' statement when a specific condition is met.
// - The 'break' statement allows you to exit the loop prematurely and continue with the program flow.

// Example 4: Skipping an iteration using 'continue'
int i = 1;
while (i <= 5)
{
    if (/* some condition to skip the current iteration */)
    {
        i++;
        continue;
    }

    // Code to be executed for each non-skipped iteration
    // ...

    i++;
}

// Explanation:
// - The 'continue' statement allows you to skip the current iteration and move to the next iteration of the loop.
// - In this example, if a specific condition is met, the current iteration is skipped using 'continue', and the loop control variable 'i' is incremented.
// - The code block inside the loop is executed only for non-skipped iterations.

