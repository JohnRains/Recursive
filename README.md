# Recursive
Using Recursion for Fibonacci series

I was playing around with Fibonacci numbers in C# and threw a quick solution together in VS2019. 
The integer valuse used are ulong (64 bit unsigned) and the terminacion of the recursion is ulong.MaxValue/2 (otherwise a stack overflow exception will be thrown.
I was stunned how fast it is "Value = 12200160415121876738 in 1.0003 milliseconds".
