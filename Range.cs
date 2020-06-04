using System;

namespace Practica_4
{
    public class Range
    {
        public int Min;
        public int Max;
        public string Expression;
        public bool invalid;

        public Range(string expression)
        {
            this.Expression = expression;

            if (string.IsNullOrEmpty(expression))
            {
                invalid = true;
                return;
            }
            if (!expression.Contains(","))
            {
                invalid = true;
                return;
            }

            if (expression[0] != '[' && expression[0] != '(')
            {
                invalid = true;
                return;
            }

            if (expression[expression.Length - 1] != ']' && expression[expression.Length - 1] != ')')
            {
                invalid = true;
                return;
            }


            if (expression[1] == '-' && expression.Length >= 5)
            {
                if (!char.IsDigit(expression[2]))
                {
                    invalid = true;
                    return;
                }
            }

            if (!char.IsDigit(expression[expression.Length - 2]))
            {
                invalid = true;
                return;
            }

            int count = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (!char.IsDigit(expression[i]) && expression[i] != '-')
                {
                    count++;
                }

                if (count > 3)
                {
                    this.invalid = true;
                    return;
                }

            }

            string[] numbers = expression.Split(',');
            int min = Convert.ToInt32(numbers[0].TrimStart('[', '('));
            int max = Convert.ToInt32(numbers[1].TrimEnd(']', ')'));


            if (expression[expression.Length - 1] == ')')
                max = max - 1;


            if (expression[0] == '(')
                min = min + 1;

            if (min > max)
            {
                invalid = true;
                return;
            }

            Min = min;
            Max = max;
        }

        public bool Contains(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (this.Min > numbers[i])
                    return false;
                if (this.Max < numbers[i])
                    return false;
            }

            return true;
        }

        public bool DoesNotContains(params int[] numbers)
        {
            return !Contains(numbers);
        }

        public bool ContainsRange(Range other)
        {
            if (other.Min < this.Min || other.Max > this.Max)
            {
                return false;
            }

            return true;
        }

        public bool DoesNotContainsRange(Range other)
        {
            return !ContainsRange(other);
        }

        public int[] GetAllPoints()
        {
            if (this.invalid)
            {
                return null;
            }

            int[] points = new int[this.Max - this.Min + 1];
            int counter = 0;
            for (int i = this.Min; i <= this.Max; i++)
            {
                points[counter] = i;
                counter++;
            }

            return points;
        }

        public int[] EndPoints()
        {
            if (this.invalid)
            {
                return null;
            }
            int[] endpoints = { this.Min, this.Max };
            return endpoints;
        }

        public bool OverlapsRange(Range other)
        {
            if (this.Min <= other.Max && other.Min <= this.Max)
            {
                return true;
            }
            return false;
        }

        public bool Equals(Range other)
        {
            if (this.Min == other.Min && this.Max == other.Max)
                return true;

            return false;
        }

        public bool DoesNotEquals(Range other)
        {
            return !Equals(other);
        }

        public void IsInvalid()
        {
            if (this.invalid)
            {
                Console.WriteLine($"Invalid Range: \"{this.Expression}\"");
            }
            else
            {
                Console.WriteLine($"Range created successfully: \"{this.Expression}\"");
            }
        }
    }
}