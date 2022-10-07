# Fibonacci Series Value in Web API

This repository contains an ASP.NET Core Web API project with one endpoint that receives a value n which represents the position of the series to obtain. 

## What is Fibonacci Series

A series of numbers in which each number (Fibonacci number) is the sum of the two preceding numbers is called as the Fibonacci Series.

The Fibonacci numbers can easily obtained by using the following formula:

      F(n) = F(n-1) + F(n-2) 
where  
   - F(n) = The current term.
   - F(n-1) = The preceeding term.
   - F(n-2) = The second preceeding term.

This gives us the following sequence that goes to infinity:

        1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ....

## About the project

To obtain the value of F(n) the decision was made to create a recursive method, since it was the easiest way to do it.

This method was added as an extension method to the struct **int** to make the code more readable.

## Optimization for the future

This code has a problem, the number of operations to compute F(n) is proportional to the final numerical answer, which grows exponentially, to solve this we can change the algorithm to **Fast Doubling**.

[![Fast Fibonacci Algorithms]] (https://www.nayuki.io/page/fast-fibonacci-algorithms)