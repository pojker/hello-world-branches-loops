//MAKE DECISIONS USING THE IF STATEMENT

using System.Xml;

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



// MAKE IF AND ELSE WORK TOGETHER

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





// USE LOOPS TO REPEAT OPERATIONS


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




// WORK WITH THE FOR LOOP

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



/* CREATE NESTED LOOPS
A while, do, or for loop can be nested inside another loop to create a matrix
using the combination of each item in the outer loop with each item in the inner loop.
*/

// One for loop can generate the rows:

for (int row = 1; row <11; row++)
{
    Console.WriteLine($"The row is {row}");
}

/* Output:
The row is 1
The row is 2
The row is 3
The row is 4
The row is 5
The row is 6
The row is 7
The row is 8
The row is 9
The row is 10
*/


// Another loop can generate the columns:

for (char column = 'a'; column < 'k'; column++)
{
    Console.WriteLine($"The column is {column}");
}


/* Output:
The column is a
The column is b
The column is c
The column is d
The column is e
The column is f
The column is g
The column is h
The column is i
The column is j
*/



// We can nest one loop inside the other to form pairs:

for (int row = 1; row < 11; row++)
{
  for (char column = 'a'; column < 'k'; column++)
  {
    Console.WriteLine($"The cell is ({row}, {column})");
  }
}

/* Output:
The cell is (1, a)
The cell is (1, b)
The cell is (1, c)
The cell is (1, d)
The cell is (1, e)
The cell is (1, f)
The cell is (1, g)
The cell is (1, h)
The cell is (1, i)
The cell is (1, j)
The cell is (2, a)
The cell is (2, b)
The cell is (2, c)
The cell is (2, d)
The cell is (2, e)
The cell is (2, f)
The cell is (2, g)
The cell is (2, h)
The cell is (2, i)
The cell is (2, j)
The cell is (3, a)
The cell is (3, b)
The cell is (3, c)
The cell is (3, d)
The cell is (3, e)
The cell is (3, f)
The cell is (3, g)
The cell is (3, h)
The cell is (3, i)
The cell is (3, j)
The cell is (4, a)
The cell is (4, b)
The cell is (4, c)
The cell is (4, d)
The cell is (4, e)
The cell is (4, f)
The cell is (4, g)
The cell is (4, h)
The cell is (4, i)
The cell is (4, j)
The cell is (5, a)
The cell is (5, b)
The cell is (5, c)
The cell is (5, d)
The cell is (5, e)
The cell is (5, f)
The cell is (5, g)
The cell is (5, h)
The cell is (5, i)
The cell is (5, j)
The cell is (6, a)
The cell is (6, b)
The cell is (6, c)
The cell is (6, d)
The cell is (6, e)
The cell is (6, f)
The cell is (6, g)
The cell is (6, h)
The cell is (6, i)
The cell is (6, j)
The cell is (7, a)
The cell is (7, b)
The cell is (7, c)
The cell is (7, d)
The cell is (7, e)
The cell is (7, f)
The cell is (7, g)
The cell is (7, h)
The cell is (7, i)
The cell is (7, j)
The cell is (8, a)
The cell is (8, b)
The cell is (8, c)
The cell is (8, d)
The cell is (8, e)
The cell is (8, f)
The cell is (8, g)
The cell is (8, h)
The cell is (8, i)
The cell is (8, j)
The cell is (9, a)
The cell is (9, b)
The cell is (9, c)
The cell is (9, d)
The cell is (9, e)
The cell is (9, f)
The cell is (9, g)
The cell is (9, h)
The cell is (9, i)
The cell is (9, j)
The cell is (10, a)
The cell is (10, b)
The cell is (10, c)
The cell is (10, d)
The cell is (10, e)
The cell is (10, f)
The cell is (10, g)
The cell is (10, h)
The cell is (10, i)
The cell is (10, j)
*/




// If reversed:

for (char column = 'a'; column < 'k'; column++)
{
    for (int row = 1; row < 11; row++)
    {
        Console.WriteLine($"The cell is ({column}, {row})");
    }

}


/* Output:
The cell is (a, 1)
The cell is (a, 2)
The cell is (a, 3)
The cell is (a, 4)
The cell is (a, 5)
The cell is (a, 6)
The cell is (a, 7)
The cell is (a, 8)
The cell is (a, 9)
The cell is (a, 10)
The cell is (b, 1)
The cell is (b, 2)
The cell is (b, 3)
The cell is (b, 4)
The cell is (b, 5)
The cell is (b, 6)
The cell is (b, 7)
The cell is (b, 8)
The cell is (b, 9)
The cell is (b, 10)
The cell is (c, 1)
The cell is (c, 2)
The cell is (c, 3)
The cell is (c, 4)
The cell is (c, 5)
The cell is (c, 6)
The cell is (c, 7)
The cell is (c, 8)
The cell is (c, 9)
The cell is (c, 10)
The cell is (d, 1)
The cell is (d, 2)
The cell is (d, 3)
The cell is (d, 4)
The cell is (d, 5)
The cell is (d, 6)
The cell is (d, 7)
The cell is (d, 8)
The cell is (d, 9)
The cell is (d, 10)
The cell is (e, 1)
The cell is (e, 2)
The cell is (e, 3)
The cell is (e, 4)
The cell is (e, 5)
The cell is (e, 6)
The cell is (e, 7)
The cell is (e, 8)
The cell is (e, 9)
The cell is (e, 10)
The cell is (f, 1)
The cell is (f, 2)
The cell is (f, 3)
The cell is (f, 4)
The cell is (f, 5)
The cell is (f, 6)
The cell is (f, 7)
The cell is (f, 8)
The cell is (f, 9)
The cell is (f, 10)
The cell is (g, 1)
The cell is (g, 2)
The cell is (g, 3)
The cell is (g, 4)
The cell is (g, 5)
The cell is (g, 6)
The cell is (g, 7)
The cell is (g, 8)
The cell is (g, 9)
The cell is (g, 10)
The cell is (h, 1)
The cell is (h, 2)
The cell is (h, 3)
The cell is (h, 4)
The cell is (h, 5)
The cell is (h, 6)
The cell is (h, 7)
The cell is (h, 8)
The cell is (h, 9)
The cell is (h, 10)
The cell is (i, 1)
The cell is (i, 2)
The cell is (i, 3)
The cell is (i, 4)
The cell is (i, 5)
The cell is (i, 6)
The cell is (i, 7)
The cell is (i, 8)
The cell is (i, 9)
The cell is (i, 10)
The cell is (j, 1)
The cell is (j, 2)
The cell is (j, 3)
The cell is (j, 4)
The cell is (j, 5)
The cell is (j, 6)
The cell is (j, 7)
The cell is (j, 8)
The cell is (j, 9)
The cell is (j, 10)
*/




