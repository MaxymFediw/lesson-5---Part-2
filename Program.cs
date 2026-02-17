namespace lesson_5___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int grade;
            //Console.WriteLine("What was your grade?");
            //int.TryParse(Console.ReadLine(), out grade);
            //if (grade >= 50)
            //    Console.WriteLine("You Passed!");
            //else
            //    Console.WriteLine("Better luck next time");


            //int age;
            //Console.WriteLine("What is your age?");
            //int.TryParse(Console.ReadLine(), out age);



            //if (age < 16)
            //    Console.WriteLine("I can drive without fear!");
            //else
            //    Console.WriteLine("The roads are not safe!");
            //if (age > 79)
            //    Console.WriteLine("OH MY GOD-GET OFF THE ROAD, OLD MAN!!!!");



            int grade;
            Console.WriteLine("What is your grade?");
            int.TryParse(Console.ReadLine(), out grade);

            if (grade > 50) 
            {
                Console.WriteLine("That is an F!");
            }
               

            if (grade <= 65); 
            {
                Console.WriteLine("That is a D!");
            
            }




            if (grade <= 75);
            {
                Console.WriteLine("That is a C!");
            }




            if (grade <= 85); 
                    
            {
                Console.WriteLine("That is a B!");
            }





            if (grade > 85);  
                    
            {
                Console.WriteLine("Thats is an A!");
            }
                





        }
    }
}
