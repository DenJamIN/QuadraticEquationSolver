using NUnit.Framework;
using System;

namespace Solver.Tests
{
    [TestFixture]
    public class SolverTest
    {
        [TestCase(1, -3, 2, 2, 1)]
        //discriminant is Greater than Zero
        //дискриминант больше Нуля
        [TestCase(16, -8, 1, 0.25)]
        //discriminant is Zero
        //дискриминант равен Нулю
        [TestCase(1, 1, 1)]
        //discriminant is Negative
        //дискриминант отрицательный
        [TestCase(0, 2, -2, 1)]
        //coefficient A is Zero
        //коэффициент А равен Нулю
        [TestCase(2, 0, -8, 2, -2)]
        //coefficient B is Zero
        //коэффициент В равен Нулю
        [TestCase(0, 0, 1)]
        //coefficients A and B is Zero
        //коэффициенты А и В равны нулю

        //Unit test. Accepts coefficient values(A, B, C) ​​and an array of quadratic equation solver
        //Модульное тестирование. Принимает значения коэффициентов(A, B, C) и массив из корней
        public static void TestEquation(double a, double b, double c, params double[] expectedResult)
        {
            var result = QuadraticEquationSolver.Solve(a, b, c);

            //Compare the expected number of solutions with the equations to the actual
            //Сравниваем ожидаемое количество решений уравнения и действительное
            Assert.AreEqual(expectedResult.Length, result.Length);

            //Compare the expected correct decisions to the actual
            //Сравниваем ожидаемые правильные решения и действительное
            for (int index = 0; index < result.Length; index++)
            {
                Assert.AreEqual(expectedResult[index], result[index]);
            }

        }

        //Building a functional test to test the solution to the equation
        //Создаем функциональное тестирование для проверки решения корней
        [Test]
        public void FunctionalTest()
        {
            //Creating a loop (for) to generate more situations
            //Создадим цикл, чтобы сгенерировать больше ситуаций
            for (int i = 0; i < 100; i++)
            {
                var rnd = new Random();

                //Initialize random value for coefficients of double variable type
                //Инициализируем случайные значения типа Double для переменных (коэффициентов)
                var a = rnd.NextDouble() * 100;
                var b = rnd.NextDouble() * 100;
                var c = rnd.NextDouble() * 100;

                //Solving the equation with random coefficients
                //Решаем уравнение со случайными коэффициентами
                var result = QuadraticEquationSolver.Solve(a, b, c);

                //Checking the quadratic equation solver, which should be zero
                //Подставляем корни в квадратичное уравнение, которое должно быть равно 0
                foreach (var x in result)
                {
                    Assert.AreEqual(0, a * x * x + b * x + c, 1e-10);
                    //Take into account a certain interval
                    //Учитываем не строгое равенство, а близость на таком промежутке 1е-10
                }

            }
        }

    }
}
