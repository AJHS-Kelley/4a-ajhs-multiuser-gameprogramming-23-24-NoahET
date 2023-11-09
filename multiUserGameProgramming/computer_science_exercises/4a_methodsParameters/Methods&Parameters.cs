Thompson Noah , program Template, v0.2

NameSpace MethosdsParameters

    class MethosdsParameters
    
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

        



  