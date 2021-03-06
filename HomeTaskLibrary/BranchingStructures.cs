using System;

namespace HomeTaskLibrary
{
    public class BranchingStructures
    {
        public static double CalculateAB(double a, double b)
        {
            //Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
            double result = 0;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else if (a < b)
            {
                result = a - b;
            }

            return result;
        }

        public static int getQuarter(double x, double y)
        {
            //Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
            int result = 0;
            if (x == 0 || y == 0)
            {
                result = 0;
            }
            else if (x > 0 && y > 0)
            {
                result = 1;
            }
            else if (x < 0 && y > 0)
            {
                result = 2;
            }
            else if (x < 0 && y < 0)
            {
                result = 3;
            }
            else if (x > 0 && y < 0)
            {
                result = 4;
            }

            return result;
        }

        public static void SortThreeVariables(ref double a, ref double b, ref double c)
        {
            //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
            if (a > c)
            {
                Swap(ref a, ref c);
            }
            if (a > b)
            {
                Swap(ref a, ref b);
            }
            if (b > c)
            {
                Swap(ref b, ref c);
            }
        }        

        public static double[] GetQuadraticEquationSolving(double a, double b, double c)
        {
            //Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) 
            //квадратного уравнения стандартного вида, где AX2+BX+C=0.

            double[] results;            
            double discriminant = b * b - 4 * a * c;

            if(a == 0)
            {
                throw new Exception("a == 0. It`s not a Quadratic Equation");
            }
            if (discriminant < 0)
            {
                results = new double[0];
            }
            else if (discriminant > 0)
            {
                results = new double[2];
                results[0] = ((-b - Math.Sqrt(discriminant)) / (2 * a));
                results[1] = ((-b + Math.Sqrt(discriminant)) / (2 * a));                
            }
            else
            {
                results = new double[1];
                results[0] = (-b / (2 * a));                
            }
            return results;
        }

        public static string NumpToText(int numb)
        {
            //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. 
            //Например при вводе “25” в консоль будет выведено “двадцать пять”.
            string outputText = string.Empty;
            if (numb < 20)
            {
                switch (numb)
                {
                    case 10:
                        outputText = "Ten";
                        break;
                    case 11:
                        outputText = "eleven";
                        break;
                    case 12:
                        outputText = "twelve";
                        break;
                    case 13:
                        outputText = "thirteen";
                        break;
                    case 14:
                        outputText = "fourteen";
                        break;
                    case 15:
                        outputText = "fifteen";
                        break;
                    case 16:
                        outputText = "sixteen";
                        break;
                    case 17:
                        outputText = "seventeen";
                        break;
                    case 18:
                        outputText = "eighteen";
                        break;
                    case 19:
                        outputText = "nineteen";
                        break;
                }
            }
            else
            {
                int tens = numb / 10;
                int units = numb % 10;
                switch (tens)
                {
                    case 2:
                        outputText += "twenty";
                        break;
                    case 3:
                        outputText += "thirty";
                        break;
                    case 4:
                        outputText += "forty";
                        break;
                    case 5:
                        outputText += "fifty";
                        break;
                    case 6:
                        outputText += "sixty";
                        break;
                    case 7:
                        outputText += "seventy";
                        break;
                    case 8:
                        outputText += "eighty";
                        break;
                    case 9:
                        outputText += "ninety";
                        break;
                }
                if (units != 0) outputText += "-";
                switch (units)
                {
                    case 1:
                        outputText += "one";
                        break;
                    case 2:
                        outputText += "two";
                        break;
                    case 3:
                        outputText += "three";
                        break;
                    case 4:
                        outputText += "four";
                        break;
                    case 5:
                        outputText += "five";
                        break;
                    case 6:
                        outputText += "six";
                        break;
                    case 7:
                        outputText += "seven";
                        break;
                    case 8:
                        outputText += "eight";
                        break;
                    case 9:
                        outputText += "nine";
                        break;
                }
            }
            return outputText;
        }

        public static void Swap(ref double a, ref double b)
        {
            double tmp = a;
            a = b;
            b = tmp;
        }

        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
