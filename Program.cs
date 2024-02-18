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





//Use loops to repeat operations


int counter = 0;
while (counter < 10)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
}


/* Output:
Hello World! The counter is 0
Hello World! The counter is 1
Hello World! The counter is 2
Hello World! The counter is 3
Hello World! The counter is 4
Hello World! The counter is 5
Hello World! The counter is 6
Hello World! The counter is 7
Hello World! The counter is 8
Hello World! The counter is 9
*/


/*Important
We should make sure that the while loop condition does switch to false as we execute the code.
Otherwise, we create an infinite loop where our program never ends.
*/



int counter = 0;
do
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
} while (counter < 10);


/* Output:
Hello World! The counter is 0
Hello World! The counter is 1
Hello World! The counter is 2
Hello World! The counter is 3
Hello World! The counter is 4
Hello World! The counter is 5
Hello World! The counter is 6
Hello World! The counter is 7
Hello World! The counter is 8
Hello World! The counter is 9

The while loop tests the condition before executing the code following the while.
The do ... while loop executes the code first, and then checks the condition.
*/




// Work with the for loop

for (int counter = 0; counter < 10; counter++)
{
    Console.WriteLine($"Hello world! The counter is {counter}");
}

/* Output:
Hello world! The counter is 0
Hello world! The counter is 1
Hello world! The counter is 2
Hello world! The counter is 3
Hello world! The counter is 4
Hello world! The counter is 5
Hello world! The counter is 6
Hello world! The counter is 7
Hello world! The counter is 8
Hello world! The counter is 9


This does the same work as the while loop and the do loop we've already used. 
The for statement has three parts that control how it works.

The first part is the for initializer: int counter = 0; declares that counter is the loop variable, 
and sets its initial value to 0.

The middle part is the for condition: counter < 10 declares that this for loop continues to execute
as long as the value of counter is less than 10.

The final part is the for iterator: counter++ specifies how to modify the loop variable 
after executing the block following the for statement.
Here, it specifies that counter should be incremented by 1 each time the block executes.

*/


for (int counter = 2; counter < 10; counter++)
{
    Console.WriteLine($"Hello world! The counter is {counter}");
}

/* Output:
Hello world! The counter is 2
Hello world! The counter is 3
Hello world! The counter is 4
Hello world! The counter is 5
Hello world! The counter is 6
Hello world! The counter is 7
Hello world! The counter is 8
Hello world! The counter is 9
*/



for (int counter = 8; counter < 10; counter++)
{
    Console.WriteLine($"Hello world! The counter is {counter}");
}

/* Output:
Hello world! The counter is 8
Hello world! The counter is 9
*/



for (int counter = 9; counter < 10; counter++)
{
    Console.WriteLine($"Hello world! The counter is {counter}");
}


/* Output
Hello world! The counter is 9
*/



for (int counter = 2; counter < 15; counter++)
{
    Console.WriteLine($"Hello world! The counter is {counter}");
}

/* Output
Hello world! The counter is 2
Hello world! The counter is 3
Hello world! The counter is 4
Hello world! The counter is 5
Hello world! The counter is 6
Hello world! The counter is 7
Hello world! The counter is 8
Hello world! The counter is 9
Hello world! The counter is 10
Hello world! The counter is 11
Hello world! The counter is 12
Hello world! The counter is 13
Hello world! The counter is 14
*/



