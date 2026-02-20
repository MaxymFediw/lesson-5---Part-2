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

            //double temperature;
            //Console.WriteLine("Insert a temperature.");
            //Double.TryParse(Console.ReadLine(), out temperature);

            //if (temperature <= 0)
            //{
            //    Console.WriteLine("Damn! That water is frozen!");
            //}
            //else if (temperature >= 100)
            //{
            //    Console.WriteLine("Thats some gas right there!");
            //}

            //else if (temperature > 0)
            //{
            //    Console.WriteLine("That sure is some liquid water right there!");
            //}

            //int age;
            //Console.WriteLine("What is your age?");
            //int.TryParse(Console.ReadLine(), out age);

            //if (age >= 13 && age <= 19)
            //{
            //    Console.WriteLine("You're a teenager!");
            //}

            //else 
            //{
            //    Console.WriteLine("You are NOT a teenager.");
            //}

            // string answer, A, a, B, b, C, c;
            // Console.WriteLine("2 plus 2 equals 4. 4 divided by 2 is what? Choose A, B, or C.");

            // Console.WriteLine("A) 8.");
            // Console.WriteLine("B) 12.");
            // Console.WriteLine("C) All of the above.");


            // Console.WriteLine("Your answer here:");

            //answer = Console.ReadLine();

            // if (answer == "A")
            // {
            //     Console.WriteLine("Oh my God-What an idot!");
            // }

            // if (answer == "B") 
            // {
            //     Console.WriteLine("Holy dumbass, nerd!");
            // }

            // if (answer == "C") 
            // {
            //     Console.WriteLine("Go back to second grade, kid.");
            // }

            // if (answer == "a") 
            // {
            //     Console.WriteLine("Oh my days-IQ of a rock!");
            // }

            // if (answer == "b") 
            // {
            //     Console.WriteLine("You thought you were smart? WRONG!");
            // }

            // if (answer == "c") 
            // {
            //     Console.WriteLine("Somebody should get off Roblox.");
            // }

            // if (answer == "2")
            // {
            //     Console.WriteLine("Heh heh... You thought you could get around my little ploy, eh? HELL NO! Does you mom hate you? Do you lack sefficient  attention from you parents? Either way, YOU. ARE. WRONG!!!!!!");
            // }

            // else 
            // {
            //     Console.WriteLine("Bro didnt even ATTEMPT the question. You call yourself a free thinker? Sorry to break the news, but NOBODY CARES. GO    WITH THE HERD, NERD! YOU ARE NOT SPECIAL. ...And you never WILL be.");
            // }

            //int age;
            //Console.WriteLine("What is your age?");
            //int.TryParse(Console.ReadLine(), out age);

            //if (age >= 60)
            //{
            //    Console.WriteLine("Well, Grandad - Your buss fee will be $2.00.");
            //}

            //else 
            //{
            //    Console.WriteLine("Your fee will b $3.50.");
            //}

            //string favouriteAnimal;
            //Console.WriteLine("Whats YOUR favourite animal?");
            //favouriteAnimal = Console.ReadLine().ToUpper();

            //if (favouriteAnimal == "North American Beaver") 
            //{
            //    Console.WriteLine("Same, twin!");
            //}

            //else
            //{
            //    Console.WriteLine("Wrong.");
            //}

            string weather;
            int temp;
            Console.WriteLine("Whats the weather?");
            weather = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out temp);

            if (temp >= 25) 
            {
                Console.WriteLine("Hop in the pool, twin!");
            }

            if (weather == "sunny") 
            {
                Console.WriteLine("Get yo swim on, twin!");
            }

            if (weather == "Sunny")
            {
                Console.WriteLine("Get in the damn pool.");
            }

            else 
            {
                Console.WriteLine("Nap time, twin!");
            }







        }
    }
}

