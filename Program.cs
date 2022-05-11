namespace WorkOut
{
    class Program
    {
        public static void Main()
        {
            int r1 = 80, r2 = 12, r3 = 120, r4 = 219;
            int ans = r4 | r3 << 8;
            int r3LeftShift8 = r3 << 8;
            int ans2 = r4 | r3LeftShift8;
            Console.WriteLine(Convert.ToString(r3, 2) + "        " + r3LeftShift8 + "        " + Convert.ToString(r3LeftShift8, 2));
            Console.WriteLine(ans + "   " + ans2);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}