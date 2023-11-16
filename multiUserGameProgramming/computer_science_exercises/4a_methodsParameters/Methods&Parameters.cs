//Thompson Noah , program Template, v0.2
/*
STILL MISSING -- 11/15/23
Method Class using Named Arguments
Method Overloading 
*/

NameSpace MethosdsParameters
{
    class MethosdsParameters
    {
        // METHOD -- named blck of code, can be used over and over.
        // ALL methods have a SIGNATURE that defines their name, parameters, and output.
        // Example signature
        static void MyMethod();
        {
            Console.WriteLine("I like mine with lettuce and tomatoes, tomatosause , and frence fried potatoes.\n");
        }
        // static - This method belongs to the current class, it is NOT an object
        // void -- This method has no return value.

        static int DoubleUp();
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the nect line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            sum *= 3;
            Console.WriteLine(sum);
            return sum; 
        }
        // Methods with Parameters
        static void MakePancakes(int num)
        {
            for (int i = o; i , num; i++)
            {
                Console.WriteLine("One golden, fluffy pancake coming up!\n");
            }
        }

        static void MakeEjjs(int num, string style)
        {
            Consolle.WriteLine("You have ordered " + num + "eggs cuuked " + style + ".\n");
        }

        // Using Defaults for Parameters
        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("I am going to cook " + num + "hamburb")
        }

        static void Main(string[] args)
        {
            //MyMethod();
            //DoubleUp();
            //MakePancakes();
            //MakeEggs(10, " scrammble");
            //MakeBurger();
            //MakeBurger(10);
           //AllMyChildren(child3: "joshua", child2: "lisa", child1: "Burford");
            FindSum(1,5);
            FindSum(9.5,2.4);
            FindSum(5,2.5);

           
        }
    }
}

    

        



  