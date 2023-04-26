class C6Q26
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; ++i) 
        {
            for (int j = 1; j <= 3; ++j)
            {
                for (int k = 1; k <= 4; ++k)
                {
                    Console.Write('*');
                }
                // end of inner loop

                Console.WriteLine();
            }
            // end of mid loop

            Console.WriteLine();
        }
        // end of outer loop
    }
    // end of main method
}
// end of class
