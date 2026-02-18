namespace lesson_5___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //double grade;
            //Console.WriteLine("What was your grade?");
            //Double.TryParse(Console.ReadLine(), out grade);
            //if (grade >= 50)
            //    Console.WriteLine("You Passed!");
            //else
            //    Console.WriteLine("Better luck next time.");


            //int age;
            //Console.WriteLine("What is your age?");
            //int.TryParse(Console.ReadLine(), out age);



            //if (age < 16)
            //    Console.WriteLine("I can drive without fear!");
            //else
            //    Console.WriteLine("The roads are not safe!");
            //if (age > 79)
            //    Console.WriteLine("OH MY GOD-GET OFF THE ROAD, OLD MAN!!!!");



            //int grade;
            //Console.WriteLine("What is your grade?");
            //int.TryParse(Console.ReadLine(), out grade);

            //if (grade < 50)
            //{
            //    Console.WriteLine("That is an F!");
            //}


            //else if (grade <= 65)
            //{
            //    Console.WriteLine("That is a D!");

            //}




            //else if (grade <= 75)
            //{
            //    Console.WriteLine("That is a C!");
            //}




            //else if (grade <= 85)

            //{
            //    Console.WriteLine("That is a B!");
            //}





            //else if (grade > 85)

            //{
            //    Console.WriteLine("Thats is an A!");

            //}

            double temperature;
            Console.WriteLine("Insert a temperature.");
            Double.TryParse(Console.ReadLine(), out temperature);

            if (temperature <= 0)
            {
                Console.WriteLine("Damn! That water is frozen!");
            }
            else if (temperature >= 100)
            {
                Console.WriteLine("Thats some gas right there!");
            }

            else if (temperature > 0)
            {
                Console.WriteLine("That sure is some liquid water right there!");
            }

            



           
        }
    }
}

