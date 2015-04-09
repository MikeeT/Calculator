using System;
using System.Collections.Generic;
using System.Linq;
public static class Calculator_solve
{
    public static int Solve(this string input)
    {
        /*
        function takes in string and puts numeric items in list
        takes operators and puts them in a list
        inputs:
            input - equation written in string format
        return:
            solution - the solution of the equation in integer form
        */

        //var declarations
        String E_string;
        int num_1 = 0;
        int count = 0;
        int index = 0;
        int number_count = 0;
        int solution;
        List<int> numeric_lst = new List<int>();
        List<char> operator_lst = new List<char>();

        E_string = Calculator_solve.RemoveWhitespace(input);

        foreach (char c in E_string)
        {
            if (E_string.Length == 1)
            {
                if (char.IsDigit(c))
                {
                    string s = Char.ToString(c);
                    solution = int.Parse(s);
                    return solution;
                }
                else
                {
                    solution = 0;
                    return solution;
                }
            }
            else if (c == '+')
            {
                operator_lst.Add('+');
                count = 0;
                index -= 1;
                number_count += 1;
            }
            else if (c == '-')
            {
                operator_lst.Add('-');
                count = 0;
                index -= 1;
                number_count += 1;
            }
            else if (c == '*')
            {
                operator_lst.Add('*');
                count = 0;
                index -= 1;
                number_count += 1;
            }
            else if (c == '/')
            {
                operator_lst.Add('/');
                count = 0;
                index -= 1;
                number_count += 1;
            }
            else if (count >= 1)
            {
                int number = numeric_lst.ElementAt(number_count);
                string num_str = Convert.ToString(number);
                string s = Char.ToString(c);
                string new_str = num_str + s;
                num_1 = int.Parse(new_str);
                numeric_lst.RemoveAt(number_count);
                numeric_lst.Insert(number_count, num_1);
                count += 1;
            }
            else if (char.IsDigit(c))
            {
                string s = Char.ToString(c);
                num_1 = int.Parse(s);
                numeric_lst.Add(num_1);
                count += 1;
            }
        }

        solution = Solve_util(operator_lst, numeric_lst);

        return solution;
    }
    public static int Solve_util( List<char> operator_lst, List<int> numeric_lst)
    {
        /*
        function takes two lists one filled with operators and the second numeric
        integers and solves the equation
        inputs:
            operator_lst - list of string operands. '+' '-' '*' '/'
            numeric_lst - list of numeric integers
        return:
            solution - the integer answer. form - integer operand integer
        */

        //var declarations
        int solution = 0;
        int index = 0;

        if(!operator_lst.Any())
        {
            solution = numeric_lst[0];
            return solution;
        }
        foreach (char c in operator_lst)
        {
            try
            {
                if (index == 0)
                {
                    if (c == '+')
                        solution = numeric_lst[index] + numeric_lst[index + 1];
                    else if (c == '-')
                        solution = numeric_lst[index] - numeric_lst[index + 1];
                    else if (c == '*')
                        solution = numeric_lst[index] * numeric_lst[index + 1];
                    else if (c == '/')
                        solution = numeric_lst[index] / numeric_lst[index + 1];
                    index += 2;
                }
                else
                {
                    if (c == '+')
                        solution += numeric_lst[index];
                    else if (c == '-')
                        solution -= numeric_lst[index];
                    else if (c == '*')
                        solution *= numeric_lst[index];
                    else if (c == '/')
                        solution /= numeric_lst[index];
                    index += 1;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Need two numbers for equation.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot Divide by zero.");
            }
        }
        return solution;
    }
    public static string RemoveWhitespace(this string input)
    {
        /*
        function takes a string input and removes excces whitespace
        inputs:
            input - string
        return:
            - string with removed whitespaces
        */
        return new string(input.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
    }
}
