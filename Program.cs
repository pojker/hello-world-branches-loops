//Make decisions using the if statement

int a = 5;
int b = 6;
if (a + b > 10)
Console.WriteLine("The answer is greater than 10.");

//Output = The answer is greater than 10.


int a = 5;
int b = 6;
if (a + b < 10)
Console.WriteLine("The answer is greater than 10.");

//Output = No output



int a = 5;
int b = 3;
if (a + b > 10)
Console.WriteLine("The answer is greater than 10.");


/*Output = No output. Because the answer is less than 10, nothing is printed.
The condition you're testing is false.
You don't have any code to execute because
you've only written one of the possible branches for an if statement: the true branch.


BOOLEANS
A boolean is a variable that can have one of two values: true or false.
C# defines a special type, bool for boolean variables.
The if statement checks the value of a bool.
When the value is true, the statement following the if executes.
Otherwise, it's skipped.
*/



//Make if and else work together

int a = 5;
int b = 3;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10");
else
    Console.WriteLine("The answer is not greater than 10");

	 //Output: The answer is not greater than 10




/*
Because indentation isn't significant, you need to use { and }
to indicate when you want more than one statement to be part of the block that executes conditionally.
C# programmers typically use those braces on all if and else clauses.
The following example is the same as what was created just above.
*/

int a = 5;
int b = 3;
if (a + b > 10)
{
    Console.WriteLine("The answer is greater than 10");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
}

//Output: The answer is not greater than 10




int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

// Output:
// The answer is not greater than 10
// Or the first number is not equal to the second

/* The == symbol tests for equality.
Using == distinguishes the test for equality from assignment, which was in a = 5.
The && represents "and".
It means both conditions must be true to execute the statement in the true branch.
These examples  show that we can have multiple statements
in each conditional branch, provided we enclose them in { and }.
We can also use || to represent "or"
*/


int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}

/* Output:
The answer is greater than 10
Or the first number is equal to the second
that is because the if statement has already checked for the first part of the condition,
which is "if  (a + b + c > 10), meaning if 5+3+4>10". Because this part is true, and the rest of the condition says
OR a==b, the output is:
"The answer is greater than 10
Or the first number is equal to the second", even though a does not equal b.


*/
