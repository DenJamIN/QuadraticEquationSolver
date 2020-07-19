//Create libary class (Solver)
//Создаем библиотеку с решением
using Solver;
using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Accept values of user coefficients
            //Принимаем значения коэффициентов пользователя
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            //Quadratic Equation Solver
            //Решение квадратного уравнения
            var result = QuadraticEquationSolver.Solve(a, b, c);

            //Showing the solution on the console
            //Выводим решение на консоль
            for (int i = 0; i < result.Length; i++)
                Console.WriteLine(result[i]);

        }     
    
    }
}
