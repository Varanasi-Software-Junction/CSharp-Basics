// Explanation of for loops in C#

// General syntax:
for (initialization; condition; iteration)
{
    // Code to be executed repeatedly
}

// Example usage:
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Iteration: " + i);
}

// Explanation:
// - The loop control variable 'i' is initialized to 1.
// - The loop will continue executing as long as 'i' is less than or equal to 5.
// - After each iteration, the value of 'i' is incremented by 1 (i++).
// - Inside the loop, the statement 'Console.WriteLine("Iteration: " + i);' prints the current iteration number.
// - The loop will run 5 times, producing the following output:
//   Iteration: 1
//   Iteration: 2
//   Iteration: 3
//   Iteration: 4
//   Iteration: 5



// Explanation of optional parameters in for loops in C#

// Example 1: Omitting all parameters (creating an infinite loop)
for (;;)
{
    // Code to be executed indefinitely
}

// Example 2: Omitting the initialization (using pre-existing variable)
int i = 1;
for (; i <= 5; i++)
{
    Console.WriteLine("Iteration: " + i);
}

// Example 3: Omitting the condition (creating an infinite loop with a break)
for (int i = 1;; i++)
{
    Console.WriteLine("Iteration: " + i);
    if (i == 5)
        break;
}

// Example 4: Omitting the iteration (performing increment manually)
for (int i = 1; i <= 5;)
{
    Console.WriteLine("Iteration: " + i);
    i++;
}






