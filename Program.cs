using System;

namespace Practica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor");

            Console.Write("Case 1: ");
            Range o5_o10 = new Range("(5,10)");
            o5_o10.IsInvalid();

            Console.Write("Case 2: ");
            Range j = new Range("(1,)");
            j.IsInvalid();

            Console.Write("Case 3: ");
            Range cminus1_c5 = new Range("[-1,5]");
            cminus1_c5.IsInvalid();

            Console.Write("Case 4: ");
            Range m = new Range("");
            m.IsInvalid();

            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            Console.WriteLine("Contains");
            Console.Write("Case 1: ");
            Console.WriteLine(o5_o10.Contains(6).ToString());

            Console.Write("Case 2: ");
            Range cminus8_o9 = new Range("[-8,9)");
            Console.WriteLine(cminus8_o9.Contains(9).ToString());

            Console.Write("Case 3: ");
            Range cminus2_c2 = new Range("[-2,2]");
            Console.WriteLine(cminus2_c2.Contains(-1, 0, 1).ToString());

            Console.Write("Case 4: ");
            Range o10_c20 = new Range("(10,20]");
            Console.WriteLine(o10_c20.Contains(19, 20, 21).ToString());

            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            Console.WriteLine("Does not Contains");
            Console.Write("Case 1: ");
            Console.WriteLine(o5_o10.DoesNotContains(6).ToString());

            Console.Write("Case 2: ");
            Console.WriteLine(cminus8_o9.DoesNotContains(9).ToString());

            Console.Write("Case 3: ");
            Console.WriteLine(cminus2_c2.DoesNotContains(-1, 0, 1).ToString());

            Console.Write("Case 4: ");
            Console.WriteLine(o10_c20.DoesNotContains(19, 20, 21).ToString());

            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            Console.WriteLine("Get All Points");
            int[] points;

            Console.Write("Case 1: ");
            points = new Range("(-1,5]").GetAllPoints();

            if (points == null)
                Console.WriteLine("null");
            else
                Console.WriteLine("[{0}]", string.Join(", ", points));

            Console.Write("Case 2: ");
            points = j.GetAllPoints();

            if (points == null)
                Console.WriteLine("null");
            else
                Console.WriteLine("[{0}]", string.Join(", ", points));

            Console.Write("Case 3: ");
            points = m.GetAllPoints();

            if (points == null)
                Console.WriteLine("null");
            else
                Console.WriteLine("[{0}]", string.Join(", ", points));

            Console.Write("Case 4: ");

            points = new Range("[-2,2)").GetAllPoints();
            if (points == null)
                Console.WriteLine("null");
            else
                Console.WriteLine("[{0}]", string.Join(", ", points));


            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            Console.WriteLine("Contains Range");

            Console.Write("Case 1: ");
            Console.WriteLine(o5_o10.ContainsRange(new Range("(6,9]")).ToString());

            Console.Write("Case 2: ");
            Console.WriteLine(cminus2_c2.ContainsRange(new Range("[-3,2)")).ToString());

            Console.Write("Case 3: ");
            Console.WriteLine(new Range("[5,10]").ContainsRange(new Range("(5,10)")).ToString());

            Console.Write("Case 4: ");
            Console.WriteLine(new Range("(3,8)").ContainsRange(new Range("[3,8]")).ToString());


            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            Console.WriteLine("Does Not Contains Range");

            Console.Write("Case 1: ");
            Console.WriteLine(o5_o10.DoesNotContainsRange(new Range("(6,9]")).ToString());

            Console.Write("Case 2: ");
            Console.WriteLine(cminus2_c2.DoesNotContainsRange(new Range("[-3,2)")).ToString());

            Console.Write("Case 3: ");
            Console.WriteLine(new Range("[5,10]").DoesNotContainsRange(new Range("(5,10)")).ToString());

            Console.Write("Case 4: ");
            Console.WriteLine(new Range("(3,8)").DoesNotContainsRange(new Range("[3,8]")).ToString());


            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            Console.WriteLine("End Points");
            int[] endpoints;

            Console.Write("Case 1: ");
            endpoints = cminus2_c2.EndPoints();

            if (endpoints == null)
                Console.WriteLine("null");
            else
                Console.WriteLine("[{0}]", string.Join(", ", endpoints));

            Console.Write("Case 2: ");
            endpoints = m.EndPoints();

            if (endpoints == null)
                Console.WriteLine("null");
            else
                Console.WriteLine("[{0}]", string.Join(", ", endpoints));

            Console.Write("Case 3: ");
            endpoints = new Range("(1,6]").EndPoints();

            if (endpoints == null)
                Console.WriteLine("null");
            else
                Console.WriteLine("[{0}]", string.Join(", ", endpoints));

            Console.Write("Case 4: ");
            endpoints = j.EndPoints();

            if (endpoints == null)
                Console.WriteLine("null");
            else
                Console.WriteLine("[{0}]", string.Join(", ", endpoints));


            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            Console.WriteLine("Equals");
            Console.Write("Case 1: ");
            Console.WriteLine(o5_o10.Equals(new Range("[6,9]")).ToString());

            Console.Write("Case 2: ");
            Console.WriteLine(cminus2_c2.Equals(new Range("[-3,2]")).ToString());

            Console.Write("Case 3: ");
            Console.WriteLine(new Range("[2,6]").Equals(new Range("(1,6]")).ToString());

            Console.Write("Case 4: ");
            Console.WriteLine(o5_o10.Equals(new Range("(5,9)")).ToString());


            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            Console.WriteLine("Does Not Equals");
            Console.Write("Case 1: ");
            Console.WriteLine(o5_o10.DoesNotEquals(new Range("[6,9]")).ToString());

            Console.Write("Case 2: ");
            Console.WriteLine(cminus2_c2.DoesNotEquals(new Range("[-3,2]")).ToString());

            Console.Write("Case 3: ");
            Console.WriteLine(new Range("[2,6]").DoesNotEquals(new Range("(1,6]")).ToString());

            Console.Write("Case 4: ");
            Console.WriteLine(o5_o10.DoesNotEquals(new Range("(5,9)")).ToString());


            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            Console.WriteLine("Overlaps");
            Console.Write("Case 1: ");
            Console.WriteLine(new Range("(2,6]").OverlapsRange(new Range("[4,5]")).ToString());

            Console.Write("Case 2: ");
            Console.WriteLine(new Range("[5,10]").OverlapsRange(new Range("(11,15)")).ToString());

            Console.Write("Case 3: ");
            Console.WriteLine(cminus2_c2.OverlapsRange(new Range("(1,6]")).ToString());

            Console.Write("Case 4: ");
            Console.WriteLine(o5_o10.OverlapsRange(new Range("(10,20)")).ToString());



        }
    }
}

