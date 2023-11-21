namespace day4
{
    class program
    {
        static void Main()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            string [] names = new string[3];
            names[0] = "Halima";
            names[1] = "Amur";
            names[2] = "Rashid";
            //
            int[,] Grades = new int[2 , 2];
            Grades[0, 0] = 3;
            Grades[0, 1] = 2;
            Grades[1, 0] = 4;
            Grades[1, 1] = 1;
            //Jagged array
            int[][] students = new int[2][];
            students[0] = new int[1] { 2 };
            students[1] = new int[3] { 1, 6, 7 };

            //if condition
            Console.WriteLine("please enter student grade");
            int value = Convert.ToInt32(Console.ReadLine);
            if (value >= 75)
            {
                Console.WriteLine("succecud");

                //coffee shop
                
            }
        }

    }
}
