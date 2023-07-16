// Explanation of do-while loops in C#

// Example 1: Basic usage of do-while loop
int i = 1;
do
{
    Console.WriteLine("Iteration: " + i);
    i++;
} while (i <= 5);

// Explanation:
// - The variable 'i' is initialized to 1 before entering the loop.
// - The code block inside the loop is executed at least once before checking the condition.
// - Inside the loop, the statement 'Console.WriteLine("Iteration: " + i);' is executed, printing the current iteration number.
// - The variable 'i' is incremented by 1 (i++).
// - After each iteration, the condition 'i <= 5' is checked.
// - If the condition is true, the loop continues and repeats the code block.
// - If the condition is false, the loop terminates, and the program continues with the next statement after the loop.
// - In this example, the loop runs 5 times, producing the following output:
//   Iteration: 1
//   Iteration: 2
//   Iteration: 3
//   Iteration: 4
//   Iteration: 5

// Example 2: Using a do-while loop for a specific condition
bool condition = true;
do
{
    // Code to be executed repeatedly until 'condition' is false
    // ...
} while (condition);

// Explanation:
// - In this example, the loop will continue executing as long as the variable 'condition' is true.
// - The code block inside the loop is executed at least once before checking the condition.
// - After each iteration, the condition is checked.
// - If the condition is true, the loop continues and repeats the code block.
// - If the condition is false, the loop terminates, and the program continues with the next statement after the loop.

// Example 3: Infinite loop with a break statement
do
{
    // Code to be executed indefinitely

    if (/* some condition to break the loop */)
        break;
} while (true);

// Explanation:
// - By setting the condition to 'true', this creates an infinite loop that executes indefinitely.
// - However, the loop can be terminated using a 'break' statement when a specific condition is met.
// - The 'break' statement allows you to exit the loop prematurely and continue with the program flow.

// Example 4: Skipping an iteration using 'continue'
int i = 1;
do
{
    if (/* some condition to skip the current iteration */)
    {
        i++;
        continue;
    }

    // Code to be executed for each non-skipped iteration
    // ...

    i++;
} while (i <= 5);

// Explanation:
// - The 'continue' statement allows you to skip the current iteration and move to the next iteration of the loop.
// - In this example, if a specific condition is met, the current iteration is skipped using 'continue', and the loop control variable 'i' is incremented.
// - The code block inside the loop is executed only for non-skipped iterations.

