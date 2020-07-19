using System;

namespace Solver
{
    public class QuadraticEquationSolver
    {
        public static double[] Solve(double a, double b, double c)
        {
            //Check for coefficient values
            //Проверим наличие коэффициентов
            if (a == 0)
            {
                if (b == 0)
                    return new double[0];
                else
                    return new[] { -c / b };
            }

            var sqrtDiscriminant = Math.Sqrt(b * b - 4 * a * c);

            //discriminant is Negative. Create an empty array
            //дискриминант отрицательный. Создаем пустой массив
            if (double.IsNaN(sqrtDiscriminant))
                return new double[0];

            //discriminant is Zero. Create an array with one elements
            //дискриминант равен Нулю. Создаем массив с одним элементами
            else if (sqrtDiscriminant == 0)
                return new[] { -b / (2 * a) };

            //discriminant is Greater than Zero. Create an array with two elements
            //дискриминант больше Нуля. Создаем массив с двумя элементами
            else 
                return new[] 
                {(-b + sqrtDiscriminant) / (2 * a), (-b - sqrtDiscriminant) / (2 * a)};
        }
    }
}
