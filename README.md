
Please, note that this project is over engineered on purpose just to show and higlight my level of coding

In the solution provided, I have implemented the following.
- Applied DDD to analyse the domains and create entities
- Separated the solution into multiple projects by implementing the Clean Architecture Principles 
- Applied TDD to create Unit Tests using XUnit test projects
- Created an API to provide the service for the frontend
- Created a web page to accept input and show the output


Functional requirements
  User Input:
    The application must allow the user to input a whole number N.
    The value of N must be at least 1.
    The application should validate the input to ensure it's a whole number and meets the minimum requirement.

  Prime Number Generation:
    The application must generate the first N prime numbers.

  Multiplication Table Creation:
    The application should create a multiplication table using the N prime numbers.
    The table should be an N+1 x N+1 grid.

  Output Display:
    The application should output the multiplication table to the user.

Example 

Input: N = 3
Output table:

    2   3   5    

2   4   6  10

3   6   9  15

5  10  15  25


=====

Non-Functional requirements
  Performance:
    The application should generate and display the multiplication table within a reasonable time frame
    The prime number generation algorithm should be efficient, especially for larger values of N.


Technology Stack: 
  
  .Net Core
  ASP.net
  xUnit
